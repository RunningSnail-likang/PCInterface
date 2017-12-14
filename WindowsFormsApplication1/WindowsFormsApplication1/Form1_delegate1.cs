using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {

        #region 委托初始化
        private void InitDelegate()
        {
            voltageUpdate = new VoltageUpdate(Voltage_Update);
            electricUpdate = new ElectricUpdate(Electric_Update);
            leakElectricUpdate = new LeakElectricUpdate(LeakElectric_Update);
        }

        #endregion

        

        #region 电压波形更新
        //电压更新
        private delegate void VoltageUpdate(List<float> voltageList);
        private VoltageUpdate voltageUpdate;
        private void Voltage_Update(List<float> voltageList)
        {
            
            if (voltageList == null||voltageList.Count()==0)
            {
                
            }
            else {
                int len = voltageList.Count();
                Double[] xdata = new Double[len];
                Double[] voltage = new Double[len];

                int m = 0;
                foreach (float a in voltageList)
                {
                    voltage[m] = a;
                    xdata[m] = m + xUnitTime;//趋势图中每个点横坐标之间的间隔是设置的请求时间
                    m++;
                }
                PointPairList ppl = new PointPairList(xdata, voltage);


                GraphPane voltagePane = voltageGraph.GraphPane;
                voltagePane.CurveList.Clear();
                LineItem voltageCurve = voltagePane.AddCurve("电压波形", ppl, Color.Green, SymbolType.Square);
                voltageCurve.Line.Width = 1.5f;
                voltageCurve.Line.Style = DashStyle.Solid;
                voltageCurve.Symbol.Size = 1.0f;

                voltageGraph.AxisChange();
                voltageGraph.Refresh();

            }


        }
        #endregion

        
        #region 电流波形更新
        private delegate void ElectricUpdate(List<float> electricList);
        private ElectricUpdate electricUpdate;
        private void Electric_Update(List<float> electricList)
        {
            if (electricList == null||electricList.Count()==0)
            {

            }
            else
            {
                int len = electricList.Count;
                Double[] xdata = new Double[len];
                Double[] electric = new Double[len];

                int m = 0;
                foreach (float a in electricList)
                {
                    electric[m] = a;
                    xdata[m] = m + xUnitTime;//趋势图中每个点横坐标之间的间隔是设置的请求时间
                    m++;
                }
                PointPairList ppl = new PointPairList(xdata, electric);

                GraphPane electricPane = electricGraph.GraphPane;
                electricPane.CurveList.Clear();
                LineItem electricCurve = electricPane.AddCurve("电流波形", ppl, Color.Green, SymbolType.Square);

                electricCurve.Line.Width = 1.5f;
                electricCurve.Line.Style = DashStyle.Solid;
                electricCurve.Symbol.Size = 1.0f;

                electricGraph.AxisChange();
                electricGraph.Refresh();
            }
            

            
        }


        #endregion

        #region 漏电流波形更新
        private delegate void LeakElectricUpdate(List<float> leakeElectricList);
        private LeakElectricUpdate leakElectricUpdate;
        private void LeakElectric_Update(List<float> leakeElectricList)
        {
            if (leakeElectricList == null||leakeElectricList.Count()==0)
            {

            }
            else
            {
                int len = leakeElectricList.Count;
                Double[] xdata = new Double[len];
                Double[] leakeElectric = new Double[len];

                int m = 0;
                foreach (float a in leakeElectricList)
                {
                    leakeElectric[m] = a;
                    xdata[m] = m + xUnitTime;//趋势图中每个点横坐标之间的间隔是设置的请求时间
                    m++;
                }
                PointPairList ppl = new PointPairList(xdata, leakeElectric);

                GraphPane leakElectricPane = leakElectricGraph.GraphPane;
                leakElectricPane.CurveList.Clear();
                LineItem leakElectricCurve = leakElectricPane.AddCurve("漏电流波形", ppl, Color.Green, SymbolType.Square);

                leakElectricCurve.Line.Width = 1.5f;
                leakElectricCurve.Line.Style = DashStyle.Solid;
                leakElectricCurve.Symbol.Size = 1.0f;

                leakElectricGraph.AxisChange();
                leakElectricGraph.Refresh();
            }
                      
        }



        #endregion





    }
}

