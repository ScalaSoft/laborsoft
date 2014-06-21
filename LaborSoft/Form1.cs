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
            conn();
        }

        private void conn() {
            // If the connection string is empty, use default. 
            const string filename = @"C:\Users\Álvaro\Documents\GitHub\laborsoft\LaborSoft\db.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }

        public bool insertIdentificacao() {
            try
            {
                myConn.Open();
            
                string myInsertQuery = "INSERT INTO identificacao" + 
                    "(cod_area, area, nome_subarea, renda_familiar, cadunico, numero_nis, deficiencia_mobilidade, possui_cadeirante, num_port_def, deficiente_fam, mulher_resp_fam, num_pess_fam, num_fam_dom, " +
                    "primeiro_no_domicilio, domicilio, selo_lote, setor_quadra, cep, bairro, compl_logradouro, numero_logradouro, nome_logradouro, tipo_logradouro)" +
                    "VALUES (@cod_area, @area, @nome_subarea, @renda_familiar, @cadunico," +
                    "@numero_nis, @deficiencia_mobilidade, @possui_cadeirante, @num_port_def," + 
                    "@deficiente_fam, @mulher_resp_fam, @num_pess_fam, @num_fam_dom," + 
                    " @primeiro_no_domicilio, @domicilio, @selo_lote, @setor_quadra," + 
                    " @cep, @bairro, @compl_logradouro, @numero_logradouro, @nome_logradouro," + 
                    " @tipo_logradouro)";
            
                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                cmd.Parameters.Add(new SQLiteParameter("cod_area", frm2.Cod_area.Text));
                cmd.Parameters.AddWithValue("area", frm2.Area.Text);
                cmd.Parameters.AddWithValue("nome_subarea", frm2.NomeSubarea.Text);
                cmd.Parameters.AddWithValue("renda_familiar", frm2.RendaFamiliar.Text);
                cmd.Parameters.AddWithValue("cadunico", frm2.Cadunico.Text);
                cmd.Parameters.AddWithValue("numero_nis", frm2.NumeroNIS.Text);
                cmd.Parameters.AddWithValue("deficiencia_mobilidade", frm2.DeficienteMobilidade.Text);
                cmd.Parameters.AddWithValue("possui_cadeirante", frm2.PossuiCadeirante.Text);
                cmd.Parameters.AddWithValue("num_port_def", frm2.NumeroDePortadoresDeDeficiencia.Text);
                cmd.Parameters.AddWithValue("deficiente_fam", frm2.DeficienteNaFamilia.Text);
                cmd.Parameters.AddWithValue("mulher_resp_fam", frm2.MulherResponsavel.Text);
                cmd.Parameters.AddWithValue("num_pess_fam", frm2.NumeroDePessoasNaFamilia.Text);
                cmd.Parameters.AddWithValue("num_fam_dom", frm2.NumeroDeFamiliasNoDomicilio.Text);
                cmd.Parameters.AddWithValue("primeiro_no_domicilio", frm2.PrimeiroNoDomicilio.Text);
                cmd.Parameters.AddWithValue("domicilio", frm2.Domicilio.Text);
                cmd.Parameters.AddWithValue("selo_lote", frm2.SeloLote.Text);
                cmd.Parameters.AddWithValue("setor_quadra", frm2.SetorQuadra.Text);
                cmd.Parameters.AddWithValue("cep", frm2.Cep.Text);
                cmd.Parameters.AddWithValue("bairro", frm2.Bairro.Text);
                cmd.Parameters.AddWithValue("compl_logradouro", frm2.ComplLogradouro.Text);
                cmd.Parameters.AddWithValue("numero_logradouro", frm2.NumeroLogradouro.Text);
                cmd.Parameters.AddWithValue("nome_logradouro", frm2.NomeLogradouro);
                cmd.Parameters.AddWithValue("tipo_logradouro", frm2.TipoLogradouro.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            myConn.Close();

            return true;
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
