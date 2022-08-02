namespace TextName
{
    partial class Form1
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

        public static System.Drawing.Color Green { get; }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.btnShowName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(250, 70);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(250, 32);
            this.textName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.labelName.Location = new System.Drawing.Point(163, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelAnswer
            // 
            this.labelAnswer.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.labelAnswer.Location = new System.Drawing.Point(253, 150);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(420, 24);
            this.labelAnswer.TabIndex = 2;
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnShowName
            // 
            this.btnShowName.BackColor = System.Drawing.Color.Green;
            this.btnShowName.Font = new System.Drawing.Font("Bookman Old Style", 13F);
            this.btnShowName.ForeColor = System.Drawing.Color.LightYellow;
            this.btnShowName.Location = new System.Drawing.Point(243, 199);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(193, 46);
            this.btnShowName.TabIndex = 3;
            this.btnShowName.Text = "Show Name";
            this.btnShowName.UseVisualStyleBackColor = false;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShowName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.btnShowName);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button btnShowName;
    }
}

