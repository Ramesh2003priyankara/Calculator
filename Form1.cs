using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class Calculator : Form
    {
        int n1, n2,ans;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            n1 =int.Parse(txtn1.Text);
            n2 =int.Parse(txtn2.Text);

            ans = n1 + n2;

            txtans.Text = ans.ToString();
        }

        private void btnReduction_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);

            ans = n1 - n2;

            txtans.Text = ans.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);

            ans = n1 / n2;

            txtans.Text = ans.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);

            ans = n1 * n2;

            txtans.Text = ans.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtans.Clear();
            txtn1.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
