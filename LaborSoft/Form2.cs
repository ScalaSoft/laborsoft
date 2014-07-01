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
        Utilities util = new Utilities();
        
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

        private void openConn() {
            if (myConn.State.ToString() == "Closed")
            {
                this.myConn.Open();
            }
        }

        public bool insertIdentificacao(int? Cod)
        {
            string cpf = this.util.getCpfToNomeEntrevistadoFromIdentificacao(this.nome_entrevistado.Text);
            int check_entrevistado = this.util.checkIfCpfExist(cpf, "dados_responsavel_familiar");
            
            if (check_entrevistado == 0 && Cod != null)
            {
                
                try
                {
                    openConn();

                    string myInsertQuery = "INSERT INTO identificacao" +
                        "(id, cod_area, area, nome_subarea, renda_familiar, cadunico, numero_nis, deficiencia_mobilidade, possui_cadeirante, num_port_def, deficiente_fam, mulher_resp_fam, num_pess_fam, num_fam_dom, " +
                        "primeiro_no_domicilio, domicilio, selo_lote, setor_quadra, cep, bairro, compl_logradouro, numero_logradouro, nome_logradouro, tipo_logradouro, complemento, nome_entrevistado)" +
                        "VALUES ("+(int)Cod+", @cod_area, @area, @nome_subarea, @renda_familiar, @cadunico," +
                        "@numero_nis, @deficiencia_mobilidade, @possui_cadeirante, @num_port_def," +
                        "@deficiente_fam, @mulher_resp_fam, @num_pess_fam, @num_fam_dom," +
                        " @primeiro_no_domicilio, @domicilio, @selo_lote, @setor_quadra," +
                        " @cep, @bairro, @compl_logradouro, @numero_logradouro, @nome_logradouro," +
                        " @tipo_logradouro, @complemento, @nome_entrevistado)";

                    SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                    cmd.Parameters.AddWithValue("id", Cod);
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
                    cmd.Parameters.AddWithValue("nome_logradouro", this.NomeLogradouro.Text);
                    cmd.Parameters.AddWithValue("tipo_logradouro", this.TipoLogradouro.Text);
                    cmd.Parameters.AddWithValue("complemento", this.Complemento.Text);
                    cmd.Parameters.AddWithValue("nome_entrevistado", this.NomeDoEntrevistado.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else {
                updateIdentificacao(check_entrevistado);
            }

            myConn.Close();

            return true;
        }

        public bool updateIdentificacao(int? code)
        {
            try
            {
                openConn();

                string myUpdateQuery = "UPDATE identificacao SET " +
                    "cod_area = '"+this.cod_area.Text+"', " +
                    "area  = '"+this.area.Text+"', " +
                    "nome_subarea= '"+this.nome_subarea.Text+"', " +
                    "renda_familiar= '"+this.renda_familiar.Text+"', " +
                    "cadunico= '"+this.util.SQLiteConvertToBool(this.cadunico.Checked)+"', " +
                    "numero_nis= '"+this.numero_nis.Text+"', " +
                    "deficiencia_mobilidade= '"+this.util.SQLiteConvertToBool(this.deficiencia_mobilidade.Checked)+"', " +
                    "possui_cadeirante= '"+this.util.SQLiteConvertToBool(this.possui_cadeirante.Checked)+"', " +
                    "num_port_def= '"+this.num_port_def.Text+"', " +
                    "deficiente_fam= '"+this.util.SQLiteConvertToBool(this.deficiente_fam.Checked)+"', " +
                    "mulher_resp_fam= '"+this.mulher_resp_fam.SelectedIndex+"', " +
                    "num_pess_fam= '"+this.num_pess_fam.Text+"', " +
                    "num_fam_dom= '"+this.num_fam_dom.Text+"', " +
                    "primeiro_no_domicilio= '"+this.primeiro_no_domicilio.Text+"', " +
                    "domicilio= '"+this.domicilio.Text+"', " +
                    "selo_lote= '"+this.selo_lote.Text+"', " +
                    "setor_quadra= '"+this.setor_quadra.Text+"', " +
                    "cep= '"+this.cep.Text+"', " +
                    "bairro= '"+this.bairro.Text+"', " +
                    "compl_logradouro= '"+this.compl_logradouro.Text+"', " +
                    "numero_logradouro= '"+this.numero_logradouro.Text+"', " +
                    "nome_logradouro= '"+this.nome_logradouro.Text+"', " +
                    "tipo_logradouro= '"+this.tipo_logradouro.Text+"', " +
                    "complemento= '"+this.complemento.Text+"', " +
                    "nome_entrevistado = '"+this.nome_entrevistado.Text+"' "+
                    "WHERE id = '"+code+"';";

                SQLiteCommand cmd = new SQLiteCommand(myUpdateQuery, myConn);
               
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            myConn.Close();

            return true;
        }

        public void populateForm(int? Cod) {

            openConn();

            string mySelectQuery = "SELECT * FROM identificacao WHERE id = '"+Cod+"';";

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            while (dr.Read())
            {
                this.cod_area.Text = dr["cod_area"].ToString();
                this.Area.Text = dr["area"].ToString();
                this.NomeSubarea.Text = dr["nome_subarea"].ToString(); 
                this.RendaFamiliar.Text = dr["renda_familiar"].ToString();
                this.Cadunico.Checked = Convert.ToBoolean(dr["cadunico"].ToString());
                this.NumeroNIS.Text = dr["numero_nis"].ToString();
                MessageBox.Show(dr["deficiencia_mobilidade"].ToString());
                this.DeficienteMobilidade.Checked = Convert.ToBoolean(dr["deficiencia_mobilidade"].ToString());
                this.PossuiCadeirante.Checked = Convert.ToBoolean(dr["possui_cadeirante"].ToString());
                this.NumeroDePortadoresDeDeficiencia.Text = dr["num_port_def"].ToString();
                this.DeficienteNaFamilia.Checked = Convert.ToBoolean(dr["deficiente_fam"].ToString());
                this.MulherResponsavel.Text = selectCheckBoxValue(Convert.ToBoolean(dr["mulher_resp_fam"].ToString()));
                this.NumeroDePessoasNaFamilia.Text = dr["num_pess_fam"].ToString();
                this.NumeroDeFamiliasNoDomicilio.Text = dr["num_fam_dom"].ToString();
                this.PrimeiroNoDomicilio.Text = dr["primeiro_no_domicilio"].ToString();
                this.Domicilio.Text = dr["domicilio"].ToString();
                this.SeloLote.Text = dr["selo_lote"].ToString();
                this.SetorQuadra.Text = dr["setor_quadra"].ToString();
                this.Cep.Text = dr["cep"].ToString();
                this.Bairro.Text = dr["bairro"].ToString();
                this.ComplLogradouro.Text = dr["compl_logradouro"].ToString(); 
                this.NumeroLogradouro.Text = dr["numero_logradouro"].ToString();
                this.NomeLogradouro.Text = dr["nome_logradouro"].ToString();
                this.TipoLogradouro.Text = dr["tipo_logradouro"].ToString();
                this.Complemento.Text = dr["complemento"].ToString();
                this.NomeDoEntrevistado.Text = dr["nome_entrevistado"].ToString();
            }

            dr.Close();
            dr.Dispose();
            cmd.Dispose();
            myConn.Close();
            
        }

        private string selectCheckBoxValue(bool val) {
            if (val)
            {
                return Convert.ToString("Sim");
            }
            else {
                return Convert.ToString("Não");
            }
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
            get { return deficiente_fam; }
            set { deficiente_fam = value; }
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
