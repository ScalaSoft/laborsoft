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
    public partial class Form3 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form3()
        {
            InitializeComponent();
            conn();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void conn()
        {
            // If the connection string is empty, use default. 
            const string filename = @"C:\laborsoft\producao.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }

        public bool insertDadosResponsavelFamiliar(int? Cod)
        {
            if (Cod != null)
            {
                try
                {
                    myConn.Open();

                    string myInsertQuery = "INSERT INTO dados_responsavel_familiar" +
                             "(id, nome, sexo, nascimento, estado_civil, regime_casamento," +
                             "uniao_consencual, frequenta_escola, escolaridade, alfabetizado_rg,"+
                             " assina_nome, beneficiario, programa_social, valor_beneficio, profissao, renda_cidadao, " +
                             "particularidade_deficiencia, possui_laudo_med, possui_numero_cid, " +
                             "cpf, rg_rne, naturalidade, uf, org_expedidor_cpf, data_expedicao_cpf," +
                             "nome_mae, nome_pai) " +
                             "VALUES(" +
                             "'"+ Cod +"', "+
                            "'" + this.nome.Text + "', " +
                            "'" + this.sexo.Text + "', " +
                            "'" + this.nascimento.Text + "', " +
                            "'" + this.estado_civil.Text + "', " +
                            "'" + this.regime_casamento.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.uniao_consensual.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.frequentou_escola.Checked) + "', " +
                            "'" + this.escolaridade.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.alfabetizado_rg.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.assina_nome.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc.Checked) + "', " +
                            "'" + this.prog_soc_qual.Text + "', " +
                            "'" + this.valor_beneficio.Text + "', " +
                            "'" + this.profissão.Text + "', " +
                            "'" + this.renda.Text + "', " +
                            "'" + this.particularidade_deficiencia.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_laudo_medico.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_cid.Checked) + "', " +
                            "'" + this.cpf.Text + "', " +
                            "'" + this.rg_rne.Text + "', " +
                            "'" + this.naturalidade.Text + "', " +
                            "'" + this.uf.Text + "', " +
                            "'" + this.org_exp_cpf.Text + "', " +
                            "'" + this.data_exp_cpf.Text + "', " +
                            "'" + this.nome_mae.Text + "', " +
                            "'" + this.nome_pai.Text + "')";

                    SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    myConn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                updateDadosResponsavelFamiliar(Cod);
            }

            return true;
        }

        public bool updateDadosResponsavelFamiliar(int? code)
        {
            int check_cpf = util.checkIfCpfExist(this.cpf.Text, "dados_responsavel_familiar");
            if (check_cpf == 0 && code == null)
            {
                return insertDadosResponsavelFamiliar(code);
            }
            else
            {
                try
                {
                    myConn.Open();

                    string myUpdateQuery = "UPDATE dados_responsavel_familiar SET " +
                                            "nome = '" + this.nome.Text + "', " +
                                            "sexo = '" + this.sexo.Text + "', " +
                                            "nascimento = '" + this.nascimento.Text + "', " +
                                            "estado_civil = '" + this.estado_civil.Text + "', " +
                                            "regime_casamento = '" + this.regime_casamento.Text + "'," +
                                            "uniao_consencual = '" + this.util.SQLiteConvertToBool(this.uniao_consensual.Checked) + "', " +
                                            "frequenta_escola = '" + this.util.SQLiteConvertToBool(this.frequentou_escola.Checked) + "', " +
                                            "escolaridade = '" + this.escolaridade.Text + "', " +
                                            "assina_nome = '" + this.util.SQLiteConvertToBool(this.assina_nome.Checked) + "', " +
                                            "alfabetizado_rg = '" + this.util.SQLiteConvertToBool(this.alfabetizado_rg.Checked) + "', " +
                                            "beneficiario = '" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc.Checked) + "', " +
                                            "programa_social  = '" + this.prog_soc_qual.Text + "', " +
                                            "valor_beneficio = '" + this.valor_beneficio.Text + "', " +
                                            "profissao = '" + this.profissão.Text + "', " +
                                            "renda_cidadao = '" + this.renda.Text + "', " +
                                            "particularidade_deficiencia = '" + this.particularidade_deficiencia.Text + "', " +
                                            "possui_laudo_med = '" + this.util.SQLiteConvertToBool(this.possui_laudo_medico.Checked) + "', " +
                                            "possui_numero_cid = '" + this.util.SQLiteConvertToBool(this.possui_cid.Checked) + "', " +
                                            "cpf = '" + this.cpf.Text + "', " +
                                            "rg_rne = '" + this.rg_rne.Text + "', " +
                                            "naturalidade = '" + this.naturalidade.Text + "', " +
                                            "uf = '" + this.uf.Text + "', " +
                                            "org_expedidor_cpf = '" + this.org_exp_cpf.Text + "', " +
                                            "data_expedicao_cpf = '" + this.data_exp_cpf.Text + "'," +
                                            "nome_mae = '" + this.nome_mae.Text + "', " +
                                            "nome_pai = '" + this.nome_pai.Text + "' " +
                                            "WHERE id = '" + code + "'";

                    SQLiteCommand cmd = new SQLiteCommand(myUpdateQuery, myConn);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    myConn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return true;
        }

        public void populateForm(int? Cod)
        {
            myConn.Open();

            string mySelectQuery = "SELECT * FROM dados_responsavel_familiar WHERE id = '" + Cod + "';";

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.nome.Text = dr["nome"].ToString(); 
                this.sexo.Text = dr["sexo"].ToString();
                this.nascimento.Text = dr["nascimento"].ToString();
                this.estado_civil.Text = dr["estado_civil"].ToString();
                this.regime_casamento.Text = dr["regime_casamento"].ToString();
                this.uniao_consensual.Checked = Convert.ToBoolean(dr["uniao_consencual"]);
                this.frequentou_escola.Checked = Convert.ToBoolean(dr["frequenta_escola"]); 
                this.escolaridade.Text = dr["escolaridade"].ToString();
                this.assina_nome.Checked = Convert.ToBoolean(dr["assina_nome"]);
                this.alfabetizado_rg.Checked = Convert.ToBoolean(dr["alfabetizado_rg"]);
                this.beneficiario_prog_soc.Checked = Convert.ToBoolean(dr["beneficiario"]);
                this.prog_soc_qual.Text = dr["programa_social"].ToString(); 
                this.valor_beneficio.Text = dr["valor_beneficio"].ToString();
                this.profissão.Text = dr["profissao"].ToString();
                this.renda.Text = dr["renda_cidadao"].ToString();
                this.particularidade_deficiencia.Text = dr["particularidade_deficiencia"].ToString();
                this.possui_laudo_medico.Checked = Convert.ToBoolean(dr["possui_laudo_med"]);
                this.possui_cid.Checked = Convert.ToBoolean(dr["possui_numero_cid"]);
                this.cpf.Text = dr["cpf"].ToString();
                this.rg_rne.Text = dr["rg_rne"].ToString();
                this.naturalidade.Text = dr["naturalidade"].ToString();
                this.uf.Text = dr["uf"].ToString();
                this.org_exp_cpf.Text = dr["org_expedidor_cpf"].ToString();
                this.data_exp_cpf.Text =dr["data_expedicao_cpf"].ToString();
                this.nome_mae.Text = dr["nome_mae"].ToString();
                this.nome_pai.Text =dr["nome_pai"].ToString();
            }

            dr.Close();
            cmd.Dispose();
            myConn.Close();
        }

        public MaskedTextBox Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public bool validate()
        {
            if (this.cpf.MaskFull == false)
            {
                MessageBox.Show("Você não pode salvar sem preencher o campo (CPF): Dados do Entrevistado");
                return false;
            }
            return true;
        }

    }
}
