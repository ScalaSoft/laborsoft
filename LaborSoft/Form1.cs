using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaborSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            setFormsIntoTabs();
        }

        private void setFormsIntoTabs()
        {
            Form2 frm2 = new Form2();
            frm2.TopLevel = false;
            frm2.Visible = true;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(frm2);

            Form3 frm3 = new Form3();
            frm3.TopLevel = false;
            frm3.Visible = true;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            tabControl1.TabPages[1].Controls.Add(frm3);

            Form4 frm4 = new Form4();
            frm4.TopLevel = false;
            frm4.Visible = true;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            tabControl1.TabPages[2].Controls.Add(frm4);

            Form5 frm5 = new Form5();
            frm5.TopLevel = false;
            frm5.Visible = true;
            frm5.FormBorderStyle = FormBorderStyle.None;
            frm5.Dock = DockStyle.Fill;
            tabControl1.TabPages[3].Controls.Add(frm5);

            Form6 frm6 = new Form6();
            frm6.TopLevel = false;
            frm6.Visible = true;
            frm6.FormBorderStyle = FormBorderStyle.None;
            frm6.Dock = DockStyle.Fill;
            tabControl1.TabPages[4].Controls.Add(frm6);

            Form7 frm7 = new Form7();
            frm7.TopLevel = false;
            frm7.Visible = true;
            frm7.FormBorderStyle = FormBorderStyle.None;
            frm7.Dock = DockStyle.Fill;
            tabControl1.TabPages[5].Controls.Add(frm7);

            Form8 frm8 = new Form8();
            frm8.TopLevel = false;
            frm8.Visible = true;
            frm8.FormBorderStyle = FormBorderStyle.None;
            frm8.Dock = DockStyle.Fill;
            tabControl1.TabPages[6].Controls.Add(frm8);

            Form9 frm9 = new Form9();
            frm9.TopLevel = false;
            frm9.Visible = true;
            frm9.FormBorderStyle = FormBorderStyle.None;
            frm9.Dock = DockStyle.Fill;
            tabControl1.TabPages[7].Controls.Add(frm9);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
