using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCrypt
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AMIDIBOSS/EasyCryptApp");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AMIDIBOSS/EasyCryptApp/issues");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AMIDIBOSS/EasyCryptApp/issues");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encryptor.Encrypt(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encryptor.Decrypt(textBox6.Text, textBox5.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        
    }
}
