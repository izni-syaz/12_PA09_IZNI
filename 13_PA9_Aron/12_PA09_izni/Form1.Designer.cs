namespace _12_PA09_izni
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_SelectCurrency = new System.Windows.Forms.Label();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_ConvertAmount = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.rdb_USDollar = new System.Windows.Forms.RadioButton();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(58, 59);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_SelectCurrency
            // 
            this.lbl_SelectCurrency.AutoSize = true;
            this.lbl_SelectCurrency.Location = new System.Drawing.Point(58, 115);
            this.lbl_SelectCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SelectCurrency.Name = "lbl_SelectCurrency";
            this.lbl_SelectCurrency.Size = new System.Drawing.Size(82, 13);
            this.lbl_SelectCurrency.TabIndex = 1;
            this.lbl_SelectCurrency.Text = "Select Currency";
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Location = new System.Drawing.Point(58, 189);
            this.lbl_Level.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(34, 13);
            this.lbl_Level.TabIndex = 2;
            this.lbl_Level.Text = "Value";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(218, 59);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(146, 20);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_ConvertAmount
            // 
            this.txt_ConvertAmount.Location = new System.Drawing.Point(218, 184);
            this.txt_ConvertAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ConvertAmount.Name = "txt_ConvertAmount";
            this.txt_ConvertAmount.ReadOnly = true;
            this.txt_ConvertAmount.Size = new System.Drawing.Size(76, 20);
            this.txt_ConvertAmount.TabIndex = 4;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(428, 115);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(56, 19);
            this.btn_Convert.TabIndex = 5;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(428, 170);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(56, 19);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // rdb_USDollar
            // 
            this.rdb_USDollar.AutoSize = true;
            this.rdb_USDollar.Location = new System.Drawing.Point(218, 115);
            this.rdb_USDollar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_USDollar.Name = "rdb_USDollar";
            this.rdb_USDollar.Size = new System.Drawing.Size(70, 17);
            this.rdb_USDollar.TabIndex = 7;
            this.rdb_USDollar.TabStop = true;
            this.rdb_USDollar.Text = "US Dollar";
            this.rdb_USDollar.UseVisualStyleBackColor = true;
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(218, 136);
            this.rdb_JapaneseYen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(93, 17);
            this.rdb_JapaneseYen.TabIndex = 8;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_MalaysianRinggit
            // 
            this.rdb_MalaysianRinggit.AutoSize = true;
            this.rdb_MalaysianRinggit.Location = new System.Drawing.Point(218, 159);
            this.rdb_MalaysianRinggit.Name = "rdb_MalaysianRinggit";
            this.rdb_MalaysianRinggit.Size = new System.Drawing.Size(111, 17);
            this.rdb_MalaysianRinggit.TabIndex = 9;
            this.rdb_MalaysianRinggit.TabStop = true;
            this.rdb_MalaysianRinggit.Text = "Malaysian Ringgit ";
            this.rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 368);
            this.Controls.Add(this.rdb_MalaysianRinggit);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.rdb_USDollar);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txt_ConvertAmount);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_SelectCurrency);
            this.Controls.Add(this.lbl_amount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_SelectCurrency;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_ConvertAmount;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RadioButton rdb_USDollar;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton rdb_MalaysianRinggit;
    }
}

