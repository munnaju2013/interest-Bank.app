namespace brac_bank
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowComboBox = new System.Windows.Forms.ComboBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowComboBox
            // 
            this.ShowComboBox.FormattingEnabled = true;
            this.ShowComboBox.Items.AddRange(new object[] {
            "BRAC 6%",
            "BDDL 7%",
            "HSBC 8%"});
            this.ShowComboBox.Location = new System.Drawing.Point(277, 57);
            this.ShowComboBox.Name = "ShowComboBox";
            this.ShowComboBox.Size = new System.Drawing.Size(373, 21);
            this.ShowComboBox.TabIndex = 0;
            this.ShowComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(277, 107);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(373, 20);
            this.capitalTextBox.TabIndex = 1;
            this.capitalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(277, 159);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(373, 20);
            this.yearTextBox.TabIndex = 2;
            this.yearTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(277, 210);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(373, 20);
            this.interestTextBox.TabIndex = 3;
            this.interestTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interest";
            // 
            // pressButton
            // 
            this.pressButton.Location = new System.Drawing.Point(277, 275);
            this.pressButton.Name = "pressButton";
            this.pressButton.Size = new System.Drawing.Size(373, 23);
            this.pressButton.TabIndex = 7;
            this.pressButton.Text = "Press";
            this.pressButton.UseVisualStyleBackColor = true;
            this.pressButton.Click += new System.EventHandler(this.pressButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 329);
            this.Controls.Add(this.pressButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.ShowComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ShowComboBox;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pressButton;
    }
}

