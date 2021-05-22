using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpetQuotes
{
    public partial class frmQuotes : Form
    {
        public frmQuotes()
        {
            InitializeComponent();         

        }

        private void frmQuotes_Load(object sender, EventArgs e)
        {
            cmbCarpet.SelectedIndex = cmbCarpet.Items.Add("Type A (R120 /m^2)");
            cmbCarpet.Items.Add("Type B (R110 /m^2)");
            cmbCarpet.Items.Add("Type C (R100 /m^2)");
            cmbCarpet.Items.Add("Type D (R90 /m^2)");
            cmbCarpet.Items.Add("Type E (R80 /m^2)");
            cmbCarpet.Items.Add("Type F (R70 /m^2)");
            cmbCarpet.Items.Add("Type G (R60 /m^2)");          
        }
        double Area(double a, double b)
        {
            return a * b;
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            double l = double.Parse(txtLength.Text);
            double w = double.Parse(txtWidth.Text);

            double price = 0;

            if ((string)cmbCarpet.SelectedItem == "Type A (R120 /m^2)")
                price = Area(l, w) * 120;
            else if ((string)cmbCarpet.SelectedItem == "Type B (R110 /m^2)")
                price = Area(l, w) * 110;
            else if ((string)cmbCarpet.SelectedItem == "Type C (R100 /m^2)")
                price = Area(l, w) * 100;
            else if ((string)cmbCarpet.SelectedItem == "Type D (R90 /m^2)")
                price = Area(l, w) * 90;
            else if ((string)cmbCarpet.SelectedItem == "Type E (R80 /m^2)")
                price = Area(l, w) * 80;
            else if ((string)cmbCarpet.SelectedItem == "Type F (R70 /m^2)")
                price = Area(l, w) * 70;
            else if ((string)cmbCarpet.SelectedItem == "Type G (R60 /m^2)")
                price = Area(l, w) * 60;
           
            MessageBox.Show("The price quoted for a carpet " + txtLength.Text + "m by " + txtWidth.Text + "m = R" + price.ToString(),"Carpet Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
