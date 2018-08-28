using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            Application.DoEvents();

            if(CheckPreConditions())
                lblResultado.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();            
        }

        private bool CheckPreConditions()
        {
            var regex = new Regex(@"^[\d]");
            
            if(!regex.IsMatch(textBox1.Text))
            {                
                MessageBox.Show("Informe somente números nos campos", "Atenção");
                return false;
            }

            if (!regex.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Informe somente números nos campos", "Atenção");
                return false;
            }

            return true;
        }
    }
}
