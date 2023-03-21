using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class working : Form
    {
        Model model;
        int Simulation_time;
        public static int current_time = 0;
        public int profit = 0;
        public static int failed = 0;
        public static int successed = 0;
        public static int time_temp=0;
        public static bool discount = false;
        public static bool advertise = false;
        public static double dis = 0.0;
        public static bool fewer = true;
        float avg_len;



        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label l7s;
        private Label l9s;
        private Label l8s;
        private Label l4s;
        private Label l3s;
        private Label l6s;
        private Label l5s;
        private Label l2s;
        private Label l1s;
        private Label label20;
        private Label l7;
        private Label l9;
        private Label l8;
        private Label l4;
        private Label l3;
        private Label l6;
        private Label l5;
        private Label l2;
        private Label l1;
        public Timer timer1;
        private System.ComponentModel.IContainer components;
        private Button button1;
        private Button button2;
        private Label day;
        public static Label lab_hour;
        private Label minute;
        private Panel panel1;
        private Panel panel2;
        private Label label_pro;
        private Label l_pro;
        private Button button3;
        private Label label11;
        //public static  Label failed;
        public Label fail_label;
        public Label label_suc;
        private Label label13;
        private Label label12;
        private ComboBox comboBox1;
        private Button button5;
        private Button button4;
        private Button button6;
        private Label label14;
        private Panel panel3;
        private Label label15;
        private Button button8;
        private Button button7;
        private Label label16;
        private TextBox textBox1;
        private Label label17;
        private Label label18;
        public static Label label19;
        public static Label label21;
        private Label hour;
        private Label label22;
        private Label label31;
        private Label label33;
        private Label label23;
        private Label label24;
        private Label label25;
        List<Customer> customers = new List<Customer>();



        public working(Shop shop,int min_cust,int max_cust, int Sim_time)
        {
            InitializeComponent();
            model = new Model(shop,min_cust,max_cust, Sim_time);
        }
        private void Model_Load(object sender, EventArgs e)
        {

            Simulation_time = model.Simulation_time;
            //label28.Text = model.Shop.customers_fill92.Count().ToString();
            //T_Cus.Text = (model.shop.customers_fill92.Count() + model.shop.customers_fill94.Count() + model.shop.customers_fill97.Count()).ToString();
            // N_fail.Text = model.shop.failed.Count().ToString();
            //每天每周容量
           /* if (Int32.Parse(day.Text) == 0)
            {
                //label31.Text = model.shop.C_oil92.ToString();
                
            }
            else
            {
                //label31.Text = (model.shop.C_oil92 / Int32.Parse(day.Text)).ToString();
                
            }
           */
           //label34.Text = model.shop.C_oil92.ToString();
           
            //排队情况
            //}
            
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l7s = new System.Windows.Forms.Label();
            this.l9s = new System.Windows.Forms.Label();
            this.l8s = new System.Windows.Forms.Label();
            this.l4s = new System.Windows.Forms.Label();
            this.l3s = new System.Windows.Forms.Label();
            this.l6s = new System.Windows.Forms.Label();
            this.l5s = new System.Windows.Forms.Label();
            this.l2s = new System.Windows.Forms.Label();
            this.l1s = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_pro = new System.Windows.Forms.Label();
            this.l_pro = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.fail_label = new System.Windows.Forms.Label();
            this.label_suc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "cashbox 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "cashbox 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "cashbox 6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "cashbox 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "cashbox 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "cashbox 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "cashbox 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "cashbox 9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "cashbox 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status";
            // 
            // l7s
            // 
            this.l7s.AutoSize = true;
            this.l7s.Location = new System.Drawing.Point(149, 245);
            this.l7s.Name = "l7s";
            this.l7s.Size = new System.Drawing.Size(87, 15);
            this.l7s.TabIndex = 18;
            this.l7s.Text = "no working";
            // 
            // l9s
            // 
            this.l9s.AutoSize = true;
            this.l9s.Location = new System.Drawing.Point(149, 315);
            this.l9s.Name = "l9s";
            this.l9s.Size = new System.Drawing.Size(87, 15);
            this.l9s.TabIndex = 17;
            this.l9s.Text = "no working";
            // 
            // l8s
            // 
            this.l8s.AutoSize = true;
            this.l8s.Location = new System.Drawing.Point(149, 280);
            this.l8s.Name = "l8s";
            this.l8s.Size = new System.Drawing.Size(87, 15);
            this.l8s.TabIndex = 16;
            this.l8s.Text = "no working";
            // 
            // l4s
            // 
            this.l4s.AutoSize = true;
            this.l4s.Location = new System.Drawing.Point(149, 160);
            this.l4s.Name = "l4s";
            this.l4s.Size = new System.Drawing.Size(87, 15);
            this.l4s.TabIndex = 15;
            this.l4s.Text = "no working";
            // 
            // l3s
            // 
            this.l3s.AutoSize = true;
            this.l3s.Location = new System.Drawing.Point(149, 130);
            this.l3s.Name = "l3s";
            this.l3s.Size = new System.Drawing.Size(87, 15);
            this.l3s.TabIndex = 14;
            this.l3s.Text = "no working";
            // 
            // l6s
            // 
            this.l6s.AutoSize = true;
            this.l6s.Location = new System.Drawing.Point(149, 215);
            this.l6s.Name = "l6s";
            this.l6s.Size = new System.Drawing.Size(87, 15);
            this.l6s.TabIndex = 13;
            this.l6s.Text = "no working";
            // 
            // l5s
            // 
            this.l5s.AutoSize = true;
            this.l5s.Location = new System.Drawing.Point(149, 189);
            this.l5s.Name = "l5s";
            this.l5s.Size = new System.Drawing.Size(87, 15);
            this.l5s.TabIndex = 12;
            this.l5s.Text = "no working";
            // 
            // l2s
            // 
            this.l2s.AutoSize = true;
            this.l2s.Location = new System.Drawing.Point(149, 98);
            this.l2s.Name = "l2s";
            this.l2s.Size = new System.Drawing.Size(87, 15);
            this.l2s.TabIndex = 11;
            this.l2s.Text = "no working";
            // 
            // l1s
            // 
            this.l1s.AutoSize = true;
            this.l1s.Location = new System.Drawing.Point(149, 68);
            this.l1s.Name = "l1s";
            this.l1s.Size = new System.Drawing.Size(87, 15);
            this.l1s.TabIndex = 10;
            this.l1s.Text = "no working";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(266, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "Queue Length";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(308, 245);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(15, 15);
            this.l7.TabIndex = 28;
            this.l7.Text = "0";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Location = new System.Drawing.Point(308, 315);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(15, 15);
            this.l9.TabIndex = 27;
            this.l9.Text = "0";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(308, 280);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(15, 15);
            this.l8.TabIndex = 26;
            this.l8.Text = "0";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(308, 160);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(15, 15);
            this.l4.TabIndex = 25;
            this.l4.Text = "0";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(308, 130);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(15, 15);
            this.l3.TabIndex = 24;
            this.l3.Text = "0";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(308, 215);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(15, 15);
            this.l6.TabIndex = 23;
            this.l6.Text = "0";
            this.l6.Click += new System.EventHandler(this.label26_Click);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(308, 189);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(15, 15);
            this.l5.TabIndex = 22;
            this.l5.Text = "0";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(308, 98);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(15, 15);
            this.l2.TabIndex = 21;
            this.l2.Text = "0";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(308, 68);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(15, 15);
            this.l1.TabIndex = 20;
            this.l1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 46);
            this.button2.TabIndex = 30;
            this.button2.Text = "start/continue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.day.Location = new System.Drawing.Point(9, 14);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(28, 30);
            this.day.TabIndex = 31;
            this.day.Text = "0";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minute.Location = new System.Drawing.Point(212, 14);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(28, 30);
            this.minute.TabIndex = 36;
            this.minute.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.hour);
            this.panel1.Controls.Add(this.minute);
            this.panel1.Controls.Add(this.day);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(442, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 85);
            this.panel1.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(241, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 24);
            this.label25.TabIndex = 57;
            this.label25.Text = "minutes";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(14, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(279, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "Late night: fewer customers";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hour.Location = new System.Drawing.Point(95, 14);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(28, 30);
            this.hour.TabIndex = 56;
            this.hour.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(43, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 30);
            this.label31.TabIndex = 32;
            this.label31.Text = "day";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(129, 14);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 30);
            this.label33.TabIndex = 34;
            this.label33.Text = "hours";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l7);
            this.panel2.Controls.Add(this.l9);
            this.panel2.Controls.Add(this.l8);
            this.panel2.Controls.Add(this.l4);
            this.panel2.Controls.Add(this.l3);
            this.panel2.Controls.Add(this.l6);
            this.panel2.Controls.Add(this.l5);
            this.panel2.Controls.Add(this.l2);
            this.panel2.Controls.Add(this.l1);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.l7s);
            this.panel2.Controls.Add(this.l9s);
            this.panel2.Controls.Add(this.l8s);
            this.panel2.Controls.Add(this.l4s);
            this.panel2.Controls.Add(this.l3s);
            this.panel2.Controls.Add(this.l6s);
            this.panel2.Controls.Add(this.l5s);
            this.panel2.Controls.Add(this.l2s);
            this.panel2.Controls.Add(this.l1s);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 378);
            this.panel2.TabIndex = 38;
            // 
            // label_pro
            // 
            this.label_pro.AutoSize = true;
            this.label_pro.Location = new System.Drawing.Point(812, 91);
            this.label_pro.Name = "label_pro";
            this.label_pro.Size = new System.Drawing.Size(55, 15);
            this.label_pro.TabIndex = 39;
            this.label_pro.Text = "profit";
            // 
            // l_pro
            // 
            this.l_pro.AutoSize = true;
            this.l_pro.Location = new System.Drawing.Point(971, 91);
            this.l_pro.Name = "l_pro";
            this.l_pro.Size = new System.Drawing.Size(15, 15);
            this.l_pro.TabIndex = 40;
            this.l_pro.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 65);
            this.button3.TabIndex = 41;
            this.button3.Text = "Advertise for 24 hours\r\n(-7000p/24h)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(812, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Failed purchase";
            // 
            // fail_label
            // 
            this.fail_label.AutoSize = true;
            this.fail_label.Location = new System.Drawing.Point(971, 19);
            this.fail_label.Name = "fail_label";
            this.fail_label.Size = new System.Drawing.Size(15, 15);
            this.fail_label.TabIndex = 44;
            this.fail_label.Text = "0";
            // 
            // label_suc
            // 
            this.label_suc.AutoSize = true;
            this.label_suc.Location = new System.Drawing.Point(971, 56);
            this.label_suc.Name = "label_suc";
            this.label_suc.Size = new System.Drawing.Size(15, 15);
            this.label_suc.TabIndex = 46;
            this.label_suc.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(812, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 15);
            this.label13.TabIndex = 45;
            this.label13.Text = "successed purchase";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "speed simulation";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10min",
            "1h",
            "24h",
            "7d"});
            this.comboBox1.Location = new System.Drawing.Point(613, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(798, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 46);
            this.button5.TabIndex = 51;
            this.button5.Text = "exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Location = new System.Drawing.Point(431, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 46);
            this.button4.TabIndex = 52;
            this.button4.Text = "reboot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(580, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 46);
            this.button6.TabIndex = 53;
            this.button6.Text = "complete simulation";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 15);
            this.label14.TabIndex = 54;
            this.label14.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(431, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 248);
            this.panel3.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(273, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 15);
            this.label18.TabIndex = 61;
            this.label18.Text = "min";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(286, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 15);
            this.label17.TabIndex = 60;
            this.label17.Text = "%";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 50);
            this.button8.TabIndex = 59;
            this.button8.Text = "end discount";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 50);
            this.button7.TabIndex = 58;
            this.button7.Text = "start discount";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 57;
            this.label16.Text = "discount ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 55;
            this.label15.Text = "time left";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 188);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 25);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "0 ";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(812, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(191, 15);
            this.label23.TabIndex = 56;
            this.label23.Text = "average length of queue";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(971, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 15);
            this.label24.TabIndex = 57;
            this.label24.Text = "0";
            // 
            // working
            // 
            this.ClientSize = new System.Drawing.Size(1107, 556);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_suc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fail_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.l_pro);
            this.Controls.Add(this.label_pro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "working";
            this.Text = "Simulating a supermarket";
            this.Load += new System.EventHandler(this.working_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void working_Load(object sender, EventArgs e)
        {
           // listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //time_temp--;
            label14.Text = time_temp.ToString();
            if (time_temp == 0)
            {
                Form1.add_customer -= 0.1;
                
            }
            timer1.Start();
            //model.Tick();
            if (comboBox1.SelectedIndex == 0)
            {
                int deta;
                deta = model.Simulation_time * 24 * 60 - current_time;
                if ( deta< 10)
                {
                    for (int i = 0; i < deta; i++)
                    {
                        //current_time ++;
                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();
                        
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        deta = model.Simulation_time * 24 * 60 - current_time;

                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();//current_time ++;

                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int deta;
                deta = model.Simulation_time * 24 * 60 - current_time;
                if (deta < 60)
                {
                    for (int i = 0; i < deta; i++)
                    {
                        //current_time ++;
                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            //DialogResult result = MessageBox.Show(MessageBoxButtons.OK);
                            break;
                        }
                            
                        model.Tick();

                    }
                }
                else
                {
                    for (int i = 0; i < 60; i++)
                    {
                        deta = model.Simulation_time * 24 * 60 - current_time;

                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();//current_time ++;

                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int deta;
                deta = model.Simulation_time * 24 * 60 - current_time;
                if (deta < 1440)
                {
                    for (int i = 0; i < deta; i++)
                    {
                        //current_time ++;
                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();

                    }
                }
                else
                {
                    for (int i = 0; i < 1440; i++)
                    {
                        deta = model.Simulation_time * 24 * 60 - current_time;

                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();//current_time ++;

                    }
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                int deta;
                deta = model.Simulation_time * 24 * 60 - current_time;
                if (deta < 10080)
                {
                    for (int i = 0; i < deta; i++)
                    {
                        //current_time ++;
                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();

                    }
                }
                else
                {
                    for (int i = 0; i < 10080; i++)
                    {
                        deta = model.Simulation_time * 24 * 60 - current_time;

                        if (current_time >= model.Simulation_time * 24 * 60)
                        {
                            MessageBox.Show("simulation complete");
                            break;
                        }
                        model.Tick();//current_time ++;

                    }
                }
            }
            //model.Tick();
            current_time = model.currentTime;
            fail_label.Text = failed.ToString();
            label_suc.Text = successed.ToString();
            if (current_time >= model.Simulation_time * 24 * 60)
            {
                timer1.Stop();
                
                MessageBox.Show("simulation complete");
                   
                
            }
            if (current_time / 60 != 0)
            {
                day.Text = ((current_time / 60) / 24).ToString();
                hour.Text = ((current_time / 60) % 24).ToString();
                if (Int32.Parse(hour.Text) < 7&& Int32.Parse(hour.Text)>=0)
                {
                    fewer = true;
                    label22.Text = "Late night: fewer customers";
                }
                else 
                {
                    fewer = false;
                    label22.Text = "daytime: normal business hours";
                }
                minute.Text = (current_time % 60).ToString();
                //day.Text = "2";
               
            }
            else
            {
                minute.Text = current_time.ToString();
            }
            l_pro.Text = model.shop_m.Profit().ToString("f1")+" rubles";










            if (Form1.cashBoxCount == 1)
            {
                l1s.Text="working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                avg_len = model.shop_m.cashboxes[0].queue.Count() / 1;
            }
            if (Form1.cashBoxCount == 2)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count()+ model.shop_m.cashboxes[1].queue.Count()) / 2;
            }
            if (Form1.cashBoxCount == 3)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count()) / 3;
            }
            if (Form1.cashBoxCount == 4)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count()+ model.shop_m.cashboxes[3].queue.Count()) / 4;
            }
            if (Form1.cashBoxCount == 5)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                l5s.Text = "working";
                l5.Text = model.shop_m.cashboxes[4].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count() + model.shop_m.cashboxes[3].queue.Count()+ model.shop_m.cashboxes[4].queue.Count()) / 5;
            }
            if (Form1.cashBoxCount == 6)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                l5s.Text = "working";
                l5.Text = model.shop_m.cashboxes[4].queue.Count().ToString();
                l6s.Text = "working";
                l6.Text = model.shop_m.cashboxes[5].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count() + model.shop_m.cashboxes[3].queue.Count() + model.shop_m.cashboxes[4].queue.Count()+ model.shop_m.cashboxes[5].queue.Count()) / 6;
            }
            if (Form1.cashBoxCount == 7)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                l5s.Text = "working";
                l5.Text = model.shop_m.cashboxes[4].queue.Count().ToString();
                l6s.Text = "working";
                l6.Text = model.shop_m.cashboxes[5].queue.Count().ToString();
                l7s.Text = "working";
                l7.Text = model.shop_m.cashboxes[6].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count() + model.shop_m.cashboxes[3].queue.Count() + model.shop_m.cashboxes[4].queue.Count() + model.shop_m.cashboxes[5].queue.Count()+ model.shop_m.cashboxes[6].queue.Count()) / 7;
            }
            if (Form1.cashBoxCount == 8)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                l5s.Text = "working";
                l5.Text = model.shop_m.cashboxes[4].queue.Count().ToString();
                l6s.Text = "working";
                l6.Text = model.shop_m.cashboxes[5].queue.Count().ToString();
                l7s.Text = "working";
                l7.Text = model.shop_m.cashboxes[6].queue.Count().ToString();
                l8s.Text = "working";
                l8.Text = model.shop_m.cashboxes[7].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count() + model.shop_m.cashboxes[3].queue.Count() + model.shop_m.cashboxes[4].queue.Count() + model.shop_m.cashboxes[5].queue.Count() + model.shop_m.cashboxes[6].queue.Count()+ model.shop_m.cashboxes[7].queue.Count()) / 8;
            }
            if (Form1.cashBoxCount == 9)
            {
                l1s.Text = "working";
                l1.Text = model.shop_m.cashboxes[0].queue.Count().ToString();
                l2s.Text = "working";
                l2.Text = model.shop_m.cashboxes[1].queue.Count().ToString();
                l3s.Text = "working";
                l3.Text = model.shop_m.cashboxes[2].queue.Count().ToString();
                l4s.Text = "working";
                l4.Text = model.shop_m.cashboxes[3].queue.Count().ToString();
                l5s.Text = "working";
                l5.Text = model.shop_m.cashboxes[4].queue.Count().ToString();
                l6s.Text = "working";
                l6.Text = model.shop_m.cashboxes[5].queue.Count().ToString();
                l7s.Text = "working";
                l7.Text = model.shop_m.cashboxes[6].queue.Count().ToString();
                l8s.Text = "working";
                l8.Text = model.shop_m.cashboxes[7].queue.Count().ToString();
                l9s.Text = "working";
                l9.Text = model.shop_m.cashboxes[8].queue.Count().ToString();
                avg_len = (model.shop_m.cashboxes[0].queue.Count() + model.shop_m.cashboxes[1].queue.Count() + model.shop_m.cashboxes[2].queue.Count() + model.shop_m.cashboxes[3].queue.Count() + model.shop_m.cashboxes[4].queue.Count() + model.shop_m.cashboxes[5].queue.Count() + model.shop_m.cashboxes[6].queue.Count() + model.shop_m.cashboxes[7].queue.Count()+ model.shop_m.cashboxes[8].queue.Count()) / 9;
            }
            label24.Text = avg_len.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current_time < model.Simulation_time * 24 * 60)
                timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            advertise = true;
            Form1.add_customer += 0.1;
            time_temp += 1440;
            Shop.profit -= 7000;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current_time < model.Simulation_time * 24 * 60)
                timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e) 
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            discount = true;
            Form1.add_customer += 0.005* Int32.Parse(textBox1.Text); 
            dis= 0.005 * Int32.Parse(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            discount = false;
            if (advertise) 
                Form1.add_customer = 0.1;
            else 
                Form1.add_customer = 0.0;
            textBox1.Text = "0";
            dis = 0;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
    
}
