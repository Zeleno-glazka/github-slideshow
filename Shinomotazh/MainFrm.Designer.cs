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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_KomPlat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultChrt)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(17, 539);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(585, 539);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Стоп";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.Location = new System.Drawing.Point(14, 11);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(141, 13);
            this.SalaryLbl.TabIndex = 2;
            this.SalaryLbl.Text = "Зарплаты рабочим (в мес)";
            // 
            // RentLbl
            // 
            this.RentLbl.AutoSize = true;
            this.RentLbl.Location = new System.Drawing.Point(14, 40);
            this.RentLbl.Name = "RentLbl";
            this.RentLbl.Size = new System.Drawing.Size(82, 13);
            this.RentLbl.TabIndex = 3;
            this.RentLbl.Text = "Аренда (в мес)";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Location = new System.Drawing.Point(12, 239);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(120, 20);
            this.StartDateDTP.TabIndex = 6;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(14, 212);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(71, 13);
            this.StartDateLbl.TabIndex = 7;
            this.StartDateLbl.Text = "Дата начала";
            // 
            // SpeedNUD
            // 
            this.SpeedNUD.Location = new System.Drawing.Point(161, 114);
            this.SpeedNUD.Name = "SpeedNUD";
            this.SpeedNUD.Size = new System.Drawing.Size(120, 20);
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
            this.SpeedLbl.Location = new System.Drawing.Point(14, 116);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(55, 13);
            this.SpeedLbl.TabIndex = 9;
            this.SpeedLbl.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начальное кол-во денег";
            // 
            // DefaultChrt
            // 
            this.DefaultChrt.BackColor = System.Drawing.Color.SeaShell;
            this.DefaultChrt.BorderlineColor = System.Drawing.Color.Maroon;
            this.DefaultChrt.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "ChartArea1";
            this.DefaultChrt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DefaultChrt.Legends.Add(legend1);
            this.DefaultChrt.Location = new System.Drawing.Point(287, 11);
            this.DefaultChrt.Name = "DefaultChrt";
            this.DefaultChrt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Кол-во денег";
            this.DefaultChrt.Series.Add(series1);
            this.DefaultChrt.Size = new System.Drawing.Size(393, 248);
            this.DefaultChrt.TabIndex = 12;
            this.DefaultChrt.Click += new System.EventHandler(this.DefaultChrt_Click);
            // 
            // DefaultTmr
            // 
            this.DefaultTmr.Tick += new System.EventHandler(this.DefaultTmr_Tick);
            // 
            // SalaryTB
            // 
            this.SalaryTB.Location = new System.Drawing.Point(161, 11);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(119, 20);
            this.SalaryTB.TabIndex = 14;
            this.SalaryTB.Text = "2500";
            // 
            // RentTB
            // 
            this.RentTB.Location = new System.Drawing.Point(161, 37);
            this.RentTB.Name = "RentTB";
            this.RentTB.Size = new System.Drawing.Size(119, 20);
            this.RentTB.TabIndex = 15;
            this.RentTB.Text = "1200";
            // 
            // StartMoneyTB
            // 
            this.StartMoneyTB.Location = new System.Drawing.Point(161, 88);
            this.StartMoneyTB.Name = "StartMoneyTB";
            this.StartMoneyTB.Size = new System.Drawing.Size(120, 20);
            this.StartMoneyTB.TabIndex = 16;
            this.StartMoneyTB.Text = "3000";
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(12, 269);
            this.AnswerTB.Multiline = true;
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.ReadOnly = true;
            this.AnswerTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerTB.Size = new System.Drawing.Size(668, 264);
            this.AnswerTB.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Комунальные платежи";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_KomPlat
            // 
            this.TB_KomPlat.Location = new System.Drawing.Point(161, 163);
            this.TB_KomPlat.Name = "TB_KomPlat";
            this.TB_KomPlat.Size = new System.Drawing.Size(120, 20);
            this.TB_KomPlat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 20;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_KomPlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerTB);
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
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_KomPlat;
        private System.Windows.Forms.Label label3;
    }
}

