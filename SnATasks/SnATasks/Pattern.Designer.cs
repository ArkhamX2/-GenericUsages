
namespace SnATasks
{
    partial class Pattern
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(1124, 610);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Controls.Add(this.tbContent);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 144);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1124, 466);
            this.panelContent.TabIndex = 1;
            // 
            // tbContent
            // 
            this.tbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContent.Location = new System.Drawing.Point(10, 10);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(1104, 446);
            this.tbContent.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelControls.Controls.Add(this.panelInput);
            this.panelControls.Controls.Add(this.panelbuttons);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1124, 144);
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
            this.panelInput.Size = new System.Drawing.Size(831, 144);
            this.panelInput.TabIndex = 1;
            // 
            // tbInput
            // 
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(20, 45);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(791, 79);
            this.tbInput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(20, 20);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(791, 25);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "label1";
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Plum;
            this.panelbuttons.Controls.Add(this.buttonCalculate);
            this.panelbuttons.Controls.Add(this.buttonHelp);
            this.panelbuttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbuttons.Location = new System.Drawing.Point(831, 0);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Padding = new System.Windows.Forms.Padding(40);
            this.panelbuttons.Size = new System.Drawing.Size(293, 144);
            this.panelbuttons.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(40, 40);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(119, 64);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "button1";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(159, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(94, 64);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "button1";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 610);
            this.Controls.Add(this.panelMain);
            this.Name = "Pattern";
            this.Text = "Pattern";
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonHelp;
    }
}