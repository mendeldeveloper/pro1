using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Введи пароль";
            textBox1.Text = null;
            textBox1.TabIndex = 0;
            textBox1.PasswordChar = '*';
            textBox1.Font = new Font("Courier New", 10.0F);
            label1.Text = String.Empty;
            label1.Font = new Font("Courier New", 10.0F);
            
        }
    }
}
