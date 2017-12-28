using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class ResultDisplay
    {
        //绘图的列表变量，用于刷新曲线图的列表
        public List<float> outputVoltageData=new List<float>();//电压数据
        public List<float> electricData = new List<float>();//电流数据
        public List<float> leakElectricData = new List<float>();//漏电流数据

        

        /*
        //结果显示变量
        public class ResultStruct
        {
            public float voltage; //电压
            public float electric; //电流
            public float leakElectric;//漏电流
            public float changingPower;//充电功率
            public float patternData;//工作模式数据
            public string pattern; //模式

        }
        */
    }
}
