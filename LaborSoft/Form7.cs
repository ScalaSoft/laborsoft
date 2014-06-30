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
    public partial class Form7 : Form
    {
        SQLiteConnection myConn;
        Utilities util = new Utilities();

        public Form7()
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

        public bool insertParticipacaoOrganizacaoSocial(int? id)
        {

            string myInsertQuery = "INSERT INTO participacao_organizacao";

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

                myInsertQuery = myInsertQuery + "assoc_conhece, qual_assoc, em_qual_participa, participa_assoc, "+
                    "razao_de_nao_participar, liderancas_area)";

                if (id == null && id == 0)
                {
                    myInsertQuery = myInsertQuery + " VALUES(" + id + ", ";
                }
                else
                {
                    myInsertQuery = myInsertQuery + "VALUES(";
                }

                myInsertQuery = myInsertQuery +
                            "'" + this.assoc_conhece.Checked + "', " +
                            "'" + this.qual_assoc.Text + "', " +
                            "'" + this.em_qual_participa.Text + "', " +
                            "'" + this.participa_assoc.Checked + "', " +
                            "'" + this.razao_de_nao_participar.Text + "', " +
                            "'" + this.liderancas_area.Text + "'" +
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

        public bool updateParticipacaoOrganizacaoSocial(int? code)
        {
            bool check_id = idNumRows(code);
            if (!check_id)
            {
                insertParticipacaoOrganizacaoSocial(code);
            }
            else
            {
                try
                {
                    if (myConn.State.ToString() == "Closed")
                    {
                        myConn.Open();
                    }

                    string myUpdateQuery = "UPDATE participacao_organizacao SET " +
                                            "assoc_conhece = '" + this.assoc_conhece.Checked + "', " +
                                            "qual_assoc = '" + this.qual_assoc.Text + "', " +
                                            "em_qual_participa = '" + this.em_qual_participa.Text + "', " +
                                            "participa_assoc = '" + this.participa_assoc.Checked + "', " +
                                            "razao_de_nao_participar = '" + this.razao_de_nao_participar.Text + "', " +
                                            "liderancas_area = '" + this.liderancas_area.Text + "' " +
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

                string mySelectQuery = "SELECT * FROM participacao_organizacao WHERE id = '" + Cod + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.assoc_conhece.Text = dr["assoc_conhece"].ToString();
                    this.qual_assoc.Text = dr["qual_assoc"].ToString();
                    this.em_qual_participa.Text = dr["em_qual_participa"].ToString();
                    this.participa_assoc.Text = dr["participa_assoc"].ToString();
                    this.razao_de_nao_participar.Text = dr["razao_de_nao_participar"].ToString();
                    this.liderancas_area.Text = dr["liderancas_area"].ToString();
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

            string mySelectQuery = "SELECT id FROM uso_ocupacao_domicilio WHERE id = '" + id + "';";

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
