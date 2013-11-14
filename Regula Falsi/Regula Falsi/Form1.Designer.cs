namespace Regula_Falsi
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_log = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_com = new System.Windows.Forms.ComboBox();
            this.cbx_scroll = new System.Windows.Forms.CheckBox();
            this.num_num = new System.Windows.Forms.NumericUpDown();
            this.btn_txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_num)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Interval = 20D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleView.Size = 100D;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Interval = 100D;
            chartArea1.AxisY.Maximum = 1024D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "U";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 7F;
            chartArea1.InnerPlotPosition.Y = 7F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 80F;
            chartArea1.Position.X = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(153, 43);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Spannung";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Maximum";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(709, 433);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(73, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(70, 23);
            this.btn_connect.TabIndex = 10;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_log
            // 
            this.lbl_log.FormattingEnabled = true;
            this.lbl_log.Location = new System.Drawing.Point(12, 41);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(131, 407);
            this.lbl_log.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Frequenz: ";
            // 
            // cmb_com
            // 
            this.cmb_com.FormattingEnabled = true;
            this.cmb_com.Location = new System.Drawing.Point(12, 14);
            this.cmb_com.Name = "cmb_com";
            this.cmb_com.Size = new System.Drawing.Size(55, 21);
            this.cmb_com.TabIndex = 13;
            // 
            // cbx_scroll
            // 
            this.cbx_scroll.AutoSize = true;
            this.cbx_scroll.Checked = true;
            this.cbx_scroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_scroll.Location = new System.Drawing.Point(444, 16);
            this.cbx_scroll.Name = "cbx_scroll";
            this.cbx_scroll.Size = new System.Drawing.Size(52, 17);
            this.cbx_scroll.TabIndex = 14;
            this.cbx_scroll.Text = "Scroll";
            this.cbx_scroll.UseVisualStyleBackColor = true;
            this.cbx_scroll.CheckedChanged += new System.EventHandler(this.cbx_scroll_CheckedChanged);
            // 
            // num_num
            // 
            this.num_num.Enabled = false;
            this.num_num.Location = new System.Drawing.Point(502, 15);
            this.num_num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_num.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_num.Name = "num_num";
            this.num_num.Size = new System.Drawing.Size(52, 20);
            this.num_num.TabIndex = 17;
            this.num_num.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(12, 453);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(131, 23);
            this.btn_txt.TabIndex = 18;
            this.btn_txt.Text = "in Datei speichern";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 488);
            this.Controls.Add(this.btn_txt);
            this.Controls.Add(this.num_num);
            this.Controls.Add(this.cbx_scroll);
            this.Controls.Add(this.cmb_com);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "powernApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox lbl_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_com;
        private System.Windows.Forms.CheckBox cbx_scroll;
        private System.Windows.Forms.NumericUpDown num_num;
        private System.Windows.Forms.Button btn_txt;
    }
}

