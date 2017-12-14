namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gGain = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.leakElectricGraph = new ZedGraph.ZedGraphControl();
            this.electricGraph = new ZedGraph.ZedGraphControl();
            this.voltageGraph = new ZedGraph.ZedGraphControl();
            this.changingPower = new System.Windows.Forms.TextBox();
            this.pattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leakElectric = new System.Windows.Forms.TextBox();
            this.electric = new System.Windows.Forms.TextBox();
            this.voltage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PortNums = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeNow = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gGain);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.Res);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.leakElectricGraph);
            this.groupBox1.Controls.Add(this.electricGraph);
            this.groupBox1.Controls.Add(this.voltageGraph);
            this.groupBox1.Controls.Add(this.changingPower);
            this.groupBox1.Controls.Add(this.pattern);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.leakElectric);
            this.groupBox1.Controls.Add(this.electric);
            this.groupBox1.Controls.Add(this.voltage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1646, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果显示";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gGain
            // 
            this.gGain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gGain.Location = new System.Drawing.Point(111, 242);
            this.gGain.Name = "gGain";
            this.gGain.ReadOnly = true;
            this.gGain.Size = new System.Drawing.Size(116, 23);
            this.gGain.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 14);
            this.label18.TabIndex = 20;
            this.label18.Text = "档位/增益：";
            // 
            // Res
            // 
            this.Res.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Res.Location = new System.Drawing.Point(111, 202);
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Size = new System.Drawing.Size(116, 23);
            this.Res.TabIndex = 19;
            this.Res.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 14);
            this.label17.TabIndex = 18;
            this.label17.Text = "绝缘电阻：";
            // 
            // leakElectricGraph
            // 
            this.leakElectricGraph.Location = new System.Drawing.Point(1192, 12);
            this.leakElectricGraph.Name = "leakElectricGraph";
            this.leakElectricGraph.ScrollGrace = 0D;
            this.leakElectricGraph.ScrollMaxX = 0D;
            this.leakElectricGraph.ScrollMaxY = 0D;
            this.leakElectricGraph.ScrollMaxY2 = 0D;
            this.leakElectricGraph.ScrollMinX = 0D;
            this.leakElectricGraph.ScrollMinY = 0D;
            this.leakElectricGraph.ScrollMinY2 = 0D;
            this.leakElectricGraph.Size = new System.Drawing.Size(424, 323);
            this.leakElectricGraph.TabIndex = 17;
            // 
            // electricGraph
            // 
            this.electricGraph.Location = new System.Drawing.Point(736, 12);
            this.electricGraph.Name = "electricGraph";
            this.electricGraph.ScrollGrace = 0D;
            this.electricGraph.ScrollMaxX = 0D;
            this.electricGraph.ScrollMaxY = 0D;
            this.electricGraph.ScrollMaxY2 = 0D;
            this.electricGraph.ScrollMinX = 0D;
            this.electricGraph.ScrollMinY = 0D;
            this.electricGraph.ScrollMinY2 = 0D;
            this.electricGraph.Size = new System.Drawing.Size(426, 323);
            this.electricGraph.TabIndex = 16;
            // 
            // voltageGraph
            // 
            this.voltageGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.voltageGraph.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.voltageGraph.Location = new System.Drawing.Point(287, 12);
            this.voltageGraph.Name = "voltageGraph";
            this.voltageGraph.ScrollGrace = 0D;
            this.voltageGraph.ScrollMaxX = 0D;
            this.voltageGraph.ScrollMaxY = 0D;
            this.voltageGraph.ScrollMaxY2 = 0D;
            this.voltageGraph.ScrollMinX = 0D;
            this.voltageGraph.ScrollMinY = 0D;
            this.voltageGraph.ScrollMinY2 = 0D;
            this.voltageGraph.Size = new System.Drawing.Size(427, 323);
            this.voltageGraph.TabIndex = 15;
            this.voltageGraph.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // changingPower
            // 
            this.changingPower.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changingPower.Location = new System.Drawing.Point(111, 161);
            this.changingPower.Name = "changingPower";
            this.changingPower.ReadOnly = true;
            this.changingPower.Size = new System.Drawing.Size(116, 23);
            this.changingPower.TabIndex = 13;
            this.changingPower.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pattern
            // 
            this.pattern.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pattern.Location = new System.Drawing.Point(111, 281);
            this.pattern.Name = "pattern";
            this.pattern.ReadOnly = true;
            this.pattern.Size = new System.Drawing.Size(116, 23);
            this.pattern.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "测试阶段：";
            // 
            // leakElectric
            // 
            this.leakElectric.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leakElectric.Location = new System.Drawing.Point(111, 121);
            this.leakElectric.Name = "leakElectric";
            this.leakElectric.ReadOnly = true;
            this.leakElectric.Size = new System.Drawing.Size(116, 23);
            this.leakElectric.TabIndex = 12;
            this.leakElectric.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // electric
            // 
            this.electric.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.electric.Location = new System.Drawing.Point(111, 81);
            this.electric.Name = "electric";
            this.electric.ReadOnly = true;
            this.electric.Size = new System.Drawing.Size(116, 23);
            this.electric.TabIndex = 10;
            // 
            // voltage
            // 
            this.voltage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.voltage.Location = new System.Drawing.Point(111, 42);
            this.voltage.Name = "voltage";
            this.voltage.ReadOnly = true;
            this.voltage.Size = new System.Drawing.Size(116, 23);
            this.voltage.TabIndex = 1;
            this.voltage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "充电功率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "漏电流：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "充放电流：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "电压：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(33, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(807, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "V/s";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(685, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 23);
            this.textBox4.TabIndex = 47;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(588, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 14);
            this.label22.TabIndex = 46;
            this.label22.Text = "电压降斜率：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(807, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 16);
            this.label19.TabIndex = 45;
            this.label19.Text = "V/s";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(685, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(588, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 14);
            this.label20.TabIndex = 43;
            this.label20.Text = "电压升斜率：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(520, 124);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 16);
            this.label29.TabIndex = 42;
            this.label29.Text = "W";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(520, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "mA";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(243, 125);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 16);
            this.label27.TabIndex = 27;
            this.label27.Text = "W";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(243, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 16);
            this.label26.TabIndex = 27;
            this.label26.Text = "mA";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(243, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 16);
            this.label25.TabIndex = 27;
            this.label25.Text = "V";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(685, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 22);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 22);
            this.comboBox1.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "测量模式：";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(398, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 23);
            this.textBox7.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "放电功率：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "放电电流：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "输出电阻：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(121, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 23);
            this.textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(121, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 23);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(121, 23);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 23);
            this.textBox10.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "充电功率上限：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "充电电流上限：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "测试电压：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.PortNums);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Location = new System.Drawing.Point(33, 587);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(881, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能按钮";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.Location = new System.Drawing.Point(701, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 48);
            this.button7.TabIndex = 47;
            this.button7.Text = "数据\r\n清空";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 43;
            // 
            // PortNums
            // 
            this.PortNums.FormattingEnabled = true;
            this.PortNums.Location = new System.Drawing.Point(111, 108);
            this.PortNums.Name = "PortNums";
            this.PortNums.Size = new System.Drawing.Size(116, 22);
            this.PortNums.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 14);
            this.label15.TabIndex = 45;
            this.label15.Text = "选择串口：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(466, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 16);
            this.label14.TabIndex = 43;
            this.label14.Text = "ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 43;
            this.label12.Text = "请求时间：";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Location = new System.Drawing.Point(590, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 48);
            this.button6.TabIndex = 11;
            this.button6.Text = "复位\r\n按钮";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Location = new System.Drawing.Point(246, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "参数\r\n下载";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Location = new System.Drawing.Point(469, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "结束\r\n测试";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(356, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "开始\r\n测试";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(45, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "打开\r\n连接";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(139, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "关闭\r\n连接";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox11.Location = new System.Drawing.Point(455, 14);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(130, 23);
            this.textBox11.TabIndex = 39;
            this.textBox11.Text = "   设备未连接";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.Location = new System.Drawing.Point(794, 14);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(130, 23);
            this.textBox13.TabIndex = 40;
            this.textBox13.Text = "   参数未下载";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox14.Location = new System.Drawing.Point(1160, 14);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(130, 23);
            this.textBox14.TabIndex = 41;
            this.textBox14.Text = "   测试未开始";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeNow
            // 
            this.timeNow.BackColor = System.Drawing.SystemColors.Menu;
            this.timeNow.Location = new System.Drawing.Point(129, 14);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(187, 23);
            this.timeNow.TabIndex = 42;
            this.timeNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 14);
            this.label16.TabIndex = 18;
            this.label16.Text = "当前时间：";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.receiveBox);
            this.groupBox4.Location = new System.Drawing.Point(940, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 321);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据接收";
            this.groupBox4.Enter += new System.EventHandler(this.数据接收_Enter);
            // 
            // receiveBox
            // 
            this.receiveBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveBox.Location = new System.Drawing.Point(22, 22);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ReadOnly = true;
            this.receiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveBox.Size = new System.Drawing.Size(315, 284);
            this.receiveBox.TabIndex = 43;
            this.receiveBox.TextChanged += new System.EventHandler(this.receiveBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sendBox);
            this.groupBox5.Location = new System.Drawing.Point(1321, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 321);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据发送";
            // 
            // sendBox
            // 
            this.sendBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendBox.Location = new System.Drawing.Point(24, 21);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ReadOnly = true;
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(315, 284);
            this.sendBox.TabIndex = 44;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(685, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 22);
            this.comboBox2.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(602, 143);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 14);
            this.label23.TabIndex = 49;
            this.label23.Text = "充电模式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 750);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.timeNow);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "CS9902绝缘电阻测试仪上位机界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox voltage;
        private System.Windows.Forms.TextBox changingPower;
        private System.Windows.Forms.TextBox leakElectric;
        private System.Windows.Forms.TextBox pattern;
        private System.Windows.Forms.TextBox electric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private ZedGraph.ZedGraphControl voltageGraph;
        private ZedGraph.ZedGraphControl leakElectricGraph;
        private ZedGraph.ZedGraphControl electricGraph;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox timeNow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox gGain;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox PortNums;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox receiveBox;
        public System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label23;
    }
}

