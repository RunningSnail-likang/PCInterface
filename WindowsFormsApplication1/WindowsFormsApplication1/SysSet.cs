using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class SysSet
    {

        //设置的参数变量
        public class SettingsStruct
        {
            public string testVoltage; //测试电压
            public string electricUpLimit; //充电电流上限
            public string powerUpLimit; //充电功率上限
            public string outputRes; //输出电阻
            public string dischargeElectric;//放电电流
            public string dischargePower;//放电功率
            //public string dischargePattern;//放电模式
            public string measurePattern;//测量模式
            public string voltageRiseSlope;//（高压源的最大输出电压）电压上升斜率
            public string voltageDropSlope;//（高压源的最大输出电压）电压下降斜率
            public string chargePattern;//充电模式
            //public string maxMeasureTime;//最大测量时间
            //public string minMeasureTime;//最小测量时间
            //public string sampling;//采样率

        }
      
        
    }




    
}
