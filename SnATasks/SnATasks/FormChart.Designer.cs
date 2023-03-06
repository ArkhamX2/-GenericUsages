
namespace SnATasks
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.dataGridViewSpline = new System.Windows.Forms.DataGridView();
            this.XColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartSplineMaker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSplineMaker)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(20, 20);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(812, 47);
            this.labelInput.TabIndex = 9;
            this.labelInput.Text = "Введите количество точек";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(20, 67);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(812, 35);
            this.textBoxInput.TabIndex = 8;
            // 
            // Generate
            // 
            this.Generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(40, 40);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(486, 54);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Сгенерировать новый график";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // dataGridViewSpline
            // 
            this.dataGridViewSpline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XColumn,
            this.YColumn});
            this.dataGridViewSpline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSpline.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSpline.Name = "dataGridViewSpline";
            this.dataGridViewSpline.Size = new System.Drawing.Size(241, 592);
            this.dataGridViewSpline.TabIndex = 6;
            // 
            // XColumn
            // 
            this.XColumn.Frozen = true;
            this.XColumn.HeaderText = "X";
            this.XColumn.Name = "XColumn";
            this.XColumn.ReadOnly = true;
            // 
            // YColumn
            // 
            this.YColumn.HeaderText = "Y";
            this.YColumn.Name = "YColumn";
            this.YColumn.ReadOnly = true;
            // 
            // chartSplineMaker
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSplineMaker.ChartAreas.Add(chartArea1);
            this.chartSplineMaker.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSplineMaker.Legends.Add(legend1);
            this.chartSplineMaker.Location = new System.Drawing.Point(10, 10);
            this.chartSplineMaker.Name = "chartSplineMaker";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSplineMaker.Series.Add(series1);
            this.chartSplineMaker.Size = new System.Drawing.Size(1285, 592);
            this.chartSplineMaker.TabIndex = 5;
            this.chartSplineMaker.Text = "chart1";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Lavender;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1546, 746);
            this.panelMain.TabIndex = 10;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Controls.Add(this.chartSplineMaker);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1546, 612);
            this.panelContent.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.dataGridViewSpline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1295, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 592);
            this.panel1.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelControls.Controls.Add(this.panelInput);
            this.panelControls.Controls.Add(this.panelButtons);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 612);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1546, 134);
            this.panelControls.TabIndex = 10;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelInput.Controls.Add(this.textBoxInput);
            this.panelInput.Controls.Add(this.labelInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20, 20, 20, 30);
            this.panelInput.Size = new System.Drawing.Size(852, 134);
            this.panelInput.TabIndex = 11;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Plum;
            this.panelButtons.Controls.Add(this.Generate);
            this.panelButtons.Controls.Add(this.buttonHelp);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(852, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(40);
            this.panelButtons.Size = new System.Drawing.Size(694, 134);
            this.panelButtons.TabIndex = 10;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(526, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(128, 54);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 746);
            this.Controls.Add(this.panelMain);
            this.Name = "FormChart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSplineMaker)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.DataGridView dataGridViewSpline;
        private System.Windows.Forms.DataGridViewTextBoxColumn XColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSplineMaker;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
    }
}