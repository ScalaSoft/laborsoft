using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaborSoft
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.insertIdentificacao())
            {
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                MessageBox.Show("Erro!!!");
            }
        }
    }
}
