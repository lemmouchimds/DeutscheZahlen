namespace GermanNumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.bnGenerate = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.bnTranslate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.challengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(12, 39);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(119, 54);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Nummer";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblString
            // 
            this.lblString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblString.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblString.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblString.Location = new System.Drawing.Point(137, 39);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(906, 54);
            this.lblString.TabIndex = 1;
            this.lblString.Text = "Satznummer";
            this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnGenerate
            // 
            this.bnGenerate.BackColor = System.Drawing.SystemColors.Info;
            this.bnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnGenerate.Location = new System.Drawing.Point(12, 122);
            this.bnGenerate.Name = "bnGenerate";
            this.bnGenerate.Size = new System.Drawing.Size(86, 32);
            this.bnGenerate.TabIndex = 2;
            this.bnGenerate.Text = "Generate";
            this.bnGenerate.UseVisualStyleBackColor = false;
            this.bnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumber.Location = new System.Drawing.Point(230, 119);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(682, 43);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // bnTranslate
            // 
            this.bnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnTranslate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bnTranslate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnTranslate.Location = new System.Drawing.Point(941, 122);
            this.bnTranslate.Name = "bnTranslate";
            this.bnTranslate.Size = new System.Drawing.Size(86, 32);
            this.bnTranslate.TabIndex = 4;
            this.bnTranslate.Text = "Translate";
            this.bnTranslate.UseVisualStyleBackColor = false;
            this.bnTranslate.Click += new System.EventHandler(this.bnTranslate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.challengeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // challengeToolStripMenuItem
            // 
            this.challengeToolStripMenuItem.Name = "challengeToolStripMenuItem";
            this.challengeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.challengeToolStripMenuItem.Text = "Challenge";
            this.challengeToolStripMenuItem.Click += new System.EventHandler(this.challengeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 221);
            this.Controls.Add(this.bnTranslate);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.bnGenerate);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(624, 201);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Deutsch Zehlen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblString;
        private Button bnGenerate;
        private TextBox tbNumber;
        private Button bnTranslate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem challengeToolStripMenuItem;
    }
}