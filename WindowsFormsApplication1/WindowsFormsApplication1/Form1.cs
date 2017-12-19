using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
    
        public static string voltageData;//电压数据
        public static string electricData;//充放电流数据
        public static string leakElectricData;//漏电流数据
        public static string changingPowerData;//充电功率
        public static string insulationRes;//绝缘电阻
        public static string gearGain;//档位增益
        public static string patternData; //工作模式数据
        public SysSet.SettingsStruct setData = new SysSet.SettingsStruct();//定义设置的参数类

        public static bool testStartFlag=false;//定义测试是否开始的标志，并初始化为false
        public static bool setDataDownloadSuccessFlag = false;//定义设置参数是否成功下载到下位机的标志，并初始化为false
        public static ResultDisplay resultData = new ResultDisplay();//定义一个用于存储画图数据的类对象，里面用列表存储了读取的电流电压和漏电流的数据
        public static string portNum; //选择框中选择的串口号


        //SCPI相关变量
        public static string[] SCPIConnect = new string[] { "COMM:SADD", "COMM:REM" };//SCPI模块联机顺序指令
        public static string[] SCPISetPre = new string[] { "STEP:DCW:VOLT_", "STEP:DCW:CURR_", "STEP:DCW:POW_", "STEP:DCW:MOR_", "STEP:DCW:HIGH_",
            "STEP:DCW:DPOW_", "STEP:MODE:","STEP:DCW:OVRS_","STEP:DCW:OVFS_","SOUR:TEST:CMOD_"};//设置参数的SCPI指令的前缀
        //依次存放请求：电压，漏电流，绝缘电阻/充放电流/充电功率/档位增益/测试阶段的SCPI指令
        public static string[] SCPIsendGetData = { "RES:MEAS:ALL?", "STEP:DCW:HIGH?", "STEP:DCW:DPOW?", "STEP:DCW:RANG?", "STEP:DCW:STAG?" };//请求结果数据的SCPI指令
        public static string successReceiveMes = "+0,\"No error\"";//指令接收或者发送成功返回的信息  
        public static string SCPIDisconnect = "COMM:LOC";//退出远控状态的SCPI指令 
        public static string SCPIReset = "*RST";//对设备进行复位的SCPI指令   
        public static bool SCPIsendSuccessFlag = false;//每条SCPI指令发送给下位机成功的标志        
        public static bool time3Flag = false;//定时器三到的标志
        public static float xUnitTime = 0;//请求数据频率的定时器1的定时时间      
        public static char end1 = (char)0x0d;
        public static char end2 = (char)0x0a;
        public static string  errorCode = "" + (char)0x00+ (char)0x80;//校验出错的SCPI指令和校验码
        public static List<byte> receiveTempData = new List<byte>();//暂存从下位机接收到的数据
        public static int SCPIGetDataCount = 0;
        //2b 30 2c 22 4e 6f 20 65 72 72 6f 72 22 d2 0d 0a   返回指令接收成功的SCPI指令16进制显示（包括验证码和结束码）
        //31 34 38 2F 35 32 30 2F 39 35 80 0d 0a    返回请求的结果数据（包含斜杠的）SCPI格式16进制显示（包括验证码和结束码）
        //38 39 F1 0d 0a     返回请求的充放电流数据SCPI格式16进制显示（包括验证码和结束码）


        public Form1()
        {
            InitializeComponent();
            InitDelegate();//委托初始化
            InitZedgraph();//图表初始化
            timer2.Start();
            
        }

        //显示曲线图的初始化设置
        public void InitZedgraph()
        {
            //电压波形图初始化设置
            GraphPane voltagePane = voltageGraph.GraphPane;
            voltagePane.Title.Text = "电压波形";
            voltagePane.XAxis.Title.Text = "时间（s）";
            voltagePane.YAxis.Title.Text = "电压(V)";

            //voltagePane.XAxis.Scale.Min = 0;
            //voltagePane.XAxis.Scale.Max = 512;

            //voltagePane.XAxis.Scale.MinorStep = 16;
            //voltagePane.XAxis.Scale.MajorStep = 64;

            //voltagePane.YAxis.Scale.Min = 0;
            //voltagePane.YAxis.Scale.Max = 255;

            //voltagePane.YAxis.Scale.MinorStep = 8;
            //voltagePane.YAxis.Scale.MajorStep = 32;

            voltagePane.XAxis.MajorGrid.IsVisible = true;
            voltagePane.YAxis.MajorGrid.IsVisible = true;

            //电流波形图初始化设置
            GraphPane electricPane = electricGraph.GraphPane;
            electricPane.Title.Text = "电流波形";
            electricPane.XAxis.Title.Text = "时间(s)";
            electricPane.YAxis.Title.Text = "电流(mA)";

            //electricPane.XAxis.Scale.Min = 0;
            //electricPane.XAxis.Scale.Max = 512;

            //electricPane.XAxis.Scale.MinorStep = 16;
            //electricPane.XAxis.Scale.MajorStep = 64;

            //electricPane.YAxis.Scale.Min = 0;
            //electricPane.YAxis.Scale.Max = 255;

            //electricPane.YAxis.Scale.MinorStep = 8;
            //electricPane.YAxis.Scale.MajorStep = 32;

            electricPane.XAxis.MajorGrid.IsVisible = true;
            electricPane.YAxis.MajorGrid.IsVisible = true;

            //漏电流图初始化设置
            GraphPane arcPane = leakElectricGraph.GraphPane;
            arcPane.Title.Text = "漏电流波形";
            arcPane.XAxis.Title.Text = "时间（s）";
            arcPane.YAxis.Title.Text = "漏电流(nA)";

            //arcPane.XAxis.Scale.Min = 0;
            //arcPane.XAxis.Scale.Max = 512;

            //arcPane.XAxis.Scale.MinorStep = 16;
            //arcPane.XAxis.Scale.MajorStep = 64;

            //arcPane.YAxis.Scale.Min = 0;
            //arcPane.YAxis.Scale.Max = 255;

            //arcPane.YAxis.Scale.MinorStep = 8;
            //arcPane.YAxis.Scale.MajorStep = 32;

            arcPane.XAxis.MajorGrid.IsVisible = true;
            arcPane.YAxis.MajorGrid.IsVisible = true;

        }




        //form1加载时的显示(设置里面的下拉选项)
        private void Form1_Load(object sender, EventArgs e)
        {
            //枚举（列出）参数设置里面的输出电阻值
            comboBox1.Items.Add("NONE");
            comboBox1.Items.Add("DIOD");
            comboBox1.Items.Add("100k");
            comboBox1.Items.Add("1M");
            comboBox1.Items.Add("10M");
            comboBox1.SelectedIndex = 0; //下拉列表默认选择项是第一项，即：NONE
        
            //枚举（列出）参数设置里面的测量模式
            comboBox3.Items.Add("IR");
            comboBox3.Items.Add("LC");
            comboBox3.SelectedIndex = 0; //下拉列表默认选择项是第一项，即：IR

            //枚举（列出）参数设置里面的充电模式
            comboBox2.Items.Add("AUTO");
            comboBox2.Items.Add("MANU");
            comboBox2.SelectedIndex = 0; //下拉列表默认选择项是第一项，即：IR

            //保证下拉框只能选择不能自己填入
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            PortNums.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] portNums=UsbIO.getComNums(); // 打开硬件设备，获取到端口号
            //枚举（列出）获得的串口号
            foreach (string s in portNums)
            {
                PortNums.Items.Add(s);
            }
            PortNums.SelectedIndex = 0; //下拉列表默认选择项是第一个串口号
            
           UsbIO.setForm(this);//创建一个实例,把该界面和UsbIO中的静态变量form1绑定在一起
           
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
 
        //打开连接按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (!UsbIO.is_Open())//确保设备处于未连接状态再进行连接操作，否则不操作
            {
                portNum = PortNums.Text;
                UsbIO.Open_Port(); // 打开串口 
                UsbIO.DataRecieveStart();//开始串口接收数据的线程           
                if (UsbIO.is_Open())
                {
                    bool successFlag = SendDataHandle.SCPIConnect();//发送SCPI联机指令给下位机
                    if (successFlag)
                    {
                        MessageBox.Show("设备连接成功"); //弹出提示对话框
                        textBox11.Text = "设备已连接"; //显示设备连接状态
                    }
                    else
                    {
                        MessageBox.Show("设备连接失败"); //弹出提示对话框
                        textBox11.Text = "设备未连接"; //显示设备连接状态
                    }

                }
                else
                {
                    MessageBox.Show("串口未打开"); //弹出提示对话框
                    textBox11.Text = "设备未连接"; //显示设备连接状态
                }
            }
                   
        }

            
        //关闭连接按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (UsbIO.is_Open())//确保是设备处于连接状态才进行关闭连接的操作
            {
                SendDataHandle.SCPICDisconnect();//先向下位机发送退出远控状态的指令
                UsbIO.DataRecieveStop();//结束串口接收数据的线程 
                UsbIO.Close_Port();//关闭串口连接               
                if (!UsbIO.is_Open())
                {
                    MessageBox.Show("设备已断开连接"); //弹出提示对话框
                    textBox11.Text = "设备未连接"; //显示设备连接状态
                }
                else
                {
                    MessageBox.Show("设备连接断开失败"); //弹出提示对话框
                }
            }                        
        }

        //参数下载按钮
        private void button5_Click(object sender, EventArgs e)
        {
            if (UsbIO.is_Open())
            { 
                ReadSet();//读取设置的参数，并在ReadSet函数里调用sendToCMDMachine函数把设置的参数发送给下位机
                if (setDataDownloadSuccessFlag)
                {
                    textBox13.Text = "参数下载成功";
                    setDataDownloadSuccessFlag = false;
                }
                else
                {
                    textBox13.Text = "参数下载失败";
                }
            }
            else
            {
                MessageBox.Show("设备未连接，请先连接设备"); //弹出提示对话框
            }
            
        }

        //开始测试按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (UsbIO.is_Open())
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("请求时间不能为空，请先填写请求时间！"); //弹出提示对话框
                }
                else
                {
                    TaskGatherRealTime = new Thread(GatherRealTime);//开启（创建）一个绘图线程
                    startTest();//调用测试开始的函数
                }
                
            }
            else
            {
                MessageBox.Show("设备未连接，请先连接设备"); //弹出提示对话框
            }

        }

        //结束测试按钮
        private void button4_Click(object sender, EventArgs e)
        {
            if (testStartFlag == true)
            {
                closeTest();//调用测试关闭的函数
                clearAllShowData();//调用清空整个上位机界面数据参数的函数
            }
            else
            {

            }

        }
        //复位按钮
        private void button6_Click(object sender, EventArgs e)
        {
            //先发送给下位机复位信号，确定下位机已经复位后再关闭测试并清空数据
            SendDataHandle.reset();
            closeTest();//调用测试关闭的函数           
            clearAllShowData();//调用清空整个上位机界面数据参数的函数
        }

        //数据清空按钮
        private void button7_Click(object sender, EventArgs e)
        {
            clearShowGetSendData();//清空接收区和发送区的显示数据
        }

        //从参数设置里读取内容，并判断设备连接状态和参数设置是否为空
        private void ReadSet()
        {
            setData.testVoltage = textBox10.Text;//得到设置的测试电压值
            setData.electricUpLimit = textBox9.Text;//得到设置的充电电流上限值
            setData.powerUpLimit = textBox8.Text;//得到充电功率上限值
            setData.outputRes = comboBox1.Text;//得到输出电阻值
            setData.dischargeElectric = textBox7.Text;//得到放电电流值
            setData.dischargePower = textBox1.Text;//得到放电功率值
            setData.measurePattern = comboBox3.Text;//得到测量模式
            setData.voltageRiseSlope = textBox3.Text;//（高压源的最大输出电压）电压上升斜率
            setData.voltageDropSlope = textBox4.Text;//（高压源的最大输出电压）电压下降斜率
            setData.chargePattern = comboBox2.Text;//得到充电模式

            //判断设置参数是否填写完整
            if (UsbIO.is_Open())
            {
                if (setData.testVoltage == "" || setData.electricUpLimit == ""
                    || setData.powerUpLimit == "" || setData.outputRes == ""
                    || setData.dischargeElectric == "" || setData.dischargePower == ""
                    || setData.measurePattern == "" || setData.voltageRiseSlope == ""
                    || setData.voltageDropSlope == "" || setData.chargePattern == ""
                    )
                {
                    MessageBox.Show("设置参数不能为空，请填写完整！"); //弹出提示对话框
                   
                }
                else
                {                
                        SendDataHandle.SendToCMDMachine(setData);//用于发送设置参数到下位机                                       
                }               
            }
            else
            {
                MessageBox.Show("设备未连接！");//弹出提示对话框
            }
        }



        //把得到的结果进行显示
        //显示解析后的结果参数
        public void ResultShow()
        {
            voltage.Text = voltageData;//显示电压值
            electric.Text = electricData;//显示电流值
            leakElectric.Text = leakElectricData;//显示漏电流
            changingPower.Text = changingPowerData;//显示充电功率
            pattern.Text = patternData;//模式（工作状态）
            Res.Text = insulationRes;//绝缘电阻
            gGain.Text = gearGain;//档位增益
        }
        

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;            
            if (electricData != "" && voltageData != "" && leakElectricData != "")//判断是不是第一次请求数据，即变量中有没有结果数据
            {
                SaveDataToLocal.writeFile();//把电压电流和漏电流数据都存入到电脑中去
                ResultShow();//显示结果刷新
            }


            if (testStartFlag)//是正在进行测试，可以发送请求数据指令
            {
                string[] SCPIsendGetDataPackOver = SendDataHandle.PackageDataOver(SCPIsendGetData);//给请求指令加上校验码和结束码
                SendDataHandle.sendGet(SCPIsendGetDataPackOver);//发送得到数据的请求
             
            }

            timer1.Enabled = true;//如果不先把enabled设置成false对话框会一直弹下去
        }

        //每秒刷新一次时间
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            timeNow.Text = DateTime.Now.ToString();

            timer2.Enabled = true;//如果不先把enabled设置成false对话框会一直弹下去
        }

        //测试开始的函数
        public static void startTest()
        {
            UsbIO.DataRecieveStart();//开始接收数据           
            TaskGatherRealTime.Start();//开始接受绘图数据的线程
            SaveDataToLocal.createPathFile();//创建指定目录和存储数据的txt文件
            testStartFlag = true;//开始测试标志置一
            UsbIO.form1.textBox14.Text = "正在测试"; //显示测试状态
            UsbIO.form1.timer1.Interval = Convert.ToInt32(UsbIO.form1.textBox2.Text);//把设置的请求时间间隔设置到定时器1中去
            float a = UsbIO.form1.timer1.Interval;
            xUnitTime = a / 1000;//趋势图单个横坐标单位长度
            UsbIO.form1.timer1.Start();//开启定时器
        }

        //测试关闭的函数
        public static void closeTest()
        {
            UsbIO.DataRecieveStop();//停止接收接收数据
            Form1.isGather = false;//停止绘图显示的线程
            Form1.testStartFlag = false;//开始测试标志置零
            UsbIO.form1.Text = "测试未开始"; //显示测试状态
            UsbIO.form1.timer1.Stop();//关闭定时器 
                       
        }

        //弹出对话框提示的函数
        public static void dialogMessageShow(string str)
        {
            MessageBox.Show(str);
        }
        //接收区发送区的数据清空方法
        public void clearShowGetSendData()
        {
            receiveBox.Text = "";
            sendBox.Text = "";
        }
        //复位时清空整个界面数据的方法
        public void clearAllShowData()
        {
            clearShowGetSendData();//接收区发送区的数据清空
            voltage.Text = "";//显示电压值清空
            electric.Text = "";//显示电流值清空
            leakElectric.Text = "";//显示漏电流清空
            changingPower.Text = "";//显示充电功率清空
            pattern.Text = "";//模式（工作状态）清空
            Res.Text = "";//绝缘电阻清空
            gGain.Text = "";//档位增益清空
            resultData.electricData.Clear();//清空画图LIST中电流数据
            resultData.voltageData.Clear();//清空画图LIST中电压数据
            resultData.leakElectricData.Clear();//清空画图LIST中漏电流数据
        }

        //延时函数
        public static void Delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Milliseconds;
                Application.DoEvents();
            }
            while (s < delayTime);
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
      

        private void 数据接收_Enter(object sender, EventArgs e)
        {

        }

        private  void receiveBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
