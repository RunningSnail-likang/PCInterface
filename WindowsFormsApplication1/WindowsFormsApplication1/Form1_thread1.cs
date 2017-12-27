using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        public static  Boolean isGather;
        public static Thread TaskGatherRealTime;



        #region  实时采集线程
        /// <summary>
        /// 
        /// 实时接收数据
        /// </summary>
        private  void GatherRealTime()
        {
            //
            isGather = true;
            Thread.Sleep(500);//0.5秒开启一次线程

            while (isGather)
            {
                try
                {
                    if (Form1.huatuFlag)
                    {
                        //刷新绘图
                        voltageGraph.Invoke(voltageUpdate, resultData.voltageData);
                        electricGraph.Invoke(electricUpdate, resultData.electricData);
                        leakElectricGraph.Invoke(leakElectricUpdate, resultData.leakElectricData);
                        Form1.huatuFlag = false;
                    }


                }
                catch (Exception e)
                {               
                    //使用委托
                    //groupBox2.Invoke(stopOperationDelegate);
                    MessageBox.Show("测试发生异常，请检查！");
                    String errorInfo = e.Message;
                    Console.WriteLine(errorInfo);
                }
            }
            ///判断是否需要退出线程
            if (isGather == false)
            {
                TaskGatherRealTime.Abort();
            }
        }
        #endregion



    }
}
