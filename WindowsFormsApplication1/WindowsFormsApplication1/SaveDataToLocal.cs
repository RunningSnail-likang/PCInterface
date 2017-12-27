using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SaveDataToLocal
    {
        //创建指定目录和存储数据的文件的函数
        public static void createPathFile()
        {
            //创建指定的目录，如果存在不会重新创建，如果不存在会自动创建路径中各级不存在的目录
            string activeDir = @"D:\mySave";
            string newPath = System.IO.Path.Combine(activeDir, "myData");
            System.IO.Directory.CreateDirectory(newPath);

            //创建一个空白文件，通过Create方法创建文件，会覆盖同名的现有文件。创建文件时，该文件所在路径的目录必须存在，否则报错。
            //创建存储输出电压值的txt文件            
            string fileNameOne = "outputVoltageData.txt";
            string filePathOne = System.IO.Path.Combine(newPath, fileNameOne);
            System.IO.File.Create(filePathOne);
            //创建存储电流值的txt文件
            string fileNameTwo = "electricData.txt";
            string filePathTwo = System.IO.Path.Combine(newPath, fileNameTwo);
            System.IO.File.Create(filePathTwo);
            //创建存储漏电流值的txt文件
            string fileNameThree = "leakElectricData.txt";
            string filePathThree = System.IO.Path.Combine(newPath, fileNameThree);
            System.IO.File.Create(filePathThree);
            //创建存储测量电压值的txt文件            
            string fileNameFour = "measureVoltageData.txt";
            string filePathFour = System.IO.Path.Combine(newPath, fileNameFour);
            System.IO.File.Create(filePathFour);
        }



        //把相应的数据以追加的方式写入到对应的txt文件中去
        public static void writeFile()
        {
            writeOutputVoltageData();//把输出电压数据写入相应的文件中去
            writeElectricData();//把电流数据写入相应的文件中去
            writeLeakElectricData();//把漏电流数据写入相应的文件中去
            writeMeasuretVoltageData();//把测量电压数据写入相应的文件中去
        }



        //以追加的方式把输出电压数据保存到本地D:\\mySave\\myData\\outputVoltageData.txt中去
        public static void writeOutputVoltageData()
        {
            FileStream fs = null;
            string filePath = "D:\\mySave\\myData\\outputVoltageData.txt";
            Encoding encoder = Encoding.UTF8;
            try
            {
                //把float类型的电压数据转换成byte类型存入电脑（从画图列表中依次读取）
                //byte[] b = BitConverter.GetBytes(Form1.resultData.voltageData[Form1.resultData.voltageData.Count-1]);
                string strTemp = Convert.ToString(Form1.resultData.voltageData[Form1.resultData.voltageData.Count - 1]);
                byte[] b = System.Text.Encoding.Default.GetBytes(strTemp);
                byte[] bTemp = new byte[b.Length + 1];
                b.CopyTo(bTemp, 0);
                //bTemp[b.Length] = 0x56;//加上单位V
                bTemp[b.Length] = 0x2C;//加上一个数据结束的标志：逗号（,）

                
                fs = File.OpenWrite(filePath);
                //设定书写的开始位置为文件的末尾  
                fs.Position = fs.Length;
                //将待写入内容追加到文件末尾  
                fs.Write(bTemp, 0, bTemp.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
            Console.ReadLine();
        }




        //以追加的方式把测量电压数据保存到本地D:\\mySave\\myData\\measureVoltageData.txt中去
        public static void writeMeasuretVoltageData()
        {
            FileStream fs = null;
            string filePath = "D:\\mySave\\myData\\measureVoltageData.txt";
            Encoding encoder = Encoding.UTF8;
            try
            {
            
                byte[] b = System.Text.Encoding.Default.GetBytes(Form1.measureVoltageDataTemp);//把暂存的没有单位的测量电压转换成字节型数组
                byte[] bTemp = new byte[b.Length + 1];
                b.CopyTo(bTemp, 0);
                //bTemp[b.Length] = 0x56;//加上单位V
                bTemp[b.Length] = 0x2C;//加上一个数据结束的标志：逗号（,）


                fs = File.OpenWrite(filePath);
                //设定书写的开始位置为文件的末尾  
                fs.Position = fs.Length;
                //将待写入内容追加到文件末尾  
                fs.Write(bTemp, 0, bTemp.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
            Console.ReadLine();
        }







        //以追加的方式把电流数据保存到本地D:\\mySave\\myData\\electricData.txt中去
        public static void writeElectricData()
        {
            FileStream fs = null;
            string filePath = "D:\\mySave\\myData\\electricData.txt";
            Encoding encoder = Encoding.UTF8;
            try
            {
                //把float类型的电流数据转换成byte类型存入电脑（从画图列表中依次读取）
                //byte[] b = BitConverter.GetBytes(Form1.resultData.electricData[Form1.resultData.electricData.Count - 1]);

                string strTemp = Convert.ToString(Form1.resultData.electricData[Form1.resultData.electricData.Count - 1]);
                byte[] b = System.Text.Encoding.Default.GetBytes(strTemp);

                byte[] bTemp = new byte[b.Length + 1];
                b.CopyTo(bTemp, 0);

                //bTemp[b.Length ] = 0x6D;//加上单位m
                //bTemp[b.Length + 1] = 0x41;//加上单位A
                bTemp[b.Length] = 0x2C;//加上一个数据结束的标志：逗号（,）


                fs = File.OpenWrite(filePath);
                //设定书写的开始位置为文件的末尾  
                fs.Position = fs.Length;
                //将待写入内容追加到文件末尾  
                fs.Write(bTemp, 0, bTemp.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
            Console.ReadLine();
        }

        //以追加的方式把漏电流数据保存到本地D:\\mySave\\myData\\leakElectricData.txt中去
        public static void writeLeakElectricData()
        {
            FileStream fs = null;
            string filePath = "D:\\mySave\\myData\\leakElectricData.txt";
            Encoding encoder = Encoding.UTF8;
            try
            {
                //把float类型的漏电流数据转换成byte类型存入电脑（从画图列表中依次读取）
                string strTemp = Convert.ToString(Form1.resultData.leakElectricData[Form1.resultData.leakElectricData.Count - 1]);
                //byte[] b = BitConverter.GetBytes(Form1.resultData.leakElectricData[Form1.resultData.leakElectricData.Count - 1]);

                byte[] b = System.Text.Encoding.Default.GetBytes(strTemp);
                byte[] bTemp = new byte[b.Length + 1];
                b.CopyTo(bTemp, 0);

                //bTemp[b.Length] = 0x6E;//加上单位n
                //bTemp[b.Length + 1] = 0x41;//加上单位A
                bTemp[b.Length] = 0x2C;//加上一个数据结束的标志：逗号（,）



                fs = File.OpenWrite(filePath);
                //设定书写的开始位置为文件的末尾  
                fs.Position = fs.Length;
                //将待写入内容追加到文件末尾  
                fs.Write(bTemp, 0, bTemp.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
            Console.ReadLine();
        }
    }
}
