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
    public partial class Form8 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form8()
        {
            InitializeComponent();
            conn();
        }

        private void conn()
        {
            // If the connection string is empty, use default. 
            const string filename = @"C:\laborsoft\producao.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }

        public bool insertDadosDeContato(int? id)
        {

            string myInsertQuery = "INSERT INTO dados_de_contato";

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

                myInsertQuery = myInsertQuery + "tel_residencial, tel_celular, tel_comercial, tel_recado, "+
                    "logradouro, numero_logradouro, complemento, bairro, cep)";

                if (id == null && id == 0)
                {
                    myInsertQuery = myInsertQuery + " VALUES(" + id + ", ";
                }
                else
                {
                    myInsertQuery = myInsertQuery + "VALUES(";
                }

                myInsertQuery = myInsertQuery +
                            "'" + this.tel_residencial.Text + "', " +
                            "'" + this.tel_celular.Text + "', " +
                            "'" + this.tel_comercial.Text + "', " +
                            "'" + this.tel_recado.Text + "', " +
                            "'" + this.logradouro.Text + "', " +
                            "'" + this.numero_logradouro.Text + "', " +
                            "'" + this.complemento.Text + "', " +
                            "'" + this.bairro.Text + "', " +
                            "'" + this.cep.Text + "' " +
                            ")";
                SQLiteCommand cmd = new SQLiteCommand(myInsertQuery, myConn);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.myConn.Close();

                return Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public bool updateDadosDeContato(int? code)
        {
            bool check_id = idNumRows(code);
            if (check_id == false)
            {
                return insertDadosDeContato(code);
            }
            else
            {
                try
                {
                    if (myConn.State.ToString() == "Closed")
                    {
                        myConn.Open();
                    }

                    string myUpdateQuery = "UPDATE dados_de_contato SET " +
                                            "tel_residencial = '" + this.tel_residencial.Text + "', " +
                                            "tel_celular = '" + this.tel_celular.Text + "', " +
                                            "tel_comercial = '" + this.tel_comercial.Text + "', " +
                                            "tel_recado = '" + this.tel_recado.Text + "', " +
                                            "logradouro = '" + this.logradouro.Text + "', " +
                                            "numero_logradouro = '" + this.numero_logradouro.Text + "', " +
                                            "complemento = '" + this.complemento.Text + "', " +
                                            "bairro = '" + this.bairro.Text + "', " +
                                            "cep = '" + this.cep.Text + "' " +
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

                return false;
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

                string mySelectQuery = "SELECT * FROM dados_de_contato WHERE id = '" + Cod + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.tel_residencial.Text = dr["tel_residencial"].ToString();
                    this.tel_celular.Text = dr["tel_celular"].ToString();
                    this.tel_comercial.Text = dr["tel_comercial"].ToString();
                    this.tel_recado.Text = dr["tel_recado"].ToString();
                    this.logradouro.Text = dr["logradouro"].ToString();
                    this.numero_logradouro.Text = dr["numero_logradouro"].ToString();
                    this.complemento.Text = dr["complemento"].ToString();
                    this.bairro.Text = dr["bairro"].ToString();
                    this.cep.Text = dr["cep"].ToString();
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

            string mySelectQuery = "SELECT id FROM dados_de_contato WHERE id = '" + id + "';";

            System.Diagnostics.Trace.WriteLine(mySelectQuery);

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                cmd.CommandText = mySelectQuery;
                cmd.CommandType = CommandType.Text;
                bool RowCount = false;

                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                RowCount = Convert.ToBoolean(rows);

                cmd.Dispose();
                return RowCount;
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
