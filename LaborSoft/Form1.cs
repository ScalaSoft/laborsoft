using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LaborSoft
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        Form5 frm5;
        Form6 frm6;
        Form7 frm7;
        Form8 frm8;
        Form9 frm9;
        SQLiteConnection myConn;


        public Form1()
        {
            InitializeComponent();
            setFormsIntoTabs();
            connectoToDataBase();
        }

        private void connectoToDataBase() {
            // If the connection string is empty, use default. 
            const string filename = @"C:\Users\Álvaro\Documents\GitHub\laborsoft\LaborSoft\db.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }

        private void insertIdentificacao() {
            string myInsertQuery = "INSERT INTO identificacao(DeptNo, DName) Values(50, 'DEVELOPMENT')";
            SQLiteCommand sqCommand = new SQLiteCommand(myInsertQuery);
            sqCommand.Connection = myConn;
            myConn.Open();
        }

        private void setFormsIntoTabs()
        {
            this.frm2 = new Form2();
            this.frm2.TopLevel = false;
            this.frm2.Visible = true;
            this.frm2.FormBorderStyle = FormBorderStyle.None;
            this.frm2.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(this.frm2);

            this.frm3 = new Form3();
            this.frm3.TopLevel = false;
            this.frm3.Visible = true;
            this.frm3.FormBorderStyle = FormBorderStyle.None;
            this.frm3.Dock = DockStyle.Fill;
            tabControl1.TabPages[1].Controls.Add(this.frm3);

            this.frm4 = new Form4();
            this.frm4.TopLevel = false;
            this.frm4.Visible = true;
            this.frm4.FormBorderStyle = FormBorderStyle.None;
            this.frm4.Dock = DockStyle.Fill;
            tabControl1.TabPages[2].Controls.Add(this.frm4);

            this.frm5 = new Form5();
            this.frm5.TopLevel = false;
            this.frm5.Visible = true;
            this.frm5.FormBorderStyle = FormBorderStyle.None;
            this.frm5.Dock = DockStyle.Fill;
            tabControl1.TabPages[3].Controls.Add(this.frm5);

            this.frm6 = new Form6();
            this.frm6.TopLevel = false;
            this.frm6.Visible = true;
            this.frm6.FormBorderStyle = FormBorderStyle.None;
            this.frm6.Dock = DockStyle.Fill;
            tabControl1.TabPages[4].Controls.Add(this.frm6);

            this.frm7 = new Form7();
            this.frm7.TopLevel = false;
            this.frm7.Visible = true;
            this.frm7.FormBorderStyle = FormBorderStyle.None;
            this.frm7.Dock = DockStyle.Fill;
            tabControl1.TabPages[5].Controls.Add(this.frm7);

            this.frm8 = new Form8();
            this.frm8.TopLevel = false;
            this.frm8.Visible = true;
            this.frm8.FormBorderStyle = FormBorderStyle.None;
            this.frm8.Dock = DockStyle.Fill;
            tabControl1.TabPages[6].Controls.Add(this.frm8);

            this.frm9 = new Form9();
            this.frm9.TopLevel = false;
            this.frm9.Visible = true;
            this.frm9.FormBorderStyle = FormBorderStyle.None;
            this.frm9.Dock = DockStyle.Fill;
            tabControl1.TabPages[7].Controls.Add(this.frm9);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
