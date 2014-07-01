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
    public partial class Form4 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form4()
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

        private void openConn()
        {
            if (myConn.State.ToString() == "Closed")
            {
                conn();
                this.myConn.Open();
            }
        }

        public bool insertDadosConjuge(int? Cod)
        {
            int check_cpf = this.util.checkIfCpfExist(this.cpf.Text, "dados_conjuge");

            if (Cod == null) {
                Cod = this.util.getNextCode();
            }
            
            if (check_cpf == 0 && Cod != null)
            {
                try
                {
                    openConn();

                    string myInsertQuery = "INSERT INTO dados_conjuge" +
                             " (id, nome, sexo, relacao_resp_fam, nascimento, naturalidade," +
                             " uf, cpf, rg_rne, org_exp_cpf, data_exp_cpf, estado_civil, " +
                             "regime_casamento, uniao_consensual, frequentou_escola, " +
                             "escolaridade, alfabetizado_rg, assina_nome, profissao, renda," +
                             " beneficiario_prog_soc, prog_soc_qual, valor_beneficio, " +
                             "particularidade_deficiencia, possui_laudo_medico, possui_cid, " +
                             "nome_mae, nome_pai)" +
                             "VALUES(" +
                             "'" + Cod + "', " +
                             "'" + this.nome.Text + "', " +
                             "'" + this.relacao_resp_fam.Text + "', " +
                             "'" + this.sexo.Text + "', " +
                             "'" + this.nascimento.Text + "', " +
                             "'" + this.naturalidade.Text + "', " +
                             "'" + this.uf.Text + "', " +
                             "'" + this.cpf.Text + "', " +
                             "'" + this.rg_rne.Text + "', " +
                             "'" + this.org_exp_cpf.Text + "', " +
                             "'" + this.data_exp_cpf.Text + "', " +
                             "'" + this.estado_civil.Text + "', " +
                             "'" + this.regime_casamento.Text + "', " +
                             "'" + this.uniao_consensual.Checked + "', " +
                             "'" + this.frequentou_escola.Checked + "', " +
                             "'" + this.escolaridade.Text + "', " +
                             "'" + this.alfabetizado_rg.Text + "', " +
                             "'" + this.assina_nome.Text + "', " +
                             "'" + this.profissao.Text + "', " +
                             "'" + this.renda.Text + "', " +
                             "'" + this.beneficiario_prog_soc.Checked + "', " +
                             "'" + this.prog_soc_qual.Text + "', " +
                             "'" + this.valor_beneficio.Text + "', " +
                             "'" + this.particularidade_deficiencia.Text + "', " +
                             "'" + this.possui_laudo_medico.Checked + "', " +
                             "'" + this.possui_cid.Checked + "', " +
                             "'" + this.nome_mae.Text + "', " +
                             "'" + this.nome_pai.Text + "')";

                    SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else {
                updateDadosConjuge(check_cpf);
            }
            myConn.Close();

            return true;
        }

        public bool updateDadosConjuge(int? code)
        {
            if (code == null)
            {
                int check_cpf = this.util.checkIfCpfExist(this.cpf.Text, "dados_conjuge");
                if (check_cpf == 0)
                {
                    return insertDadosConjuge(null);
                }
            }
            else
            {
                try
                {
                    openConn();

                    string myInsertQuery = "UPDATE dados_conjuge SET " +
                                            "nome = '" + this.nome.Text + "', " +
                                            "relacao_resp_fam = '" + this.relacao_resp_fam.Text + "', " +
                                            "sexo = '" + this.sexo.Text + "', " +
                                            "nascimento = '" + this.nascimento.Text + "', " +
                                            "naturalidade = '" + this.naturalidade.Text + "', " +
                                            "uf = '" + this.uf.Text + "', " +
                                            "estado_civil = '" + this.estado_civil.Text + "', " +
                                            "regime_casamento = '" + this.regime_casamento.Text + "'," +
                                            "uniao_consensual = '" + this.uniao_consensual.Checked + "', " +
                                            "frequentou_escola = '" + this.frequentou_escola.Checked + "', " +
                                            "escolaridade = '" + this.escolaridade.Text + "', " +
                                            "assina_nome = '" + this.assina_nome.Text + "', " +
                                            "alfabetizado_rg = '" + this.alfabetizado_rg.Text + "', " +
                                            "beneficiario_prog_soc = '" + this.beneficiario_prog_soc.Checked + "', " +
                                            "prog_soc_qual  = '" + this.prog_soc_qual.Text + "', " +
                                            "valor_beneficio = '" + this.valor_beneficio.Text + "', " +
                                            "profissao = '" + this.profissao.Text + "', " +
                                            "renda = '" + this.renda.Text + "', " +
                                            "particularidade_deficiencia = '" + this.particularidade_deficiencia.Text + "', " +
                                            "possui_laudo_medico = '" + this.possui_laudo_medico.Checked + "', " +
                                            "possui_cid = '" + this.possui_cid.Checked + "', " +
                                            "cpf = '" + this.cpf.Text + "', " +
                                            "rg_rne = '" + this.rg_rne.Text + "', " +
                                            "org_expedidor_cpf = '" + this.org_exp_cpf.Text + "', " +
                                            "data_expedicao_cpf = '" + this.data_exp_cpf.Text + "'," +
                                            "nome_mae = '" + this.nome_mae.Text + "', " +
                                            "nome_pai = '" + this.nome_pai.Text + "' " +
                                            "WHERE id = '" + code + "'";

                    SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            myConn.Close();

            return true;
        }

        public void populateForm(int? Cod)
        {
            myConn.Open();

            string mySelectQuery = "SELECT * FROM dados_conjuge WHERE id = '" + Cod + "';";

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.nome.Text = dr["nome"].ToString();
                this.relacao_resp_fam.Text = dr["relacao_resp_fam"].ToString();
                this.sexo.Text = dr["sexo"].ToString();
                this.nascimento.Text = dr["nascimento"].ToString();
                this.naturalidade.Text = dr["naturalidade"].ToString();
                this.uf.Text = dr["uf"].ToString();
                this.estado_civil.Text = dr["estado_civil"].ToString();
                this.regime_casamento.Text = dr["regime_casamento"].ToString();
                this.uniao_consensual.Checked = Convert.ToBoolean(dr["uniao_consensual"]);
                this.frequentou_escola.Checked = Convert.ToBoolean(dr["frequentou_escola"]);
                this.escolaridade.Text = dr["escolaridade"].ToString();
                this.assina_nome.Checked = Convert.ToBoolean(dr["assina_nome"]);
                this.alfabetizado_rg.Text = dr["alfabetizado_rg"].ToString();
                this.beneficiario_prog_soc.Checked = Convert.ToBoolean(dr["beneficiario_prog_soc"]);
                this.prog_soc_qual.Text = dr["prog_soc_qual"].ToString();
                this.valor_beneficio.Text = dr["valor_beneficio"].ToString();
                this.profissao.Text = dr["profissao"].ToString();
                this.renda.Text = dr["renda"].ToString();
                this.particularidade_deficiencia.Text = dr["particularidade_deficiencia"].ToString();
                this.possui_laudo_medico.Checked = Convert.ToBoolean(dr["possui_laudo_medico"]);
                this.possui_cid.Checked = Convert.ToBoolean(dr["possui_cid"]);
                this.cpf.Text = dr["cpf"].ToString();
                this.rg_rne.Text = dr["rg_rne"].ToString();
                this.org_exp_cpf.Text = dr["org_exp_cpf"].ToString();
                this.data_exp_cpf.Text = dr["data_exp_cpf"].ToString();
                this.nome_mae.Text = dr["nome_mae"].ToString();
                this.nome_pai.Text = dr["nome_pai"].ToString();
            }

            dr.Close();
            cmd.Dispose();
            myConn.Close();

        }
    }
}
