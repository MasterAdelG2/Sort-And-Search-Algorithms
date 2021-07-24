using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox1.Text, out Form1.key))
                MessageBox.Show("Wrong Input.. please Try Again.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                if (!Int32.TryParse(textBox1.Text, out Form1.key))
                    MessageBox.Show("Wrong Input.. please Try Again.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.Close();
            }
        }
    }
}
