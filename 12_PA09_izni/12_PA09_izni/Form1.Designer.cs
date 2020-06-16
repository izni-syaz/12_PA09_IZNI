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
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(77, 73);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(56, 17);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_SelectCurrency
            // 
            this.lbl_SelectCurrency.AutoSize = true;
            this.lbl_SelectCurrency.Location = new System.Drawing.Point(77, 141);
            this.lbl_SelectCurrency.Name = "lbl_SelectCurrency";
            this.lbl_SelectCurrency.Size = new System.Drawing.Size(108, 17);
            this.lbl_SelectCurrency.TabIndex = 1;
            this.lbl_SelectCurrency.Text = "Select Currency";
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Location = new System.Drawing.Point(77, 233);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(44, 17);
            this.lbl_Level.TabIndex = 2;
            this.lbl_Level.Text = "Value";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(290, 73);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(194, 22);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_ConvertAmount
            // 
            this.txt_ConvertAmount.Location = new System.Drawing.Point(290, 227);
            this.txt_ConvertAmount.Name = "txt_ConvertAmount";
            this.txt_ConvertAmount.ReadOnly = true;
            this.txt_ConvertAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_ConvertAmount.TabIndex = 4;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(570, 141);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 5;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(570, 209);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // rdb_USDollar
            // 
            this.rdb_USDollar.AutoSize = true;
            this.rdb_USDollar.Location = new System.Drawing.Point(290, 141);
            this.rdb_USDollar.Name = "rdb_USDollar";
            this.rdb_USDollar.Size = new System.Drawing.Size(89, 21);
            this.rdb_USDollar.TabIndex = 7;
            this.rdb_USDollar.TabStop = true;
            this.rdb_USDollar.Text = "US Dollar";
            this.rdb_USDollar.UseVisualStyleBackColor = true;
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(290, 179);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(120, 21);
            this.rdb_JapaneseYen.TabIndex = 8;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.rdb_USDollar);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txt_ConvertAmount);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_SelectCurrency);
            this.Controls.Add(this.lbl_amount);
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
    }
}

