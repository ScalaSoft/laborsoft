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

                if (textBox != null)
                    (textBox).Clear();

                if (comboBox != null)
                    comboBox.SelectedIndex = -1;

                if (control.HasChildren)
                    ResetAllControls(control);
            }
        }

        public int checkIfCpfExist(string cpf, string table)
        {
            conn();
            this.myConn.Open();

            string mySelectQuery = "SELECT id FROM " + table + " WHERE cpf = '" + cpf + "';";

            SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    return (int)dr["id"];
                }
            }
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
            }
            return null;
        }
    }
}
