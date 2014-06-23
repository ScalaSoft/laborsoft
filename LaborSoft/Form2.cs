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
    public partial class Form2 : Form
    {
        SQLiteConnection myConn;
        
        public Form2()
        {
            InitializeComponent();
            conn();
        }

        private void conn()
        {
            // If the connection string is empty, use default. 
            const string filename = @"C:\Users\Álvaro\Documents\GitHub\laborsoft\LaborSoft\db.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }
        
        public bool insertIdentificacao()
        {
            try
            {
                myConn.Open();

                string myInsertQuery = "INSERT INTO identificacao" +
                    "(cod_area, area, nome_subarea, renda_familiar, cadunico, numero_nis, deficiencia_mobilidade, possui_cadeirante, num_port_def, deficiente_fam, mulher_resp_fam, num_pess_fam, num_fam_dom, " +
                    "primeiro_no_domicilio, domicilio, selo_lote, setor_quadra, cep, bairro, compl_logradouro, numero_logradouro, nome_logradouro, tipo_logradouro, complemento, nome_entrevistado)" +
                    "VALUES (@cod_area, @area, @nome_subarea, @renda_familiar, @cadunico," +
                    "@numero_nis, @deficiencia_mobilidade, @possui_cadeirante, @num_port_def," +
                    "@deficiente_fam, @mulher_resp_fam, @num_pess_fam, @num_fam_dom," +
                    " @primeiro_no_domicilio, @domicilio, @selo_lote, @setor_quadra," +
                    " @cep, @bairro, @compl_logradouro, @numero_logradouro, @nome_logradouro," +
                    " @tipo_logradouro, @complemento, @nome_entrevistado)";

                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                cmd.Parameters.Add(new SQLiteParameter("cod_area", this.cod_area.Text));
                cmd.Parameters.AddWithValue("area", this.Area.Text);
                cmd.Parameters.AddWithValue("nome_subarea", this.NomeSubarea.Text);
                cmd.Parameters.AddWithValue("renda_familiar", this.RendaFamiliar.Text);
                cmd.Parameters.AddWithValue("cadunico", this.Cadunico.Checked);
                cmd.Parameters.AddWithValue("numero_nis", this.NumeroNIS.Text);
                cmd.Parameters.AddWithValue("deficiencia_mobilidade", this.DeficienteMobilidade.Checked);
                cmd.Parameters.AddWithValue("possui_cadeirante", this.PossuiCadeirante.Checked);
                cmd.Parameters.AddWithValue("num_port_def", this.NumeroDePortadoresDeDeficiencia.Text);
                cmd.Parameters.AddWithValue("deficiente_fam", this.DeficienteNaFamilia.Checked);
                cmd.Parameters.AddWithValue("mulher_resp_fam", this.MulherResponsavel.Text);
                cmd.Parameters.AddWithValue("num_pess_fam", this.NumeroDePessoasNaFamilia.Text);
                cmd.Parameters.AddWithValue("num_fam_dom", this.NumeroDeFamiliasNoDomicilio.Text);
                cmd.Parameters.AddWithValue("primeiro_no_domicilio", this.PrimeiroNoDomicilio.Text);
                cmd.Parameters.AddWithValue("domicilio", this.Domicilio.Text);
                cmd.Parameters.AddWithValue("selo_lote", this.SeloLote.Text);
                cmd.Parameters.AddWithValue("setor_quadra", this.SetorQuadra.Text);
                cmd.Parameters.AddWithValue("cep", this.Cep.Text);
                cmd.Parameters.AddWithValue("bairro", this.Bairro.Text);
                cmd.Parameters.AddWithValue("compl_logradouro", this.ComplLogradouro.Text);
                cmd.Parameters.AddWithValue("numero_logradouro", this.NumeroLogradouro.Text);
                cmd.Parameters.AddWithValue("nome_logradouro", this.NomeLogradouro.Text.ToString());
                cmd.Parameters.AddWithValue("tipo_logradouro", this.TipoLogradouro.Text);
                cmd.Parameters.AddWithValue("complemento", this.Complemento.Text);
                cmd.Parameters.AddWithValue("nome_entrevistado", this.NomeDoEntrevistado.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            myConn.Close();

            return true;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cod_area_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        public TextBox Cod_area
        {
          get { return cod_area; }
          set { cod_area = value; }
        }

        public ComboBox Area
        {
          get { return area; }
          set { area = value; }
        }

        public TextBox NomeSubarea 
        {
            get { return nome_subarea; }
            set { nome_subarea = value; }
        }

        public TextBox TipoLogradouro
        {
            get { return tipo_logradouro; }
            set { tipo_logradouro = value; }
        }

        public TextBox NomeLogradouro
        {
            get { return nome_logradouro; }
            set { nome_logradouro = value; }
        }

        public TextBox NumeroLogradouro
        {
            get { return numero_logradouro; }
            set { numero_logradouro = value; }
        }

        public TextBox ComplLogradouro
        {
            get { return compl_logradouro; }
            set { compl_logradouro = value; }
        }

        public TextBox Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public TextBox Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public TextBox SetorQuadra
        {
            get { return setor_quadra; }
            set { setor_quadra = value; }
        }

        public TextBox SeloLote
        {
            get { return selo_lote; }
            set { selo_lote = value; }
        }

        public TextBox Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public ComboBox PrimeiroNoDomicilio
        {
            get { return primeiro_no_domicilio; }
            set { primeiro_no_domicilio = value; }
        }

        public TextBox NumeroDeFamiliasNoDomicilio
        {
            get { return num_fam_dom; }
            set { num_fam_dom = value; }
        }

        public TextBox NumeroDePessoasNaFamilia
        {
            get { return num_pess_fam; }
            set { num_pess_fam = value; }
        }

        public ComboBox MulherResponsavel
        {
            get { return mulher_resp_fam; }
            set { mulher_resp_fam = value; }
        }

        public CheckBox DeficienteNaFamilia
        {
            get { return desficiente_fam; }
            set { desficiente_fam = value; }
        }

        public TextBox NumeroDePortadoresDeDeficiencia
        {
            get { return num_port_def; }
            set { num_port_def = value; }
        }

        public CheckBox PossuiCadeirante
        {
            get { return possui_cadeirante; }
            set { possui_cadeirante = value; }
        }

        public CheckBox DeficienteMobilidade
        {
            get { return deficiencia_mobilidade; }
            set { deficiencia_mobilidade = value; }
        }

        public CheckBox Cadunico
        {
            get { return cadunico; }
            set { cadunico = value; }
        }

        public TextBox NumeroNIS
        {
            get { return numero_nis; }
            set { numero_nis = value; }
        }

        public TextBox RendaFamiliar
        {
            get { return renda_familiar; }
            set { renda_familiar = value; }
        }

        public TextBox Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public TextBox NomeDoEntrevistado
        {
            get { return nome_entrevistado; }
            set { nome_entrevistado = value; }
        }
    }
}
