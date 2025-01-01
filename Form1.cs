using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPA_Zkouska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            TextBoxMolarAmount.Text = ChemMath.ToMolarAmount(double.Parse(textBoxWeight.Text), double.Parse(textBoxMolarWeight.Text)).ToString();
        }
    }
}
