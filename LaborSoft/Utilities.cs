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
        Dictionary<string, int> cpfList = new Dictionary<string, int>();
        SQLiteConnection myConn;

        public Utilities()
        {
            conn();
        }
        
        public void conn()
        {
            // If the connection string is empty, use default. 
            const string filename = @"C:\laborsoft\producao.s3db";
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

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                var textBox = control as TextBox;
                var comboBox = control as ComboBox;
                var checkBox = control as CheckBox;
                var richBox = control as RichTextBox;
                var maskBox = control as MaskedTextBox;

                if (textBox != null)
                    (textBox).Clear();

                if (comboBox != null)
                    comboBox.SelectedIndex = -1;

                if (checkBox != null)
                    (checkBox).Checked = false;

                if (richBox != null)
                    (richBox).Clear();

                if (maskBox != null)
                    (maskBox).Clear();

                if (control.HasChildren)
                    ResetAllControls(control);
            }
        }

        public int checkIfCpfExist(string cpf, string table)
        {
            int? id = null;

            openConn();

            if (cpf != null)
            {

                if (this.cpfList.ContainsKey(cpf)) {
                    return cpfList[cpf];
                }
                
                string mySelectQuery = "select id from dados_responsavel_familiar where cpf = '" + cpf + "';";


                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                cmd.CommandText = mySelectQuery;
                cmd.CommandType = System.Data.CommandType.Text;

                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"]);
                }

                if (id != null)
                {
                    cpfList.Add(cpf.ToString(), Convert.ToInt32(id));
                }

                dr.Close();
                dr.Dispose();
                cmd.Dispose();
            }
            else {
                id = 0;
            }

            this.myConn.Close();

            if (id > 0) return (int)id;
            return 0;
        }

        public int getNextCode() 
        {
            openConn();

            int? id = null;

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

            this.myConn.Close();

            if (id > 0) return (int)id;
            return 0;
        }

        public string getCpfToNomeEntrevistadoFromIdentificacao(string str)
        {
            openConn();

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

            myConn.Close();

            return null;
        }

        public bool checkNomeEntrevistado(string nome) {

            openConn();

            if (nome != null)
            {

                string mySelectQuery = "select count(*) as total from identificacao where nome_entrevistado = '" + nome + "';";

                SQLiteCommand cmd = new SQLiteCommand(mySelectQuery, myConn);

                cmd.CommandText = mySelectQuery;
                cmd.CommandType = System.Data.CommandType.Text;

                bool res = Convert.ToBoolean(cmd.ExecuteScalar());

                cmd.Dispose();
                this.myConn.Close();

                return res;
            }
            else
            {
                return false;
            }
        }

        public int SQLiteConvertToBool(bool value) {
            if(value == true){ return (int)1; }else{ return (int)0; }
        }
    }
}
