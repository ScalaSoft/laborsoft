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
    public partial class Form6 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form6()
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

        public bool insertUsoOcupacaoDomicilio(int? id)
        {

            string myInsertQuery = "INSERT INTO uso_ocupacao_domicilio";

            if (id == null && id == 0)
            {
                myInsertQuery = myInsertQuery + " (id, ";
            }
            else
            {
                myInsertQuery = myInsertQuery + " (";
            }

            try
            {
                if (myConn.State.ToString() == "Closed")
                {
                    myConn.Open();
                }

                myInsertQuery = myInsertQuery + "situacao, situacao_de_risco, padrao_edificao, tipo_ocupacao, valor_do_aluguel," + 
                    " tipo_uso_imovel, qual_atividade, banheiro, area_terreno, possui_outro_imovel, outro_imovel_onde, tempo_no_domicilio, "+
                    "doc_prefeitura, doc_temp_moradia, quais_docs, tempo_mora_area, morava_onde_antes, municipio_anterior, " + 
                    "tempo_mora_municipio, psh, ano_psh, possui_iptu)";

                if (id == null && id == 0)
                {
                    myInsertQuery = myInsertQuery + " VALUES(" + id + ", ";
                }
                else
                {
                    myInsertQuery = myInsertQuery + "VALUES(";
                }

                myInsertQuery = myInsertQuery +
                            "'" + this.situacao.Text + "', " +
                            "'" + this.situacao_de_risco.Checked + "', " +
                            "'" + this.padrao_edificao.Text + "', " +
                            "'" + this.tipo_ocupacao.Text + "', " +
                            "'" + this.valor_do_aluguel.Text + "', " +
                            "'" + this.tipo_uso_imovel.Text + "', " +
                            "'" + this.qual_atividade.Text + "', " +
                            "'" + this.banheiro.Checked + "', " +
                            "'" + this.area_terreno.Text + "', " +
                            "'" + this.possui_outro_imovel.Checked + "', " +
                            "'" + this.outro_imovel_onde.Text + "', " +
                            "'" + this.tempo_no_domicilio.Text + "', " +
                            "'" + this.doc_prefeitura.Checked + "', " +
                            "'" + this.doc_temp_moradia.Checked + "', " +
                            "'" + this.quais_docs.Text + "', " +
                            "'" + this.tempo_mora_area.Text + "', " +
                            "'" + this.morava_onde_antes.Text + "', " +
                            "'" + this.municipio_anterior.Text + "', " +
                            "'" + this.tempo_mora_municipio.Text + "', " +
                            "'" + this.psh.Checked + "', " +
                            "'" + this.ano_psh.Text + "', " +
                            "'" + this.possui_iptu.Checked + "'" +
                            ")";
                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                myConn.Close();

                return Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool updateUsoOcupacaoDomicilio(int? code)
        {
            bool check_id = idNumRows(code);
            if (!check_id)
            {
                return insertUsoOcupacaoDomicilio(code);
            }
            else
            {
                try
                {
                    if (myConn.State.ToString() == "Closed")
                    {
                        myConn.Open();
                    }

                    string myUpdateQuery = "UPDATE uso_ocupacao_domicilio SET " +
                                            "situacao = '" + this.situacao.Text + "', " +
                                            "situacao_de_risco = '" + this.situacao_de_risco.Checked + "', " +
                                            "padrao_edificao = '" + this.padrao_edificao.Text + "', " +
                                            "tipo_ocupacao = '" + this.tipo_ocupacao.Text + "', " +
                                            "valor_do_aluguel = '" + this.valor_do_aluguel.Text + "', " +
                                            "tipo_uso_imovel = '" + this.tipo_uso_imovel.Text + "', " +
                                            "qual_atividade = '" + this.qual_atividade.Text + "', " +
                                            "banheiro = '" + this.banheiro.Checked + "', " +
                                            "area_terreno = '" + this.area_terreno.Text + "', " +
                                            "possui_outro_imovel = '" + this.possui_outro_imovel.Checked + "', " +
                                            "outro_imovel_onde = '" + this.outro_imovel_onde.Text + "', " +
                                            "tempo_no_domicilio = '" + this.tempo_no_domicilio.Text + "', " +
                                            "doc_prefeitura = '" + this.doc_prefeitura.Checked + "', " +
                                            "doc_temp_moradia = '" + this.doc_temp_moradia.Checked + "', " +
                                            "quais_docs = '" + this.quais_docs.Text + "', " +
                                            "tempo_mora_area = '" + this.tempo_mora_area.Text + "', " +
                                            "morava_onde_antes = '" + this.morava_onde_antes.Text + "', " +
                                            "municipio_anterior = '" + this.municipio_anterior.Text + "', " +
                                            "tempo_mora_municipio = '" + this.tempo_mora_municipio.Text + "', " +
                                            "psh = '" + this.psh.Checked + "', " +
                                            "ano_psh = '" + this.ano_psh.Text + "', " +
                                            "possui_iptu = '" + this.possui_iptu.Checked + "'" +
                                            "WHERE id = '" + code + "'";
                    System.Diagnostics.Trace.WriteLine(myUpdateQuery);

                    SQLiteCommand cmd = new SQLiteCommand(myUpdateQuery, myConn);

                    int result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    this.myConn.Close();

                    return Convert.ToBoolean(result);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void populateForm(int? Cod)
        {
            if (idNumRows(Cod) == true)
            {
                if (myConn.State.ToString() == "Closed")
                {
                    myConn.Open();
                }

                string mySelectQuery = "SELECT * FROM uso_ocupacao_domicilio WHERE id = '" + Cod + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.situacao.Text = dr["situacao"].ToString();
                    this.situacao_de_risco.Checked = Convert.ToBoolean(dr["situacao_de_risco"]);
                    this.padrao_edificao.Text = dr["padrao_edificao"].ToString();
                    this.tipo_ocupacao.Text = dr["tipo_ocupacao"].ToString();
                    this.valor_do_aluguel.Text = dr["valor_do_aluguel"].ToString();
                    this.tipo_uso_imovel.Text = dr["tipo_uso_imovel"].ToString();
                    this.qual_atividade.Text = dr["qual_atividade"].ToString();
                    this.banheiro.Checked = Convert.ToBoolean(dr["banheiro"]);
                    this.area_terreno.Text = dr["area_terreno"].ToString();
                    this.possui_outro_imovel.Checked = Convert.ToBoolean(dr["possui_outro_imovel"]);
                    this.outro_imovel_onde.Text = dr["outro_imovel_onde"].ToString();
                    this.tempo_no_domicilio.Text = dr["tempo_no_domicilio"].ToString();
                    this.doc_prefeitura.Checked = Convert.ToBoolean(dr["doc_prefeitura"]);
                    this.doc_temp_moradia.Checked = Convert.ToBoolean(dr["doc_temp_moradia"]);
                    this.quais_docs.Text = dr["quais_docs"].ToString();
                    this.tempo_mora_area.Text = dr["tempo_mora_area"].ToString();
                    this.morava_onde_antes.Text = dr["morava_onde_antes"].ToString();
                    this.municipio_anterior.Text = dr["municipio_anterior"].ToString();
                    this.tempo_mora_municipio.Text = dr["tempo_mora_municipio"].ToString();
                    this.Psh.Checked = (bool)dr["psh"];
                    this.ano_psh.Text = dr["ano_psh"].ToString();
                    this.possui_iptu.Checked = Convert.ToBoolean(dr["possui_iptu"]);
                }

                dr.Close();
                cmd.Dispose();
                myConn.Close();
            }

        }

        public bool idNumRows(int? id)
        {
            if (myConn.State.ToString() == "Closed")
            {
                myConn.Open();
            }

            string mySelectQuery = "SELECT id FROM uso_ocupacao_domicilio WHERE id = '"+id+"';";

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
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
        }

        public CheckBox Psh
        {
            get { return psh; }
            set { psh = value; }
        }
    }
}
