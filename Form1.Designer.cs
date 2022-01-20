using System.Windows.Forms;
namespace WindowsFormsApp4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tBConsole = new System.Windows.Forms.TextBox();
            this.btnConsoleClear = new System.Windows.Forms.Button();
            this.btnReqArduino = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TBmessageToSend = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(781, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "OpenPort";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(781, 198);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(164, 30);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "ClosePort";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 431);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(742, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(387, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = " Text";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(231, 413);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(778, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(781, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(781, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(164, 21);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tBConsole
            // 
            this.tBConsole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tBConsole.Location = new System.Drawing.Point(27, 465);
            this.tBConsole.Multiline = true;
            this.tBConsole.Name = "tBConsole";
            this.tBConsole.ReadOnly = true;
            this.tBConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBConsole.Size = new System.Drawing.Size(742, 145);
            this.tBConsole.TabIndex = 9;
            // 
            // btnConsoleClear
            // 
            this.btnConsoleClear.Location = new System.Drawing.Point(4, 465);
            this.btnConsoleClear.Name = "btnConsoleClear";
            this.btnConsoleClear.Size = new System.Drawing.Size(23, 24);
            this.btnConsoleClear.TabIndex = 10;
            this.btnConsoleClear.Text = "X";
            this.btnConsoleClear.UseVisualStyleBackColor = true;
            this.btnConsoleClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReqArduino
            // 
            this.btnReqArduino.Location = new System.Drawing.Point(875, 161);
            this.btnReqArduino.Name = "btnReqArduino";
            this.btnReqArduino.Size = new System.Drawing.Size(70, 31);
            this.btnReqArduino.TabIndex = 11;
            this.btnReqArduino.Text = "ReqData";
            this.btnReqArduino.UseVisualStyleBackColor = true;
            this.btnReqArduino.Click += new System.EventHandler(this.btnReqArduino_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Чита из буферов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBmessageToSend
            // 
            this.TBmessageToSend.Location = new System.Drawing.Point(264, 12);
            this.TBmessageToSend.Multiline = true;
            this.TBmessageToSend.Name = "TBmessageToSend";
            this.TBmessageToSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBmessageToSend.Size = new System.Drawing.Size(505, 413);
            this.TBmessageToSend.TabIndex = 13;
            this.TBmessageToSend.Text = resources.GetString("TBmessageToSend.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 612);
            this.Controls.Add(this.TBmessageToSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReqArduino);
            this.Controls.Add(this.btnConsoleClear);
            this.Controls.Add(this.tBConsole);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "MyProg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox tBConsole;
        private Button btnConsoleClear;
        private Button btnReqArduino;
        private Button button1;
        private TextBox TBmessageToSend;
        private Timer timer1;
    }
}

