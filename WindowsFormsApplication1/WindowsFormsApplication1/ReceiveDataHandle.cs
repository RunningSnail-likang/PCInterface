using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ReceiveDataHandle
    {
        //判断并得到SCPI指令
        public static void SCPIReceiveJudge(byte[] buf)
        {
            bool endFlag = false;//用来判断结束码的两个字节均满足要求         
            foreach (byte b in buf)
            {
                Form1.receiveTempData.Add(b);
                //UsbIO.receiveDataShow(System.Text.Encoding.Default.GetString(Form1.receiveTempData.ToArray()));//调用方法把接收到的SCPI指令信息显示到接收数据窗口
                if (b == Form1.end1)
                {
                    endFlag = true;
                }
                if (b == Form1.end2 && endFlag)
                {
                    endFlag = false;
                    UsbIO.receiveDataShow(System.Text.Encoding.Default.GetString(Form1.receiveTempData.ToArray()));//调用方法把接收到的SCPI指令信息显示到接收数据窗口
                    SCPIReceiveCheck(Form1.receiveTempData.ToArray());//进行SCPI指令的校验码校验
                   
                    Form1.receiveTempData.Clear();//清空存储SCPI指令的字节列表
                }

            }
        }
        //校验得到的SCPI指令是否正确
        public static void SCPIReceiveCheck(byte[] buf)
        {
            int sum = 0;
            for (int i = 0; i < buf.Length - 3; i++)
            {
                sum += buf[i];
            }
            byte low = (byte)(sum & 0xFF);
            low = (byte)(low | 0x80);
            if (low == buf[buf.Length - 3])
            {
                //UsbIO.sendToARM(Form1.successReceiveMes + SendDataHandle.SCPIStrSumChkGet(Form1.successReceiveMes) + Form1.end1 + Form1.end2);//发送指令接收成功信息
                SCPIReceiveAnalysis(Form1.receiveTempData.ToArray());//显示并解析收到的SCPI指令
            }
            else
            {
                UsbIO.sendToARM(Form1.errorCode+Form1.end1+Form1.end2);//返回指令校验错误信息
                Form1.dialogMessageShow("接收的指令校验结果出错");
            }

        }
        //显示并解析收到的SCPI指令
        public static void SCPIReceiveAnalysis(byte[] buf)
        {            
            if (judgeAbnormalCode(buf))
            {
                if(buf[1] == 0x00)
                {                   
                    Form1.dialogMessageShow("设备接收到的指令检验码出错！");
                }
                else
                {
                    //设备出故障，需要关掉测试
                    Form1.dialogMessageShow("设备出现故障，请点击复位键结束测试！"+System.Text.Encoding.Default.GetString(buf));//调用显示对话框函数，显示异常代码信息
                }
               
            }
            else
            {
                //接收到的不是异常代码指令，去掉校验码和结束码
                List<byte> bufTempList = new List<byte>();//用于暂存数据
                for (int i = 0; i < buf.Length ; i++)
                {                    
                    if (buf[i] == 0x0d)
                    {
                        bufTempList.Remove(buf[i - 1]);                        
                        break;
                    }
                    bufTempList.Add(buf[i]);
                }
                byte[] buf1 = bufTempList.ToArray();
                string str = System.Text.Encoding.Default.GetString(buf1);//把去掉校验码和结束码的SCPI指令转换成字符串
                SCPIReceiveGetData(str);
            }
          

        }

        //判断接收到的SCPI指令信息是不是异常代码信息，如果是返回true，如果不是异常代码信息则返回false
        public static bool judgeAbnormalCode(byte[] buf)
        {
            if ((buf[0] == 0x2B) && (buf[1]==0x00||buf[1]==0x01 || buf[1] == 0x02 || buf[1] == 0x03))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //判断得到的去掉校验码和结束码SCPI是什么指令，并进行相应的操作
        public static void SCPIReceiveGetData(string str)
        {
            Form1.SCPIsendSuccessFlag = true;//把下位机正确返回相应的信息标志置一，以便可以继续向下位机发送下一条指令
            if (str == Form1.successReceiveMes)
            {
                //接收的是正确信息的指令               
            }
            else
            {


                //确定是请求得到的结果参数 
                SCPIResultGetSave(str);
                Form1.SCPIGetDataCount++;//用来标志当前发送的是请求什么数据的指令
                if (Form1.SCPIGetDataCount > 4)
                {
                    Form1.SCPIGetDataCount = 0;
                }

            }

        }

        //根据得到的结果字符串，解析出相应的结果数据，然后赋值给定义的相应结果变量中，并把相应数据添加到画图列表中
        public static void SCPIResultGetSave(string str)
        {                                        
            string strTemp = "";
            int m = 0;
            switch (Form1.SCPIGetDataCount)
            {
                case 0:
                    foreach (char c in str)
                    {
                        if (c == '/')
                        {
                            if (m == 0)
                            {
                                Form1.voltageData = float.Parse(strTemp);//电压数据
                                try
                                {
                                    Form1.resultData.voltageData.Add(Form1.voltageData);//画图列表中添加数据
                                }                                
                                catch (Exception e)
                                {
                                    Form1.dialogMessageShow("数据添加画图列表发生异常，请检查！");
                                    String errorInfo = e.Message;
                                    Console.WriteLine(errorInfo);
                                }
                                strTemp = "";
                            }
                            if (m == 1)
                            {
                                Form1.leakElectricData = float.Parse(strTemp);//漏电流数据
                                try
                                {
                                    Form1.resultData.leakElectricData.Add(Form1.leakElectricData);//画图列表中添加数据
                                }
                                catch (Exception e)
                                {
                                    Form1.dialogMessageShow("数据添加画图列表发生异常，请检查！");
                                    String errorInfo = e.Message;
                                    Console.WriteLine(errorInfo);
                                }
                                
                                strTemp = "";
                            }
                            m++;
                        }
                        strTemp += c;
                    }
                    Form1.insulationRes = float.Parse(strTemp);//绝缘电阻
                    break;
                case 1:
                    Form1.electricData = float.Parse(str);//充放电流数据
                    try
                    {
                        Form1.resultData.electricData.Add(Form1.electricData);//画图列表中添加数据
                    }                  
                    catch (Exception e)
                    {
                        Form1.dialogMessageShow("数据添加画图列表发生异常，请检查！");
                        String errorInfo = e.Message;
                        Console.WriteLine(errorInfo);
                    }
                    break;
                case 2:
                    Form1.changingPowerData = float.Parse(str);//充电功率
                    break;
                case 3:
                    Form1.gearGain = str;//档位增益
                    break;
                case 4:
                    Form1.patternData = str;//工作模式数据
                    break;
                default:
                    Form1.dialogMessageShow("请求结果参数发生异常（结果解析出错，SCPIGetDataCount>4），请检查！");//调用显示对话框函数
                    break;
            }
        }




    }
}
