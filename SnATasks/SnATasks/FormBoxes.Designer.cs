
namespace SnATasks
{
    partial class FormBoxes
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Controls.Add(this.textBoxContent);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 125);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(809, 78);
            this.panelContent.TabIndex = 1;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContent.Location = new System.Drawing.Point(10, 10);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.Size = new System.Drawing.Size(789, 58);
            this.textBoxContent.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(809, 203);
            this.panelMain.TabIndex = 1;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelControls.Controls.Add(this.panelInput);
            this.panelControls.Controls.Add(this.panelbuttons);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(809, 125);
            this.panelControls.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panelInput.Controls.Add(this.tbInput);
            this.panelInput.Controls.Add(this.labelInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);
            this.panelInput.Size = new System.Drawing.Size(453, 125);
            this.panelInput.TabIndex = 1;
            // 
            // tbInput
            // 
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(20, 80);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(413, 33);
            this.tbInput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(20, 20);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(413, 60);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Введите размеры первого прямоугольника,\r\n а затем второго через пробел";
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Plum;
            this.panelbuttons.Controls.Add(this.buttonCalculate);
            this.panelbuttons.Controls.Add(this.buttonHelp);
            this.panelbuttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbuttons.Location = new System.Drawing.Point(453, 0);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Padding = new System.Windows.Forms.Padding(30);
            this.panelbuttons.Size = new System.Drawing.Size(356, 125);
            this.panelbuttons.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(30, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(196, 65);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Определить расположение";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(226, 30);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 65);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 203);
            this.Controls.Add(this.panelMain);
            this.Name = "FormBoxes";
            this.Text = "Прямоугольники";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonHelp;
    }
}