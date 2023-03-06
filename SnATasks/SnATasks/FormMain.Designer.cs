
namespace SnATasks
{
    partial class FormMain
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
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonNarayana = new System.Windows.Forms.Button();
            this.buttonBoxes = new System.Windows.Forms.Button();
            this.buttonSeries = new System.Windows.Forms.Button();
            this.buttonArrays = new System.Windows.Forms.Button();
            this.buttonTriangles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDates = new System.Windows.Forms.Label();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.labelDate3 = new System.Windows.Forms.Label();
            this.labelDate4 = new System.Windows.Forms.Label();
            this.labelDate5 = new System.Windows.Forms.Label();
            this.labelDate6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChart
            // 
            this.buttonChart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChart.Location = new System.Drawing.Point(12, 34);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(283, 34);
            this.buttonChart.TabIndex = 0;
            this.buttonChart.Text = "Chart";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonNarayana
            // 
            this.buttonNarayana.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNarayana.Location = new System.Drawing.Point(12, 74);
            this.buttonNarayana.Name = "buttonNarayana";
            this.buttonNarayana.Size = new System.Drawing.Size(283, 34);
            this.buttonNarayana.TabIndex = 1;
            this.buttonNarayana.Text = "Нарайана";
            this.buttonNarayana.UseVisualStyleBackColor = true;
            this.buttonNarayana.Click += new System.EventHandler(this.buttonNarayana_Click);
            // 
            // buttonBoxes
            // 
            this.buttonBoxes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBoxes.Location = new System.Drawing.Point(12, 114);
            this.buttonBoxes.Name = "buttonBoxes";
            this.buttonBoxes.Size = new System.Drawing.Size(283, 34);
            this.buttonBoxes.TabIndex = 2;
            this.buttonBoxes.Text = "Коробки";
            this.buttonBoxes.UseVisualStyleBackColor = true;
            this.buttonBoxes.Click += new System.EventHandler(this.buttonBoxes_Click);
            // 
            // buttonSeries
            // 
            this.buttonSeries.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeries.Location = new System.Drawing.Point(12, 154);
            this.buttonSeries.Name = "buttonSeries";
            this.buttonSeries.Size = new System.Drawing.Size(283, 34);
            this.buttonSeries.TabIndex = 3;
            this.buttonSeries.Text = "Серии символов";
            this.buttonSeries.UseVisualStyleBackColor = true;
            this.buttonSeries.Click += new System.EventHandler(this.buttonSeries_Click);
            // 
            // buttonArrays
            // 
            this.buttonArrays.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrays.Location = new System.Drawing.Point(12, 194);
            this.buttonArrays.Name = "buttonArrays";
            this.buttonArrays.Size = new System.Drawing.Size(283, 34);
            this.buttonArrays.TabIndex = 4;
            this.buttonArrays.Text = "Симметричный и разреженный массив";
            this.buttonArrays.UseVisualStyleBackColor = true;
            this.buttonArrays.Click += new System.EventHandler(this.buttonArrays_Click);
            // 
            // buttonTriangles
            // 
            this.buttonTriangles.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangles.Location = new System.Drawing.Point(12, 234);
            this.buttonTriangles.Name = "buttonTriangles";
            this.buttonTriangles.Size = new System.Drawing.Size(283, 34);
            this.buttonTriangles.TabIndex = 5;
            this.buttonTriangles.Text = "Треугольник с наименьшим периметром";
            this.buttonTriangles.UseVisualStyleBackColor = true;
            this.buttonTriangles.Click += new System.EventHandler(this.buttonTriangles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Задачи:";
            // 
            // labelDates
            // 
            this.labelDates.AutoSize = true;
            this.labelDates.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDates.Location = new System.Drawing.Point(306, 9);
            this.labelDates.Name = "labelDates";
            this.labelDates.Size = new System.Drawing.Size(54, 22);
            this.labelDates.TabIndex = 7;
            this.labelDates.Text = "Дата:";
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate1.Location = new System.Drawing.Point(306, 42);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(71, 19);
            this.labelDate1.TabIndex = 8;
            this.labelDate1.Text = "7.09.2022";
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate2.Location = new System.Drawing.Point(306, 82);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(71, 19);
            this.labelDate2.TabIndex = 9;
            this.labelDate2.Text = "7.09.2022";
            // 
            // labelDate3
            // 
            this.labelDate3.AutoSize = true;
            this.labelDate3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate3.Location = new System.Drawing.Point(306, 122);
            this.labelDate3.Name = "labelDate3";
            this.labelDate3.Size = new System.Drawing.Size(79, 19);
            this.labelDate3.TabIndex = 10;
            this.labelDate3.Text = "14.09.2022";
            // 
            // labelDate4
            // 
            this.labelDate4.AutoSize = true;
            this.labelDate4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate4.Location = new System.Drawing.Point(306, 162);
            this.labelDate4.Name = "labelDate4";
            this.labelDate4.Size = new System.Drawing.Size(79, 19);
            this.labelDate4.TabIndex = 11;
            this.labelDate4.Text = "14.09.2022";
            // 
            // labelDate5
            // 
            this.labelDate5.AutoSize = true;
            this.labelDate5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate5.Location = new System.Drawing.Point(306, 202);
            this.labelDate5.Name = "labelDate5";
            this.labelDate5.Size = new System.Drawing.Size(79, 19);
            this.labelDate5.TabIndex = 12;
            this.labelDate5.Text = "21.09.2022";
            // 
            // labelDate6
            // 
            this.labelDate6.AutoSize = true;
            this.labelDate6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate6.Location = new System.Drawing.Point(306, 242);
            this.labelDate6.Name = "labelDate6";
            this.labelDate6.Size = new System.Drawing.Size(79, 19);
            this.labelDate6.TabIndex = 13;
            this.labelDate6.Text = "21.09.2022";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 279);
            this.Controls.Add(this.labelDate6);
            this.Controls.Add(this.labelDate5);
            this.Controls.Add(this.labelDate4);
            this.Controls.Add(this.labelDate3);
            this.Controls.Add(this.labelDate2);
            this.Controls.Add(this.labelDate1);
            this.Controls.Add(this.labelDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTriangles);
            this.Controls.Add(this.buttonArrays);
            this.Controls.Add(this.buttonSeries);
            this.Controls.Add(this.buttonBoxes);
            this.Controls.Add(this.buttonNarayana);
            this.Controls.Add(this.buttonChart);
            this.Name = "FormMain";
            this.Text = "SnA tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonNarayana;
        private System.Windows.Forms.Button buttonBoxes;
        private System.Windows.Forms.Button buttonSeries;
        private System.Windows.Forms.Button buttonArrays;
        private System.Windows.Forms.Button buttonTriangles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDates;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Label labelDate3;
        private System.Windows.Forms.Label labelDate4;
        private System.Windows.Forms.Label labelDate5;
        private System.Windows.Forms.Label labelDate6;
    }
}

