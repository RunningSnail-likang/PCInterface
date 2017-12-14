using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
     class UsbIO
    {
        private static SerialPort port = new SerialPort();  //定义一个串口对象
        //private static List<int> portNum;  //串口号列表
        public static int timeFlag = 0;
        public static Form1 form1=new Form1();

        public static void setForm(Form1 form)
        {
            form1 = form;
        }
      //判断是否有串口，并检测所有串口号
       public static string[] getComNums()
        {
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");           
            }
            return str;//返回所有检测到的串口数
        }

        /// <summary>
        /// 返回端口的状态，是否打开
        /// </summary>
        /// <returns></returns>
        public static bool is_Open()
        {
            return port.IsOpen;

        }

        //打开串口连接
        public static void Open_Port()
        {
            try
            {
                if (!port.IsOpen)
                {                   
                    port.PortName = Form1.portNum;
                    port.BaudRate = 115200;
                    port.DataBits = 8;
                    port.StopBits = StopBits.One;
                    port.ReadTimeout = 1000;
                    port.Open();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }


        //关闭串口连接
        public static void Close_Port()
        {
            port.Close();

        }


        //开始接受数据
        public static void DataRecieveStart()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(DataRecieve);
            //将错误提示禁用了，仍然存在跨线程调用控件的问题,为了解决数据接收线程中无法操作显示接收数据的窗口控件,
            //为此可能造成两个线程同时或者循环改变该控件的状态导致线程死锁。
            Control.CheckForIllegalCrossThreadCalls = false;//错误提示禁用

        }

        //停止数据接收
        public static void DataRecieveStop()
        {
            port.DataReceived -= new SerialDataReceivedEventHandler(DataRecieve);
        }

        /*在SerialPort类中有DataReceived事件，当串口的读缓存
        有数据到达时则触发DataReceived事件，其中SerialPort.ReceivedBytesThreshold属性决
        定了当串口读缓存中数据多少个时才触发DataReceived事件，默认为1。
        */
        //数据接收处理函数
        public static void DataRecieve(object sender, SerialDataReceivedEventArgs e)
        {
            Form1.Delay(10); //延时10毫秒,已达到直接读取整个一条指令的目的       
            int count = port.BytesToRead;//获取输入缓冲区的字节个数
            if (count <= 0)
            {
                return;
            }
            lock ("lock")
            {
                byte[] buf = new byte[count];//建立一个与缓冲区字节数大小相等字节数组               
                port.Read(buf, 0, count);//把缓冲区的数据存入buf数组       
                ReceiveDataHandle.SCPIReceiveJudge(buf); //根据SCPI协议对从缓冲区读入的数据进行解析，并进行相应的数据操作
            }
        }

  
        //实现在数据接收区显示接收到的SCPI指令的函数
        public static void receiveDataShow(string str)
        {
            form1.receiveBox.AppendText(str);//添加字符串文本，并加上换行符
            form1.receiveBox.ScrollToCaret();//自动显示至最后行              
        }
       
        //实现在数据发送区显示发送的SCPI指令的函数
        public static void sendDataShow(string str)
        {
            form1.sendBox.AppendText(str);//添加字符串文本，并加上换行符
            form1.sendBox.ScrollToCaret();//自动显示至最后行
        }


        //把数据或者参数发送给下位机
        public static void sendToARM(string str)
        {                
            if (port.IsOpen)
            {
                
                port.Write(str);
                sendDataShow(str); //调用方法把发送的SCPI指令显示到发送数据窗口            
            }
            else
            {
                MessageBox.Show("设备未打开连接");
            }
        }
  

    }




}
