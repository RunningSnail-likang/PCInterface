using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SendDataHandle
    {

        //发送SCPI模块联机顺序指令到下位机中
        public static bool SCPIConnect()
        {
            int sendCount = 0;//每条指令最多发送的次数变量，如果次数超过则报错
            UsbIO.sendToARM(Form1.successReceiveMes + SCPIStrSumChkGet(Form1.successReceiveMes) + Form1.end1 + Form1.end2);
            foreach (string s in Form1.SCPIConnect)
            {
                UsbIO.sendToARM(s+SCPIStrSumChkGet(s)+Form1.end1+Form1.end2);
                Form1.Delay(100);//先延时100ms，然后判断是否返回接收成功的信息，如果返回继续发送下一条，没返回则，每隔一段时间发送一次相同的请求，五次后还没返回正确信息则报错
                while (!Form1.SCPIsendSuccessFlag)
                {
                    sendCount++;
                    Form1.Delay(900);//延时900ms
                    if (sendCount < 5)
                    {
                        UsbIO.sendToARM(s + SCPIStrSumChkGet(s) + Form1.end1 + Form1.end2);
                    }
                    else
                    {
                        break;
                    }

                }
                if (sendCount < 5)
                {
                    sendCount = 0;
                }
                else
                {                
                    Form1.dialogMessageShow("SCPI联机指令发送失败");
                    break;
                }
                Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            }
            Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            if (sendCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //发送退出远控状态的SCPI指令给下位机，实现断开连接的操作
        public static void SCPICDisconnect()
        {
            int sendCount = 0;//每条指令最多发送的次数变量，如果次数超过则报错
            UsbIO.sendToARM(Form1.SCPIDisconnect + SCPIStrSumChkGet(Form1.SCPIDisconnect) + Form1.end1 + Form1.end2);
            Form1.Delay(100);//先延时100ms，然后判断是否返回接收成功的信息，如果返回继续发送下一条，没返回则，每隔一段时间发送一次相同的请求，五次后还没返回正确信息则报错
            while (!Form1.SCPIsendSuccessFlag)
            {
                sendCount++;
                Form1.Delay(900);//延时900ms
                if (sendCount < 5)
                {
                    UsbIO.sendToARM(Form1.SCPIDisconnect + SCPIStrSumChkGet(Form1.SCPIDisconnect) + Form1.end1 + Form1.end2);
                }
                else
                {
                    break;
                }
                Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            }
            Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            if (sendCount < 5)
            {
                sendCount = 0;
                Form1.dialogMessageShow("退出远控状态成功！");
            }
            else
            {
                Form1.dialogMessageShow("退出远控状态失败，请检查设备！");
            }
        }

        //复位函数
        public static void reset()
        {
            int sendCount = 0;//每条指令最多发送的次数变量，如果次数超过则报错
            UsbIO.sendToARM(Form1.SCPIReset + SCPIStrSumChkGet(Form1.SCPIReset) + Form1.end1 + Form1.end2);
            Form1.Delay(100);//先延时100ms，然后判断是否返回接收成功的信息，如果返回继续发送下一条，没返回则，每隔一段时间发送一次相同的请求，五次后还没返回正确信息则报错
            while (!Form1.SCPIsendSuccessFlag)
            {
                sendCount++;
                Form1.Delay(900);//延时900ms
                if (sendCount < 5)
                {
                    UsbIO.sendToARM(Form1.SCPIReset + SCPIStrSumChkGet(Form1.SCPIReset) + Form1.end1 + Form1.end2);
                }
                else
                {
                    break;
                }
                Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            }
            Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            if (sendCount < 5)
            {
                sendCount = 0;
                Form1.dialogMessageShow("复位成功！");
            }
            else
            {
                Form1.dialogMessageShow("设备复位失败，请检查设备！");
            }
        }


        //发送设置参数到下位机
        public static void SendToCMDMachine(SysSet.SettingsStruct setData)
        {
            string[] packData = PackageData(setData);//把设置参数封装成SCPI指令
            //需要添加参数发送成功标志，通过条件判断，读取返回的设置成功与否的标志
            int sendCount = 0;//每条指令最多发送的次数变量，如果次数超过则报错
            bool setDataDownloadSuccessFlag = true;//设置参数全部下载到下位机的成功标志
            foreach (string s in packData)
            {
                UsbIO.sendToARM(s);
                Form1.Delay(100);//先延时100ms，然后判断是否返回接收成功的信息，如果返回继续发送下一条，没返回则，每隔一段时间发送一次相同的请求，五次后还没返回正确信息则报错
                while (!Form1.SCPIsendSuccessFlag)
                {
                    sendCount++;
                    Form1.Delay(900);//延时900ms
                    if (sendCount < 5)
                    {
                        UsbIO.sendToARM(s);
                    }
                    else
                    {
                        setDataDownloadSuccessFlag = false;
                        break;
                    }

                }
                if (sendCount < 5)
                {
                    sendCount = 0;
                }
                else
                {
                    break;
                }
                Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            }

            Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            if (setDataDownloadSuccessFlag)
            {
                Form1.dialogMessageShow("参数下载成功！");//弹出提示对话框
                Form1.setDataDownloadSuccessFlag = true;//参数下载成功的标志
            }
            else
            {
                Form1.dialogMessageShow("参数下载失败,请检查设备并重新下载！");//弹出提示对话框
            }


        }



        //根据SCPI通信协议把设置参数setData进行封装，并返回封装后的字符串数组
        public static string[] PackageData(SysSet.SettingsStruct setData)
        {
            //对设置的参数根据SCPI协议进行封装
            string[] array = new string[10];
            try
            {
                array[0] = Form1.SCPISetPre[0] + setData.testVoltage + "V";
                array[1] = Form1.SCPISetPre[1] + setData.electricUpLimit + "mA";
                array[2] = Form1.SCPISetPre[2] + setData.powerUpLimit + "W";
                array[3] = Form1.SCPISetPre[3] + setData.outputRes;
                array[4] = Form1.SCPISetPre[4] + setData.dischargeElectric + "mA";
                array[5] = Form1.SCPISetPre[5] + setData.dischargePower + "W";
                array[6] = Form1.SCPISetPre[6] + setData.measurePattern;
                array[7] = Form1.SCPISetPre[7] + setData.voltageRiseSlope + "V/s";
                array[8] = Form1.SCPISetPre[8] + setData.voltageDropSlope + "V/s";
                array[9] = Form1.SCPISetPre[9] + setData.chargePattern;

            }
            catch (Exception e)
            {
                Form1.dialogMessageShow("读取设置参数发生异常，请检查！");//弹出提示对话框
                String errorInfo = e.Message;
                Console.WriteLine(errorInfo);
            }
            string[] arrayReturn = PackageDataOver(array);
            return arrayReturn;//返回封装后的字符串或字符串数组
        }

        //把校验码和结束码加入指令中去
        public static string[] PackageDataOver(string[] str)
        {
            string[] array = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {

                array[i] = str[i] + SCPIStrSumChkGet(str[i]) + Form1.end1 + Form1.end2;
            }

            return array;//返回封装后的字符串或字符串数组
        }

        //计算给定字符串的所有字符ASCII码值之和（即校验码），并把和转换成字符串返回
        public static char SCPIStrSumChkGet(string str)
        {
            int sum = 0;
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str.Trim());//Trim()函数用来去除字符串首尾处的空格，得到字符串对应的ASCII的byte数组
            for (int i = 0; i < array.Length; i++)
            {
                int asciicode = array[i];
                sum += asciicode;
            }
            byte low = (byte)(sum & 0xFF);
            low = (byte)(low | 0x80);
            char ASCIIstr = (char)low;
            return ASCIIstr;

        }
        //发送请求结果数据的函数
        public static void sendGet(string[] str)
        {
            bool setDataDownloadSuccessFlag = true;//请求结果的SCPI指令全部下载到下位机的成功标志
            int sendCount = 0;
            foreach (string s in str)
            {
                UsbIO.sendToARM(s);
                Form1.Delay(100);//先延时100ms，然后判断是否返回接收成功的信息，如果返回继续发送下一条，没返回则，每隔一段时间发送一次相同的请求，五次后还没返回正确信息则报错
                while (!Form1.SCPIsendSuccessFlag)
                {
                    sendCount++;
                    Form1.Delay(900);//延时900ms
                    if (sendCount < 5)
                    {
                        UsbIO.sendToARM(s);
                    }
                    else
                    {
                        //五次连续发送该条指令都没有返回接收成功的返回信息，则参数请求失败
                        setDataDownloadSuccessFlag = false;
                        break;
                    }

                }
                if (sendCount<5)
                {
                    sendCount = 0;                                    
                }
                else
                {
                    break;
                }
                Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            }
            Form1.SCPIsendSuccessFlag = false;//返回该指令的接收成功信息后再把标志置为false
            if (!setDataDownloadSuccessFlag)
            {
                Form1.dialogMessageShow("结果参数请求失败，测试已停止，请检查设备！");//弹出提示对话框  
                //是否关闭测试？
                Form1.closeTest();//调用关闭测试的函数
            }
               
        }
    }
}
