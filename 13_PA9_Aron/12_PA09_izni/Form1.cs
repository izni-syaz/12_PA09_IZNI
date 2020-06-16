using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_PA09_izni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double ConvertedValue;

            //checking for null values
            if ((rdb_USDollar.Checked == false) || (rdb_JapaneseYen.Checked == false))
            {
                txt_ConvertAmount.Text = "Select at least one type of currency to convert";
            }
            try
            {
                //Convert SGD to US dollar
                if (rdb_USDollar.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    ConvertedValue = AmountEntered * 0.74;
                    txt_ConvertAmount.Text = ConvertedValue.ToString();
                }
            }catch(FormatException)
            {
                txt_Amount.Text = "Invalid Amount Input";
                txt_ConvertAmount.Text = "";
            }
            try
            {
                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    ConvertedValue = AmountEntered * 81.97;
                    txt_ConvertAmount.Text = ConvertedValue.ToString();
                }
            }catch(FormatException)
            {
                txt_Amount.Text = "Invalid Amount Input";
                txt_ConvertAmount.Text = "";
            }
            try
            {
                if (rdb_MalaysianRinggit.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    ConvertedValue = AmountEntered * 81.97;
                    txt_ConvertAmount.Text = ConvertedValue.ToString();
                }
            }
            catch (FormatException)
            {
                txt_Amount.Text = "Invalid Amount Input";
                txt_ConvertAmount.Text = "";
            }
        }
    }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_ConvertAmount.Clear();
        }
    }
}
