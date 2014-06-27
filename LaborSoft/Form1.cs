﻿using System;
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
        int? code;
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
            conn();
        }

        private void conn() {
            // If the connection string is empty, use default. 
            const string filename = @"C:\Users\Álvaro\Documents\GitHub\laborsoft\LaborSoft\db.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.code != 0)
            {
                if (this.frm2.updateIdentificacao(this.code) &&
                    this.frm3.updateDadosResponsavelFamiliar(this.code) &&
                    this.frm4.updateDadosConjuge(this.code) &&
                    this.frm5.updateComposicaoFamiliar(this.code))
                {
                    MessageBox.Show("Atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao tentar atualizar.");
                }
            }
            else {
                if (this.frm2.insertIdentificacao() &&
                    this.frm3.insertDadosResponsavelFamiliar() &&
                    this.frm4.insertDadosConjuge() &&
                    this.frm5.insertComposicaoFamiliar(null))
                {
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro!!!");
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string word = this.nome_rg_cpf.Text;
            
            myConn.Open();

            string myInsertQuery = "SELECT i.id as code FROM identificacao i " +
                "LEFT JOIN dados_responsavel_familiar drf on (drf.id = i.id) " +
                "WHERE i.nome_entrevistado LIKE '%" + Nome_rg_cpf.Text + "%' " +
                "OR drf.cpf = '" + Nome_rg_cpf.Text + "'" +
                "OR drf.rg_rne = '" + Nome_rg_cpf.Text + "' ";

            if (Quadra_selo.Text != null)
            {
                myInsertQuery = myInsertQuery + "AND i.setor_quadra = '" + Quadra_selo.Text + "' " +
                    "AND i.selo_lote = '" + Quadra_selo.Text + "'";
            }

            myInsertQuery = myInsertQuery + ";";

            SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.code =  Convert.ToInt32(dr["code"]);
                this.frm2.populateForm(this.code);
                this.frm3.populateForm(this.code);
                this.frm4.populateForm(this.code);
                this.frm5.populateForm(this.code);
            }
            dr.Close();
            myConn.Close();
        }

        public TextBox Nome_rg_cpf
        {
            get { return nome_rg_cpf; }
            set { nome_rg_cpf = value; }
        }

        public TextBox Quadra_selo
        {
            get { return quadra_selo; }
            set { quadra_selo = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.code = null;
            Utilities.ResetAllControls(this);
            Utilities.ResetAllControls(this.frm2);
            Utilities.ResetAllControls(this.frm3);
            Utilities.ResetAllControls(this.frm4);
            Utilities.ResetAllControls(this.frm5);
            Utilities.ResetAllControls(this.frm6);
            Utilities.ResetAllControls(this.frm7);
            Utilities.ResetAllControls(this.frm8);
            Utilities.ResetAllControls(this.frm9);
        }
    }
}
