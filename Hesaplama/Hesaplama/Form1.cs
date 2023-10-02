using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alisfiyati, satisfiyati, toplamkar;

            alisfiyati= Convert.ToDouble(txtAlisfiyati.Text);
            satisfiyati = Convert.ToDouble(txtSatisfiyati.Text);

            toplamkar = satisfiyati - alisfiyati;

            lblToplamkar.Text ="Toplam Kar: " + toplamkar.ToString();

                
        }
    }
}
