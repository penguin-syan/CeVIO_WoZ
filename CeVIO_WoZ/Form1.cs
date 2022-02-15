using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeVIO_WoZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_selfInputBox.Text);
        }

        private void edit_tab1_Click(object sender, EventArgs e)
        {
            set_tab1(!tab1_setTalkButton1.Enabled);
        }

        private void set_tab1(bool setting)
        {
            tab1_setTalkButton1.Enabled = setting;
            tab1_setTalkButton2.Enabled = setting;
            tab1_setTalkButton3.Enabled = setting;
            tab1_setTalkButton4.Enabled = setting;
            tab1_setTalkButton5.Enabled = setting;
            tab1_setTalkButton6.Enabled = setting;
            tab1_setTalkButton7.Enabled = setting;
            tab1_namebox.Enabled = !setting;
            tab1_setInputBox1.Enabled = !setting;
            tab1_setInputBox2.Enabled = !setting;
            tab1_setInputBox3.Enabled = !setting;
            tab1_setInputBox4.Enabled = !setting;
            tab1_setInputBox5.Enabled = !setting;
            tab1_setInputBox6.Enabled = !setting;
            tab1_setInputBox7.Enabled = !setting;
            tab1.Text = tab1_namebox.Text;
        }

        private void tab1_selfInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CeVIO.playCeVIO(tab1_selfInputBox.Text);
            }
            //e.Handled = true;
        }

        private void tab1_selfInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void tab1_setTalkButton1_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox1.Text);
        }

        private void tab1_setTalkButton2_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox2.Text);
        }

        private void tab1_setTalkButton3_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox3.Text);
        }

        private void tab1_setTalkButton4_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox4.Text);
        }

        private void tab1_setTalkButton5_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox5.Text);
        }

        private void tab1_setTalkButton6_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox6.Text);
        }

        private void tab1_setTalkButton7_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab1_setInputBox7.Text);
        }
    }
}
