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
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(12, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(104, 54);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Nummer";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblString
            // 
            this.lblString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblString.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblString.Location = new System.Drawing.Point(137, 9);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(906, 54);
            this.lblString.TabIndex = 1;
            this.lblString.Text = "Satznummer";
            this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnGenerate
            // 
            this.bnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnGenerate.Location = new System.Drawing.Point(12, 92);
            this.bnGenerate.Name = "bnGenerate";
            this.bnGenerate.Size = new System.Drawing.Size(86, 32);
            this.bnGenerate.TabIndex = 2;
            this.bnGenerate.Text = "Generate";
            this.bnGenerate.UseVisualStyleBackColor = true;
            this.bnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumber.Location = new System.Drawing.Point(230, 89);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(682, 35);
            this.tbNumber.TabIndex = 3;
            // 
            // bnTranslate
            // 
            this.bnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnTranslate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnTranslate.Location = new System.Drawing.Point(941, 92);
            this.bnTranslate.Name = "bnTranslate";
            this.bnTranslate.Size = new System.Drawing.Size(86, 32);
            this.bnTranslate.TabIndex = 4;
            this.bnTranslate.Text = "Translate";
            this.bnTranslate.UseVisualStyleBackColor = true;
            this.bnTranslate.Click += new System.EventHandler(this.bnTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 162);
            this.Controls.Add(this.bnTranslate);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.bnGenerate);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblNumber);
            this.MinimumSize = new System.Drawing.Size(624, 201);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Deutsch Zehlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblString;
        private Button bnGenerate;
        private TextBox tbNumber;
        private Button bnTranslate;
    }
}