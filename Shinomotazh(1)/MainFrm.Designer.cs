namespace Shinomotazh
{
    partial class MainFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.RentLbl = new System.Windows.Forms.Label();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.SpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DefaultChrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DefaultTmr = new System.Windows.Forms.Timer(this.components);
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.RentTB = new System.Windows.Forms.TextBox();
            this.StartMoneyTB = new System.Windows.Forms.TextBox();
            this.ReportTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_KomPlat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.tb_mounth = new System.Windows.Forms.TextBox();
            this.tb_strax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultChrt)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StartBtn.Location = new System.Drawing.Point(28, 746);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(125, 31);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Запустить";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StopBtn.Location = new System.Drawing.Point(975, 746);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(125, 31);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Пауза";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.Location = new System.Drawing.Point(23, 15);
            this.SalaryLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(219, 18);
            this.SalaryLbl.TabIndex = 2;
            this.SalaryLbl.Text = "Зарплаты рабочим (в мес)";
            this.SalaryLbl.Click += new System.EventHandler(this.SalaryLbl_Click);
            // 
            // RentLbl
            // 
            this.RentLbl.AutoSize = true;
            this.RentLbl.Location = new System.Drawing.Point(23, 56);
            this.RentLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RentLbl.Name = "RentLbl";
            this.RentLbl.Size = new System.Drawing.Size(125, 18);
            this.RentLbl.TabIndex = 3;
            this.RentLbl.Text = "Аренда (в мес)";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateDTP.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.StartDateDTP.Location = new System.Drawing.Point(20, 330);
            this.StartDateDTP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(197, 24);
            this.StartDateDTP.TabIndex = 6;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(23, 293);
            this.StartDateLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(107, 18);
            this.StartDateLbl.TabIndex = 7;
            this.StartDateLbl.Text = "Дата начала";
            // 
            // SpeedNUD
            // 
            this.SpeedNUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SpeedNUD.Location = new System.Drawing.Point(265, 131);
            this.SpeedNUD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SpeedNUD.Name = "SpeedNUD";
            this.SpeedNUD.Size = new System.Drawing.Size(196, 24);
            this.SpeedNUD.TabIndex = 11;
            this.SpeedNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Location = new System.Drawing.Point(20, 136);
            this.SpeedLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(84, 18);
            this.SpeedLbl.TabIndex = 9;
            this.SpeedLbl.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начальное кол-во денег";
            // 
            // DefaultChrt
            // 
            this.DefaultChrt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DefaultChrt.BorderlineColor = System.Drawing.Color.Blue;
            this.DefaultChrt.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea2.Name = "ChartArea1";
            this.DefaultChrt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DefaultChrt.Legends.Add(legend2);
            this.DefaultChrt.Location = new System.Drawing.Point(478, 15);
            this.DefaultChrt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DefaultChrt.Name = "DefaultChrt";
            this.DefaultChrt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Кол-во денег";
            this.DefaultChrt.Series.Add(series2);
            this.DefaultChrt.Size = new System.Drawing.Size(655, 344);
            this.DefaultChrt.TabIndex = 12;
            this.DefaultChrt.Click += new System.EventHandler(this.DefaultChrt_Click);
            // 
            // DefaultTmr
            // 
            this.DefaultTmr.Tick += new System.EventHandler(this.DefaultTmr_Tick);
            // 
            // SalaryTB
            // 
            this.SalaryTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalaryTB.Location = new System.Drawing.Point(265, 14);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(196, 24);
            this.SalaryTB.TabIndex = 14;
            this.SalaryTB.Text = "2500";
            // 
            // RentTB
            // 
            this.RentTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RentTB.Location = new System.Drawing.Point(265, 50);
            this.RentTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RentTB.Name = "RentTB";
            this.RentTB.Size = new System.Drawing.Size(196, 24);
            this.RentTB.TabIndex = 15;
            this.RentTB.Text = "1200";
            // 
            // StartMoneyTB
            // 
            this.StartMoneyTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartMoneyTB.Location = new System.Drawing.Point(265, 95);
            this.StartMoneyTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartMoneyTB.Name = "StartMoneyTB";
            this.StartMoneyTB.Size = new System.Drawing.Size(196, 24);
            this.StartMoneyTB.TabIndex = 16;
            this.StartMoneyTB.Text = "3000";
            // 
            // ReportTB
            // 
            this.ReportTB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ReportTB.Location = new System.Drawing.Point(20, 373);
            this.ReportTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReportTB.Multiline = true;
            this.ReportTB.Name = "ReportTB";
            this.ReportTB.ReadOnly = true;
            this.ReportTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTB.Size = new System.Drawing.Size(536, 364);
            this.ReportTB.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Комунальные платежи";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_KomPlat
            // 
            this.tb_KomPlat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_KomPlat.Location = new System.Drawing.Point(265, 177);
            this.tb_KomPlat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_KomPlat.Name = "tb_KomPlat";
            this.tb_KomPlat.Size = new System.Drawing.Size(196, 24);
            this.tb_KomPlat.TabIndex = 19;
            this.tb_KomPlat.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 20;
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(981, 293);
            this.lb_money.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(60, 18);
            this.lb_money.TabIndex = 21;
            this.lb_money.Text = "Денег:";
            // 
            // tb_mounth
            // 
            this.tb_mounth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_mounth.Location = new System.Drawing.Point(567, 373);
            this.tb_mounth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_mounth.Multiline = true;
            this.tb_mounth.Name = "tb_mounth";
            this.tb_mounth.ReadOnly = true;
            this.tb_mounth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_mounth.Size = new System.Drawing.Size(567, 364);
            this.tb_mounth.TabIndex = 22;
            this.tb_mounth.TextChanged += new System.EventHandler(this.tb_mountc_TextChanged);
            // 
            // tb_strax
            // 
            this.tb_strax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_strax.Location = new System.Drawing.Point(265, 218);
            this.tb_strax.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_strax.Name = "tb_strax";
            this.tb_strax.Size = new System.Drawing.Size(196, 24);
            this.tb_strax.TabIndex = 24;
            this.tb_strax.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Страховые отчисления";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 795);
            this.Controls.Add(this.tb_strax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_mounth);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_KomPlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTB);
            this.Controls.Add(this.StartMoneyTB);
            this.Controls.Add(this.RentTB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.DefaultChrt);
            this.Controls.Add(this.SpeedNUD);
            this.Controls.Add(this.SpeedLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartDateLbl);
            this.Controls.Add(this.StartDateDTP);
            this.Controls.Add(this.RentLbl);
            this.Controls.Add(this.SalaryLbl);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainFrm";
            this.Text = "Шиномонтаж";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultChrt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.Label RentLbl;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.NumericUpDown SpeedNUD;
        private System.Windows.Forms.Label SpeedLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart DefaultChrt;
        private System.Windows.Forms.Timer DefaultTmr;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.TextBox RentTB;
        private System.Windows.Forms.TextBox StartMoneyTB;
        private System.Windows.Forms.TextBox ReportTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_KomPlat;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lb_money;
		private System.Windows.Forms.TextBox tb_mounth;
		private System.Windows.Forms.TextBox tb_strax;
		private System.Windows.Forms.Label label4;
	}
}

