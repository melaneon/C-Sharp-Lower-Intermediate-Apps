namespace OrderTreatsApp
{
    partial class Roam
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
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMenu
            // 
            this.lstMenu.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 26;
            this.lstMenu.Items.AddRange(new object[] {
            "Sugar Cookie",
            "Gingerbread Cookie",
            "Stollen",
            "Fruit Cake",
            "Peppermint Cane"});
            this.lstMenu.Location = new System.Drawing.Point(95, 115);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(207, 108);
            this.lstMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select order(s):";
            // 
            // lstSelected
            // 
            this.lstSelected.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.ItemHeight = 26;
            this.lstSelected.Location = new System.Drawing.Point(387, 252);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(267, 108);
            this.lstSelected.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Items:";
            // 
            // quant
            // 
            this.quant.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quant.FormattingEnabled = true;
            this.quant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quant.Location = new System.Drawing.Point(387, 115);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(92, 34);
            this.quant.TabIndex = 4;
            this.quant.SelectedIndexChanged += new System.EventHandler(this.quant_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select quantity:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Item to the Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Roam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(735, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMenu);
            this.Name = "Roam";
            this.Text = "Holiday Goddies Order App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox quant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

