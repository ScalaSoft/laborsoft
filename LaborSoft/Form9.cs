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
    public partial class Form9 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form9()
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

        public bool insertDadosDaEntrevista(int? id)
        {

            string myInsertQuery = "INSERT INTO dados_entrevista";

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

                myInsertQuery = myInsertQuery + "entrevistador, data_entrevista, supervisor, data_supervisao, condicao_entrevista," + 
                    " outra_condicao)";

                if (id == null && id == 0)
                {
                    myInsertQuery = myInsertQuery + " VALUES(" + id + ", ";
                }
                else
                {
                    myInsertQuery = myInsertQuery + "VALUES(";
                }

                myInsertQuery = myInsertQuery +
                            "'" + this.entrevistador.Text + "', " +
                            "'" + this.data_entrevista.Text + "', " +
                            "'" + this.supervisor.Text + "', " +
                            "'" + this.data_supervisao.Text + "', " +
                            "'" + this.condicao_entrevista.Text + "', " +
                            "'" + this.outra_condicao.Text + "' " +
                            ")";
                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            myConn.Close();

            return false;
        }

        public bool updateDadosDaEntrevista(int? code)
        {
            bool check_id = idNumRows(code);
            if (!check_id)
            {
                insertDadosDaEntrevista(code);
            }
            else
            {
                try
                {
                    if (myConn.State.ToString() == "Closed")
                    {
                        myConn.Open();
                    }

                    string myUpdateQuery = "UPDATE dados_entrevista SET " +
                                            "entrevistador = '" + this.entrevistador.Text + "', " +
                                            "data_entrevista = '" + this.data_entrevista.Text + "', " +
                                            "supervisor = '" + this.supervisor.Text + "', " +
                                            "data_supervisao = '" + this.data_supervisao.Text + "', " +
                                            "condicao_entrevista = '" + this.condicao_entrevista.Text + "', " +
                                            "outra_condicao = '" + this.outra_condicao.Text + "' " +
                                            "WHERE id = '" + code + "'";
                    System.Diagnostics.Trace.WriteLine(myUpdateQuery);

                    SQLiteCommand cmd = new SQLiteCommand(myUpdateQuery, myConn);

                    int result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return Convert.ToBoolean(result);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            myConn.Close();

            return false;
        }

        public void populateForm(int? Cod)
        {
            MessageBox.Show(idNumRows(Cod).ToString());
            if (idNumRows(Cod) == true)
            {
                if (myConn.State.ToString() == "Closed")
                {
                    myConn.Open();
                }

                string mySelectQuery = "SELECT * FROM dados_entrevista WHERE id = '" + Cod + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.entrevistador.Text = dr["entrevistador"].ToString();
                    this.data_entrevista.Text = dr["data_entrevista"].ToString();
                    this.supervisor.Text = dr["supervisor"].ToString();
                    this.data_supervisao.Text = dr["data_supervisao"].ToString();
                    this.condicao_entrevista.Text = dr["condicao_entrevista"].ToString();
                    this.outra_condicao.Text = dr["outra_condicao"].ToString();
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

            string mySelectQuery = "SELECT id FROM dados_entrevista WHERE id = '" + id + "';";

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
    }
}
