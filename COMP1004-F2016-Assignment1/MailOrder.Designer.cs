namespace COMP1004_F2016_Assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.GermanRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.SpanishRadioButton);
            this.LanguageGroupBox.Controls.Add(this.GermanRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageGroupBox.Location = new System.Drawing.Point(118, 12);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(154, 74);
            this.LanguageGroupBox.TabIndex = 1;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpanishRadioButton.Location = new System.Drawing.Point(75, 46);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(70, 19);
            this.SpanishRadioButton.TabIndex = 3;
            this.SpanishRadioButton.TabStop = true;
            this.SpanishRadioButton.Text = "Spanish";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.Click += new System.EventHandler(this.SpanishRadioButton_Click);
            // 
            // GermanRadioButton
            // 
            this.GermanRadioButton.AutoSize = true;
            this.GermanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GermanRadioButton.Location = new System.Drawing.Point(75, 21);
            this.GermanRadioButton.Name = "GermanRadioButton";
            this.GermanRadioButton.Size = new System.Drawing.Size(70, 19);
            this.GermanRadioButton.TabIndex = 2;
            this.GermanRadioButton.TabStop = true;
            this.GermanRadioButton.Text = "German";
            this.GermanRadioButton.UseVisualStyleBackColor = true;
            this.GermanRadioButton.Click += new System.EventHandler(this.GermanRadioButton_Click);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenchRadioButton.Location = new System.Drawing.Point(6, 46);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(63, 19);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "French";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.Click += new System.EventHandler(this.FrenchRadioButton_Click);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 21);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(66, 19);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.Click += new System.EventHandler(this.EnglishRadioButton_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(12, 96);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(94, 13);
            this.EmployeeNameLabel.TabIndex = 2;
            this.EmployeeNameLabel.Text = "Employee\'s Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(12, 124);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 3;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(12, 150);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            this.HoursWorkedLabel.TabIndex = 4;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(12, 175);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(63, 13);
            this.TotalSalesLabel.TabIndex = 5;
            this.TotalSalesLabel.Text = "Total Sales:";
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(12, 200);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(69, 13);
            this.SalesBonusLabel.TabIndex = 6;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(15, 226);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(107, 226);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(197, 226);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.LanguageGroupBox);
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Order";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
        private System.Windows.Forms.RadioButton GermanRadioButton;
    }
}

