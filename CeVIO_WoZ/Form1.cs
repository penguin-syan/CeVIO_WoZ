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

        /*
         * ***** tab1 ****** 
         */

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
                tab1_selfInputBox.Text = "";
            }
        }

        private void tab1_selfInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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

        /*
         * ***** tab2 *****
         */

        private void edit_tab2_Click(object sender, EventArgs e)
        {
            set_tab2(!tab2_setTalkButton1.Enabled);
        }

        private void set_tab2(bool setting)
        {
            tab2_setTalkButton1.Enabled = setting;
            tab2_setTalkButton2.Enabled = setting;
            tab2_setTalkButton3.Enabled = setting;
            tab2_setTalkButton4.Enabled = setting;
            tab2_setTalkButton5.Enabled = setting;
            tab2_setTalkButton6.Enabled = setting;
            tab2_setTalkButton7.Enabled = setting;
            tab2_namebox.Enabled = !setting;
            tab2_setInputBox1.Enabled = !setting;
            tab2_setInputBox2.Enabled = !setting;
            tab2_setInputBox3.Enabled = !setting;
            tab2_setInputBox4.Enabled = !setting;
            tab2_setInputBox5.Enabled = !setting;
            tab2_setInputBox6.Enabled = !setting;
            tab2_setInputBox7.Enabled = !setting;
            tab2.Text = tab2_namebox.Text;
        }

        private void tab2_selfInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void tab2_setTalkButton1_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox1.Text);
        }

        private void tab2_setTalkButton2_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox2.Text);
        }

        private void tab2_setTalkButton3_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox3.Text);
        }

        private void tab2_setTalkButton4_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox4.Text);
        }

        private void tab2_setTalkButton5_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox5.Text);
        }

        private void tab2_setTalkButton6_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox6.Text);
        }

        private void tab2_setTalkButton7_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab2_setInputBox7.Text);
        }

        /*
         * ***** tab3 *****
         */
        private void edit_tab3_Click(object sender, EventArgs e)
        {
            set_tab3(!tab3_setTalkButton1.Enabled);
        }

        private void set_tab3(bool setting)
        {
            tab3_setTalkButton1.Enabled = setting;
            tab3_setTalkButton2.Enabled = setting;
            tab3_setTalkButton2.Enabled = setting;
            tab3_setTalkButton3.Enabled = setting;
            tab3_setTalkButton4.Enabled = setting;
            tab3_setTalkButton5.Enabled = setting;
            tab3_setTalkButton6.Enabled = setting;
            tab3_setTalkButton7.Enabled = setting;
            tab3_namebox.Enabled = !setting;
            tab3_setInputBox1.Enabled = !setting;
            tab3_setInputBox2.Enabled = !setting;
            tab3_setInputBox3.Enabled = !setting;
            tab3_setInputBox4.Enabled = !setting;
            tab3_setInputBox5.Enabled = !setting;
            tab3_setInputBox6.Enabled = !setting;
            tab3_setInputBox7.Enabled = !setting;
            tab3.Text = tab3_namebox.Text;
        }

        private void tab3_selfInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void tab3_setTalkButton1_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox1.Text);
        }

        private void tab3_setTalkButton2_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox2.Text);
        }

        private void tab3_setTalkButton3_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox3.Text);
        }

        private void tab3_setTalkButton4_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox4.Text);
        }

        private void tab3_setTalkButton5_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox5.Text);
        }

        private void tab3_setTalkButton6_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox6.Text);
        }

        private void tab3_setTalkButton7_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab3_setInputBox7.Text);
        }

        /*
         * ***** tab4 *****
         */

        private void edit_tab4_Click(object sender, EventArgs e)
        {
            set_tab4(!tab4_setInputBox1.Enabled);
        }

        private void set_tab4(bool setting)
        {
            tab4_setInputBox1.Enabled = setting;
            tab4_setInputBox2.Enabled = setting;
            tab4_setInputBox3.Enabled = setting;
            tab4_setInputBox4.Enabled = setting;
            tab4_setInputBox5.Enabled = setting;
            tab4_setInputBox6.Enabled = setting;
            tab4_setInputBox7.Enabled = setting;
            tab4_namebox.Enabled = !setting;
            tab4_setTalkButton1.Enabled = !setting;
            tab4_setTalkButton2.Enabled = !setting;
            tab4_setTalkButton3.Enabled = !setting;
            tab4_setTalkButton4.Enabled = !setting;
            tab4_setTalkButton5.Enabled = !setting;
            tab4_setTalkButton6.Enabled = !setting;
            tab4_setTalkButton7.Enabled = !setting;
            tab4.Text = tab4_namebox.Text;
        }

        private void tab4_selfInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void tab4_setTalkButton1_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox1.Text);
        }

        private void tab4_setTalkButton2_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox2.Text);
        }

        private void tab4_setTalkButton3_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox3.Text);
        }

        private void tab4_setTalkButton4_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox4.Text);
        }

        private void tab4_setTalkButton5_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox5.Text);
        }

        private void tab4_setTalkButton6_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox6.Text);
        }

        private void tab4_setTalkButton7_Click(object sender, EventArgs e)
        {
            CeVIO.playCeVIO(tab4_setInputBox7.Text);
        }
    }
}
