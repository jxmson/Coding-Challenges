using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christmas_Gift
{
    public partial class Form1 : Form
    {
        List<string> Gifts = new List<string>();
        public Form1()
        {
            InitializeComponent();

            
        } 
        private void CategoryA()
        {
            if (radBicycle.Checked)
                Gifts.Add("Bicycle");
            else if (radBarbie.Checked)
                Gifts.Add("Barbie doll");
            else if (radPlay.Checked)
                Gifts.Add("Playstation");
        }
        private void CategoryB()
        {
            if (ChkBook.Checked && ChkLego.Checked)
            {
                Gifts.Add("Harry Potter Book");
                Gifts.Add("20 piece Lego");
            }
            else if (ChkLego.Checked && ChkVoucher.Checked)
            {
                Gifts.Add("20 piece Lego");
                Gifts.Add("Movie gift voucher for 2");
            }
            else if (ChkBook.Checked && ChkVoucher.Checked) 
            {
                Gifts.Add("Movie gift voucher for 2");
                Gifts.Add("Harry Potter Book");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Oops, You forgot to give us your name!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ChkBook.Checked && ChkLego.Checked && ChkVoucher.Checked)
            {
                MessageBox.Show("Sorry, you can only pick two gifts from Category B.", "Too many picks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CategoryA();
                CategoryB();

                string Message = "Dear Father Christmas\n\nIf you can spare the change, I would dearly like to have the following for this Christmas:\n\n";
                foreach (string s in Gifts)
                    Message += s + "\n";

                Message += "\n\nYours lovingly\n\n" + txtName.Text;

                MessageBox.Show(Message, "Christmas Gift", MessageBoxButtons.OK);
            }
        }
    }
}
