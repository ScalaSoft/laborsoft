using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LaborSoft
{
    public class Utilities
    {
        SQLiteConnection myConn;

        public Utilities()
        {
            conn();
        }
        
        public void conn()
        {
            // If the connection string is empty, use default. 
            const string filename = @"C:\Users\Álvaro\Documents\GitHub\laborsoft\LaborSoft\db.s3db";
            string sqConnectionString = "Data Source=" + filename + ";Version=3;FailIfMissing=True";
            this.myConn = new SQLiteConnection(sqConnectionString);
        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                var textBox = control as TextBox;
                var comboBox = control as ComboBox;
                var checkBox = control as CheckBox;
                var richBox = control as RichTextBox;

                if (textBox != null)
                    (textBox).Clear();

                if (comboBox != null)
                    comboBox.SelectedIndex = -1;

                if (checkBox != null)
                    (checkBox).Checked = false;

                if (richBox != null)
                    (richBox).Clear();
                
                if (control.HasChildren)
                    ResetAllControls(control);
            }
        }

        public int checkIfCpfExist(string cpf, string table)
        {
            int? id = null;

            if (myConn.State.ToString() == "Closed")
            {
                conn();
                this.myConn.Open();
            }

            string mySelectQuery = "select id from dados_responsavel_familiar where cpf = '"+cpf.Normalize()+"';";
            

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);
            cmd.CommandText = mySelectQuery;
            int RowCount = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = mySelectQuery;
            SQLiteDataReader dr = cmd.ExecuteReader();

            if (RowCount > 0)
            {
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"]);
                }

                dr.Close();
                dr.Dispose();
                cmd.Dispose();
            }

            if (id > 0) return (int)id;
            return 0;
        }

        public int getNextCode() 
        {
            conn();
            int? id = null;

            this.myConn.Open();

            string mySelectQuery = "select (id+1) as code from identificacao order by id desc limit 1;";


            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);
            cmd.CommandText = mySelectQuery;
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                id = Convert.ToInt32(dr["code"]);
            }

            dr.Close();
            dr.Dispose();
            cmd.Dispose();

            if (id > 0) return (int)id;
            return 0;
        }

        public string getCpfToNomeEntrevistadoFromIdentificacao(string str)
        {
            myConn.Open();

            string mySelectQuery = "SELECT drf.cpf as cpf FROM identificacao i "+
                "LEFT JOIN dados_responsavel_familiar drf WHERE i.nome_entrevistado = '" + str + "';";

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    return dr["cpf"].ToString();
                }

                cmd.Dispose();
                dr.Close();
            }
            return null;
        }
    }
}
