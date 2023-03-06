
namespace SnATasks
{
    partial class FormNarayana
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
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelInputSymbols = new System.Windows.Forms.Label();
            this.tbInputSymbols = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbInputCount = new System.Windows.Forms.TextBox();
            this.labelInputCount = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonGeneratePermutations = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(10, 10);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(919, 275);
            this.textBoxAnswer.TabIndex = 0;
            // 
            // labelInputSymbols
            // 
            this.labelInputSymbols.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInputSymbols.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputSymbols.Location = new System.Drawing.Point(20, 20);
            this.labelInputSymbols.Name = "labelInputSymbols";
            this.labelInputSymbols.Size = new System.Drawing.Size(496, 52);
            this.labelInputSymbols.TabIndex = 1;
            this.labelInputSymbols.Text = "Введите одиночные символы для перестановки через пробел";
            // 
            // tbInputSymbols
            // 
            this.tbInputSymbols.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInputSymbols.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInputSymbols.Location = new System.Drawing.Point(20, 72);
            this.tbInputSymbols.Name = "tbInputSymbols";
            this.tbInputSymbols.Size = new System.Drawing.Size(496, 27);
            this.tbInputSymbols.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Controls.Add(this.textBoxAnswer);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 196);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(939, 295);
            this.panelContent.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(939, 491);
            this.panelMain.TabIndex = 4;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelControls.Controls.Add(this.panelInput);
            this.panelControls.Controls.Add(this.panelButtons);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(939, 196);
            this.panelControls.TabIndex = 4;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelInput.Controls.Add(this.tbInputCount);
            this.panelInput.Controls.Add(this.labelInputCount);
            this.panelInput.Controls.Add(this.tbInputSymbols);
            this.panelInput.Controls.Add(this.labelInputSymbols);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Margin = new System.Windows.Forms.Padding(10);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);
            this.panelInput.Size = new System.Drawing.Size(536, 196);
            this.panelInput.TabIndex = 4;
            // 
            // tbInputCount
            // 
            this.tbInputCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInputCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInputCount.Location = new System.Drawing.Point(20, 124);
            this.tbInputCount.Name = "tbInputCount";
            this.tbInputCount.Size = new System.Drawing.Size(496, 27);
            this.tbInputCount.TabIndex = 4;
            // 
            // labelInputCount
            // 
            this.labelInputCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInputCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputCount.Location = new System.Drawing.Point(20, 99);
            this.labelInputCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelInputCount.Name = "labelInputCount";
            this.labelInputCount.Size = new System.Drawing.Size(496, 25);
            this.labelInputCount.TabIndex = 3;
            this.labelInputCount.Text = "Введите длину перестановки";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Plum;
            this.panelButtons.Controls.Add(this.buttonGeneratePermutations);
            this.panelButtons.Controls.Add(this.buttonHelp);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(536, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(40);
            this.panelButtons.Size = new System.Drawing.Size(403, 196);
            this.panelButtons.TabIndex = 4;
            // 
            // buttonGeneratePermutations
            // 
            this.buttonGeneratePermutations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneratePermutations.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneratePermutations.Location = new System.Drawing.Point(40, 40);
            this.buttonGeneratePermutations.Name = "buttonGeneratePermutations";
            this.buttonGeneratePermutations.Size = new System.Drawing.Size(214, 116);
            this.buttonGeneratePermutations.TabIndex = 5;
            this.buttonGeneratePermutations.Text = "Сгенерировать перестановки";
            this.buttonGeneratePermutations.UseVisualStyleBackColor = true;
            this.buttonGeneratePermutations.Click += new System.EventHandler(this.buttonGeneratePermutations_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(254, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(109, 116);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormNarayana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 491);
            this.Controls.Add(this.panelMain);
            this.Name = "FormNarayana";
            this.Text = "Перестановки. Алгоритм Нарайаны";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelInputSymbols;
        private System.Windows.Forms.TextBox tbInputSymbols;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonGeneratePermutations;
        private System.Windows.Forms.TextBox tbInputCount;
        private System.Windows.Forms.Label labelInputCount;
        private System.Windows.Forms.Button buttonHelp;
    }
}