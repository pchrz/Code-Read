using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRead
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            
            display.Text = (BarCode.BarcodeConverter39.StringToBarcode(textName.Text.ToUpper(),true)); 
            display.Font = new Font("Code 3 de 9", 28);

            display2.Text = (BarCode.BarcodeConverter39.StringToBarcode(textSerial.Text.ToUpper(), true));
            display2.Font = new Font("Code 3 de 9", 28);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            display2.Text = "";
        }

        private void aBOUTSOFTWAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CodeRead" + "\u00a9" + " 2014" + "\nDeveloped By: Peter Charuza");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Model_Click(object sender, EventArgs e)
        {

        }

        private void display2_Click(object sender, EventArgs e)
        {

        }

        private void Serial_Click(object sender, EventArgs e)
        {

        }
    }
}
