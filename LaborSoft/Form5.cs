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
    public partial class Form5 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form5()
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

        public bool insertComposicaoFamiliar(int? id)
        {

            string myInsertQuery = "INSERT INTO composicao_familiar";

            if (id != null && id != 0)
            {
                myInsertQuery = myInsertQuery + " (id, ";
            }
            else {
                myInsertQuery = myInsertQuery + " (";
            }
            
            try
            {
                if (myConn.State.ToString() == "Closed")
                {
                    myConn.Open();
                }

                myInsertQuery =  myInsertQuery + "nome_1,relacao_resp_fam_1,sexo_1,nascimento_1," +
                            "estado_civil_1,regime_casamento_1,uniao_consensual_1," +
                            "frequentou_escola_1,escolaridade_1,profissao_1, renda_1," +
                            "beneficiario_prog_soc_1,prog_soc_qual_1   ,valor_beneficio_1 ," +
                            "particularidade_deficiencia_1,possui_laudo_medico_1  ,possui_cid_1," +
                            "nome_2,relacao_resp_fam_2,sexo_2,nascimento_2,estado_civil_2," +
                            "regime_casamento_2,uniao_consensual_2,frequentou_escola_2,escolaridade_2,profissao_2," +
                            "renda_2,beneficiario_prog_soc_2,prog_soc_qual_2,valor_beneficio_2," +
                            "particularidade_deficiencia_2,possui_laudo_medico_2  ,possui_cid_2," +
                            "nome_3,relacao_resp_fam_3,sexo_3,nascimento_3,estado_civil_3," +
                            "regime_casamento_3,uniao_consensual_3,frequentou_escola_3,escolaridade_3," +
                            "profissao_3 ,renda_3,beneficiario_prog_soc_3,prog_soc_qual_3," +
                            "valor_beneficio_3,particularidade_deficiencia_3,possui_laudo_medico_3,possui_cid_3)";
                
                if (id != null && id != 0)
                {
                    myInsertQuery = myInsertQuery + " VALUES("+id+", ";
                }
                else
                {
                    myInsertQuery = myInsertQuery + "VALUES(";
                }            
                
                myInsertQuery = myInsertQuery + "'" + this.nome_1.Text + "', " +
                            "'" + this.relacao_resp_fam_1.Text + "', " +
                            "'" + this.sexo_1.Text + "', " +
                            "'" + this.nascimento_1.Text + "', " +
                            "'" + this.estado_civil_1.Text + "', " +
                            "'" + this.regime_casamento_1.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.uniao_consensual_1.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.frequentou_escola_1.Checked) + "', " +
                            "'" + this.escolaridade_1.Text + "', " +
                            "'" + this.profissao_1.Text + "', " +
                            "'" + this.renda_1.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_1.Checked) + "', " +
                            "'" + this.prog_soc_qual_1.Text + "', " +
                            "'" + this.valor_beneficio_1.Text + "', " +
                            "'" + this.particularidade_deficiencia_1.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_1.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_cid_1.Checked) + "', " +
                            "'" + this.nome_2.Text + "', " +
                            "'" + this.relacao_resp_fam_2.Text + "', " +
                            "'" + this.sexo_2.Text + "', " +
                            "'" + this.nascimento_2.Text + "', " +
                            "'" + this.estado_civil_2.Text + "', " +
                            "'" + this.regime_casamento_2.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.uniao_consensual_2.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.frequentou_escola_2.Checked) + "', " +
                            "'" + this.escolaridade_2.Text + "', " +
                            "'" + this.profissao_2.Text + "', " +
                            "'" + this.renda_2.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_2.Checked) + "', " +
                            "'" + this.prog_soc_qual_2.Text + "', " +
                            "'" + this.valor_beneficio_2.Text + "', " +
                            "'" + this.particularidade_deficiencia_2.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_2.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_cid_2.Checked) + "', " +
                            "'" + this.nome_3.Text + "', " +
                            "'" + this.relacao_resp_fam_3.Text + "', " +
                            "'" + this.sexo_3.Text + "', " +
                            "'" + this.nascimento_3.Text + "', " +
                            "'" + this.estado_civil_3.Text + "', " +
                            "'" + this.regime_casamento_3.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.uniao_consensual_3.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.frequentou_escola_3.Checked) + "', " +
                            "'" + this.escolaridade_3.Text + "', " +
                            "'" + this.profissao_3.Text + "', " +
                            "'" + this.renda_3.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_3.Checked) + "', " +
                            "'" + this.prog_soc_qual_3.Text + "', " +
                            "'" + this.valor_beneficio_3.Text + "', " +
                            "'" + this.particularidade_deficiencia_3.Text + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_3.Checked) + "', " +
                            "'" + this.util.SQLiteConvertToBool(this.possui_cid_3.Checked) + "'" +
                            ")";
                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);
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

        public bool updateComposicaoFamiliar(int? code)
        {
            bool check_id = idNumRows(code);
            if (check_id == false)
            {
                return insertComposicaoFamiliar(code);
            }
            else
            {
                try
                {
                    if (myConn.State.ToString() == "Closed")
                    {
                        myConn.Open();
                    }

                    string myUpdateQuery = "UPDATE composicao_familiar SET " +
                                            "nome_1 = '" + this.nome_1.Text + "', " +
                                            "relacao_resp_fam_1 = '" + this.relacao_resp_fam_1.Text + "', " +
                                            "sexo_1 = '" + this.sexo_1.Text + "', " +
                                            "nascimento_1 = '" + this.nascimento_1.Text + "', " +
                                            "estado_civil_1 = '" + this.estado_civil_1.Text + "', " +
                                            "regime_casamento_1 = '" + this.regime_casamento_1.Text + "'," +
                                            "uniao_consensual_1 = '" + this.util.SQLiteConvertToBool(this.uniao_consensual_1.Checked) + "', " +
                                            "frequentou_escola_1 = '" + this.util.SQLiteConvertToBool(this.frequentou_escola_1.Checked) + "', " +
                                            "escolaridade_1 = '" + this.escolaridade_1.Text + "', " +
                                            "beneficiario_prog_soc_1 = '" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_1.Checked) + "', " +
                                            "prog_soc_qual_1 = '" + this.prog_soc_qual_1.Text + "', " +
                                            "valor_beneficio_1 = '" + this.valor_beneficio_1.Text + "', " +
                                            "profissao_1 = '" + this.profissao_1.Text + "', " +
                                            "renda_1 = '" + this.renda_1.Text + "', " +
                                            "particularidade_deficiencia_1 = '" + this.particularidade_deficiencia_1.Text + "', " +
                                            "possui_laudo_medico_1 = '" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_1.Checked) + "', " +
                                            "possui_cid_1 = '" + this.util.SQLiteConvertToBool(this.possui_cid_1.Checked) + "', " +
                                            "nome_2 = '" + this.nome_2.Text + "', " +
                                            "relacao_resp_fam_2 = '" + this.relacao_resp_fam_2.Text + "', " +
                                            "sexo_2 = '" + this.sexo_2.Text + "', " +
                                            "nascimento_2 = '" + this.nascimento_2.Text + "', " +
                                            "estado_civil_2 = '" + this.estado_civil_2.Text + "', " +
                                            "regime_casamento_2 = '" + this.regime_casamento_2.Text + "'," +
                                            "uniao_consensual_2 = '" + this.util.SQLiteConvertToBool(this.uniao_consensual_2.Checked) + "', " +
                                            "frequentou_escola_2 = '" + this.util.SQLiteConvertToBool(this.frequentou_escola_2.Checked) + "', " +
                                            "escolaridade_2 = '" + this.escolaridade_2.Text + "', " +
                                            "beneficiario_prog_soc_2 = '" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_2.Checked) + "', " +
                                            "prog_soc_qual_2 = '" + this.prog_soc_qual_2.Text + "', " +
                                            "valor_beneficio_2 = '" + this.valor_beneficio_2.Text + "', " +
                                            "profissao_2 = '" + this.profissao_2.Text + "', " +
                                            "renda_2 = '" + this.renda_2.Text + "', " +
                                            "particularidade_deficiencia_2 = '" + this.particularidade_deficiencia_2.Text + "', " +
                                            "possui_laudo_medico_2 = '" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_2.Checked) + "', " +
                                            "possui_cid_2 = '" + this.util.SQLiteConvertToBool(this.possui_cid_2.Checked) + "', " +
                                            "nome_3 = '" + this.nome_3.Text + "', " +
                                            "relacao_resp_fam_3 = '" + this.relacao_resp_fam_3.Text + "', " +
                                            "sexo_3 = '" + this.sexo_3.Text + "', " +
                                            "nascimento_3 = '" + this.nascimento_3.Text + "', " +
                                            "estado_civil_3 = '" + this.estado_civil_3.Text + "', " +
                                            "regime_casamento_3 = '" + this.regime_casamento_3.Text + "'," +
                                            "uniao_consensual_3 = '" + this.util.SQLiteConvertToBool(this.uniao_consensual_3.Checked) + "', " +
                                            "frequentou_escola_3 = '" + this.util.SQLiteConvertToBool(this.frequentou_escola_3.Checked) + "', " +
                                            "escolaridade_3 = '" + this.escolaridade_3.Text + "', " +
                                            "beneficiario_prog_soc_3 = '" + this.util.SQLiteConvertToBool(this.beneficiario_prog_soc_3.Checked) + "', " +
                                            "prog_soc_qual_3 = '" + this.prog_soc_qual_3.Text + "', " +
                                            "valor_beneficio_3 = '" + this.valor_beneficio_3.Text + "', " +
                                            "profissao_3 = '" + this.profissao_3.Text + "', " +
                                            "renda_3 = '" + this.renda_3.Text + "', " +
                                            "particularidade_deficiencia_3 = '" + this.particularidade_deficiencia_3.Text + "', " +
                                            "possui_laudo_medico_3 = '" + this.util.SQLiteConvertToBool(this.possui_laudo_medico_3.Checked) + "', " +
                                            "possui_cid_3 = '" + this.util.SQLiteConvertToBool(this.possui_cid_3.Checked) + "' " +
                                            "WHERE id = '" + code + "'";
                    System.Diagnostics.Trace.WriteLine(myUpdateQuery);

                    SQLiteCommand cmd = new SQLiteCommand(myUpdateQuery, myConn);

                    var result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
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
            if (idNumRows(Cod) == true)
            {
                if (myConn.State.ToString() == "Closed")
                {
                    myConn.Open();
                }

                string mySelectQuery = "SELECT * FROM composicao_familiar WHERE id = '" + Cod + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.nome_1.Text = dr["nome_1"].ToString();
                    this.relacao_resp_fam_1.Text = dr["relacao_resp_fam_1"].ToString();
                    this.sexo_1.Text = dr["sexo_1"].ToString();
                    this.nascimento_1.Text = dr["nascimento_1"].ToString();
                    this.estado_civil_1.Text = dr["estado_civil_1"].ToString();
                    this.regime_casamento_1.Text = dr["regime_casamento_1"].ToString();
                    this.uniao_consensual_1.Checked = Convert.ToBoolean(dr["uniao_consensual_1"]);
                    this.frequentou_escola_1.Checked = Convert.ToBoolean(dr["frequentou_escola_1"]);
                    this.escolaridade_1.Text = dr["escolaridade_1"].ToString();
                    this.beneficiario_prog_soc_1.Checked = Convert.ToBoolean(dr["beneficiario_prog_soc_1"]);
                    this.prog_soc_qual_1.Text = dr["prog_soc_qual_1"].ToString();
                    this.valor_beneficio_1.Text = dr["valor_beneficio_1"].ToString();
                    this.profissao_1.Text = dr["profissao_1"].ToString();
                    this.renda_1.Text = dr["renda_1"].ToString();
                    this.particularidade_deficiencia_1.Text = dr["particularidade_deficiencia_1"].ToString();
                    this.possui_laudo_medico_1.Checked = Convert.ToBoolean(dr["possui_laudo_medico_1"]);
                    this.possui_cid_1.Checked = Convert.ToBoolean(dr["possui_cid_1"]);
                    this.nome_2.Text = dr["nome_2"].ToString();
                    this.relacao_resp_fam_2.Text = dr["relacao_resp_fam_2"].ToString();
                    this.sexo_2.Text = dr["sexo_2"].ToString();
                    this.nascimento_2.Text = dr["nascimento_2"].ToString();
                    this.estado_civil_2.Text = dr["estado_civil_2"].ToString();
                    this.regime_casamento_2.Text = dr["regime_casamento_2"].ToString();
                    this.uniao_consensual_2.Checked = Convert.ToBoolean(dr["uniao_consensual_2"]);
                    this.frequentou_escola_2.Checked = Convert.ToBoolean(dr["frequentou_escola_2"]);
                    this.escolaridade_2.Text = dr["escolaridade_2"].ToString();
                    this.beneficiario_prog_soc_2.Checked = Convert.ToBoolean(dr["beneficiario_prog_soc_2"]);
                    this.prog_soc_qual_2.Text = dr["prog_soc_qual_2"].ToString();
                    this.valor_beneficio_2.Text = dr["valor_beneficio_2"].ToString();
                    this.profissao_2.Text = dr["profissao_2"].ToString();
                    this.renda_2.Text = dr["renda_2"].ToString();
                    this.particularidade_deficiencia_2.Text = dr["particularidade_deficiencia_2"].ToString();
                    this.possui_laudo_medico_2.Checked = Convert.ToBoolean(dr["possui_laudo_medico_2"]);
                    this.possui_cid_2.Checked = Convert.ToBoolean(dr["possui_cid_2"]);
                    this.nome_3.Text = dr["nome_3"].ToString();
                    this.relacao_resp_fam_3.Text = dr["relacao_resp_fam_3"].ToString();
                    this.sexo_3.Text = dr["sexo_3"].ToString();
                    this.nascimento_3.Text = dr["nascimento_3"].ToString();
                    this.estado_civil_3.Text = dr["estado_civil_3"].ToString();
                    this.regime_casamento_3.Text = dr["regime_casamento_3"].ToString();
                    this.uniao_consensual_3.Checked = Convert.ToBoolean(dr["uniao_consensual_3"]);
                    this.frequentou_escola_3.Checked = Convert.ToBoolean(dr["frequentou_escola_3"]);
                    this.escolaridade_3.Text = dr["escolaridade_3"].ToString();
                    this.beneficiario_prog_soc_3.Checked = Convert.ToBoolean(dr["beneficiario_prog_soc_3"]);
                    this.prog_soc_qual_3.Text = dr["prog_soc_qual_3"].ToString();
                    this.valor_beneficio_3.Text = dr["valor_beneficio_3"].ToString();
                    this.profissao_3.Text = dr["profissao_3"].ToString();
                    this.renda_3.Text = dr["renda_3"].ToString();
                    this.particularidade_deficiencia_3.Text = dr["particularidade_deficiencia_3"].ToString();
                    this.possui_laudo_medico_3.Checked = Convert.ToBoolean(dr["possui_laudo_medico_3"]);
                    this.possui_cid_3.Checked = Convert.ToBoolean(dr["possui_cid_3"]);
                }

                dr.Close();
                cmd.Dispose();
                myConn.Close();
            }

        }

        public bool idNumRows(int? id) {
            if (myConn.State.ToString() == "Closed")
            {
                myConn.Open();
            }

            string mySelectQuery = "SELECT id FROM composicao_familiar WHERE id = '" + id + "';";

            System.Diagnostics.Trace.WriteLine(mySelectQuery);
            
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                bool res = dr.Read();
                
                dr.Close();
                cmd.Dispose();
                return res;
            }
            catch (SQLiteException e) {
                throw new Exception(e.Message);
            }
        }

    }
}
