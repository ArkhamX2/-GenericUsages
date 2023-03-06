
namespace SnATasks
{
    partial class FormTriangles
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.chartTriangles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewLegend = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textBoxCountDots = new System.Windows.Forms.TextBox();
            this.labelCountDots = new System.Windows.Forms.Label();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTriangles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLegend)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 634);
            this.panelMain.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Controls.Add(this.chartTriangles);
            this.panelContent.Controls.Add(this.dataGridViewLegend);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1131, 475);
            this.panelContent.TabIndex = 1;
            // 
            // chartTriangles
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTriangles.ChartAreas.Add(chartArea1);
            this.chartTriangles.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTriangles.Legends.Add(legend1);
            this.chartTriangles.Location = new System.Drawing.Point(10, 10);
            this.chartTriangles.Name = "chartTriangles";
            this.chartTriangles.Size = new System.Drawing.Size(868, 455);
            this.chartTriangles.TabIndex = 1;
            this.chartTriangles.Text = "Triangles";
            // 
            // dataGridViewLegend
            // 
            this.dataGridViewLegend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLegend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewLegend.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewLegend.Location = new System.Drawing.Point(878, 10);
            this.dataGridViewLegend.Name = "dataGridViewLegend";
            this.dataGridViewLegend.Size = new System.Drawing.Size(243, 455);
            this.dataGridViewLegend.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelControls.Controls.Add(this.panelInput);
            this.panelControls.Controls.Add(this.panelbuttons);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 475);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1131, 159);
            this.panelControls.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panelInput.Controls.Add(this.tbContent);
            this.panelInput.Controls.Add(this.labelAnswer);
            this.panelInput.Controls.Add(this.textBoxCountDots);
            this.panelInput.Controls.Add(this.labelCountDots);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.Size = new System.Drawing.Size(823, 159);
            this.panelInput.TabIndex = 2;
            // 
            // tbContent
            // 
            this.tbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContent.Location = new System.Drawing.Point(10, 89);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(803, 60);
            this.tbContent.TabIndex = 0;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(10, 64);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(212, 25);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Искомый треугольник";
            // 
            // textBoxCountDots
            // 
            this.textBoxCountDots.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCountDots.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountDots.Location = new System.Drawing.Point(10, 35);
            this.textBoxCountDots.Name = "textBoxCountDots";
            this.textBoxCountDots.Size = new System.Drawing.Size(803, 29);
            this.textBoxCountDots.TabIndex = 2;
            // 
            // labelCountDots
            // 
            this.labelCountDots.AutoSize = true;
            this.labelCountDots.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCountDots.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountDots.Location = new System.Drawing.Point(10, 10);
            this.labelCountDots.Name = "labelCountDots";
            this.labelCountDots.Size = new System.Drawing.Size(247, 25);
            this.labelCountDots.TabIndex = 1;
            this.labelCountDots.Text = "Введите количество точек";
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Plum;
            this.panelbuttons.Controls.Add(this.buttonCalculate);
            this.panelbuttons.Controls.Add(this.buttonHelp);
            this.panelbuttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbuttons.Location = new System.Drawing.Point(823, 0);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Padding = new System.Windows.Forms.Padding(40);
            this.panelbuttons.Size = new System.Drawing.Size(308, 159);
            this.panelbuttons.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(40, 40);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(131, 79);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(171, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(97, 79);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormTriangles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 634);
            this.Controls.Add(this.panelMain);
            this.Name = "FormTriangles";
            this.Text = "Треугольник снаименьшим периметром";
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTriangles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLegend)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTriangles;
        private System.Windows.Forms.DataGridView dataGridViewLegend;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox textBoxCountDots;
        private System.Windows.Forms.Label labelCountDots;
    }
}