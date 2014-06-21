using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaborSoft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cod_area_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet1.identificacao' table. You can move, or remove it, as needed.
            this.identificacaoTableAdapter.Fill(this.dbDataSet1.identificacao);

        }
        
        public TextBox Cod_area
        {
          get { return cod_area; }
          set { cod_area = value; }
        }

        public ComboBox Area
        {
          get { return area; }
          set { area = value; }
        }

        public TextBox NomeSubarea 
        {
            get { return nome_subarea; }
            set { nome_subarea = value; }
        }

        public TextBox TipoLogradouro
        {
            get { return tipo_logradouro; }
            set { tipo_logradouro = value; }
        }

        public TextBox NomeLogradouro
        {
            get { return nome_logradouro; }
            set { nome_logradouro = value; }
        }

        public TextBox NumeroLogradouro
        {
            get { return numero_logradouro; }
            set { numero_logradouro = value; }
        }

        public TextBox ComplLogradouro
        {
            get { return compl_logradouro; }
            set { compl_logradouro = value; }
        }

        public TextBox Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public TextBox Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public TextBox SetorQuadra
        {
            get { return setor_quadra; }
            set { setor_quadra = value; }
        }

        public TextBox SeloLote
        {
            get { return selo_lote; }
            set { selo_lote = value; }
        }

        public TextBox Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public ComboBox PrimeiroNoDomicilio
        {
            get { return primeiro_no_domicilio; }
            set { primeiro_no_domicilio = value; }
        }

        public TextBox NumeroDeFamiliasNoDomicilio
        {
            get { return num_fam_dom; }
            set { num_fam_dom = value; }
        }

        public TextBox NumeroDePessoasNaFamilia
        {
            get { return num_pess_fam; }
            set { num_pess_fam = value; }
        }

        public ComboBox MulherResponsavel
        {
            get { return mulher_resp_fam; }
            set { mulher_resp_fam = value; }
        }

        public CheckBox DeficienteNaFamilia
        {
            get { return desficiente_fam; }
            set { desficiente_fam = value; }
        }

        public TextBox NumeroDePortadoresDeDeficiencia
        {
            get { return num_port_def; }
            set { num_port_def = value; }
        }

        public CheckBox PossuiCadeirante
        {
            get { return possui_cadeirante; }
            set { possui_cadeirante = value; }
        }

        public CheckBox DeficienteMobilidade
        {
            get { return deficiencia_mobilidade; }
            set { deficiencia_mobilidade = value; }
        }

        public CheckBox Cadunico
        {
            get { return cadunico; }
            set { cadunico = value; }
        }

        public TextBox NumeroNIS
        {
            get { return numero_nis; }
            set { numero_nis = value; }
        }

        public TextBox RendaFamiliar
        {
            get { return renda_familiar; }
            set { renda_familiar = value; }
        }

        public TextBox Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public TextBox NomeDoEntrevistado
        {
            get { return nome_entrevistado; }
            set { nome_entrevistado = value; }
        }
    }
}
