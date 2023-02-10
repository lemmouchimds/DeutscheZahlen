namespace GermanNumbers
{
    partial class Challenge
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
            this.bnOK = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.bnGenerate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnOK
            // 
            this.bnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnOK.Location = new System.Drawing.Point(703, 178);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(85, 37);
            this.bnOK.TabIndex = 0;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumber.Location = new System.Drawing.Point(12, 113);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(175, 35);
            this.tbNumber.TabIndex = 1;
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbText.Location = new System.Drawing.Point(193, 113);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(595, 35);
            this.tbText.TabIndex = 2;
            // 
            // bnGenerate
            // 
            this.bnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnGenerate.Location = new System.Drawing.Point(12, 27);
            this.bnGenerate.Name = "bnGenerate";
            this.bnGenerate.Size = new System.Drawing.Size(85, 37);
            this.bnGenerate.TabIndex = 3;
            this.bnGenerate.Text = "Generate";
            this.bnGenerate.UseVisualStyleBackColor = true;
            this.bnGenerate.Click += new System.EventHandler(this.bnGenerate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(12, 178);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(471, 37);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "--";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 95);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 15);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(193, 95);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 15);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Text";
            // 
            // Challenge
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.bnGenerate);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.bnOK);
            this.MaximumSize = new System.Drawing.Size(816, 296);
            this.MinimumSize = new System.Drawing.Size(816, 296);
            this.Name = "Challenge";
            this.ShowIcon = false;
            this.Text = "Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bnOK;
        private TextBox tbNumber;
        private TextBox tbText;
        private Button bnGenerate;
        private Label lblAnswer;
        private Label lblNumber;
        private Label lblText;
    }
}