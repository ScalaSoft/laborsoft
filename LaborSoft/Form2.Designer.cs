namespace LaborSoft
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_area = new System.Windows.Forms.TextBox();
            this.identificacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_subarea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo_logradouro = new System.Windows.Forms.TextBox();
            this.nome_logradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compl_logradouro = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.ComboBox();
            this.numero_logradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.complemento = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nome_entrevistado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.primeiro_no_domicilio = new System.Windows.Forms.ComboBox();
            this.mulher_resp_fam = new System.Windows.Forms.ComboBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.selo_lote = new System.Windows.Forms.TextBox();
            this.setor_quadra = new System.Windows.Forms.TextBox();
            this.num_fam_dom = new System.Windows.Forms.TextBox();
            this.num_pess_fam = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.desficiente_fam = new System.Windows.Forms.CheckBox();
            this.possui_cadeirante = new System.Windows.Forms.CheckBox();
            this.deficiencia_mobilidade = new System.Windows.Forms.CheckBox();
            this.cadunico = new System.Windows.Forms.CheckBox();
            this.num_port_def = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.numero_nis = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.renda_familiar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.identificacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da Área:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Área:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subarea:";
            // 
            // cod_area
            // 
            this.cod_area.Location = new System.Drawing.Point(100, 10);
            this.cod_area.Name = "cod_area";
            this.cod_area.Size = new System.Drawing.Size(239, 20);
            this.cod_area.TabIndex = 3;
            this.cod_area.TextChanged += new System.EventHandler(this.cod_area_TextChanged);
            // 
            // identificacaoBindingSource
            // 
            this.identificacaoBindingSource.DataMember = "identificacao";
            // 
            // nome_subarea
            // 
            this.nome_subarea.Location = new System.Drawing.Point(734, 8);
            this.nome_subarea.Name = "nome_subarea";
            this.nome_subarea.Size = new System.Drawing.Size(239, 20);
            this.nome_subarea.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Logradouro:";
            // 
            // tipo_logradouro
            // 
            this.tipo_logradouro.Location = new System.Drawing.Point(100, 47);
            this.tipo_logradouro.Name = "tipo_logradouro";
            this.tipo_logradouro.Size = new System.Drawing.Size(239, 20);
            this.tipo_logradouro.TabIndex = 8;
            // 
            // nome_logradouro
            // 
            this.nome_logradouro.Location = new System.Drawing.Point(426, 44);
            this.nome_logradouro.Name = "nome_logradouro";
            this.nome_logradouro.Size = new System.Drawing.Size(547, 20);
            this.nome_logradouro.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Logradouro (compl):";
            // 
            // compl_logradouro
            // 
            this.compl_logradouro.Location = new System.Drawing.Point(100, 82);
            this.compl_logradouro.Name = "compl_logradouro";
            this.compl_logradouro.Size = new System.Drawing.Size(726, 20);
            this.compl_logradouro.TabIndex = 11;
            // 
            // area
            // 
            this.area.AutoCompleteCustomSource.AddRange(new string[] {
            "Livres",
            "Favelas",
            "Conjuntos Hab."});
            this.area.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.area.FormattingEnabled = true;
            this.area.Items.AddRange(new object[] {
            "Livres",
            "Favelas",
            "Conjuntos Hab."});
            this.area.Location = new System.Drawing.Point(426, 7);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(249, 21);
            this.area.TabIndex = 12;
            // 
            // numero_logradouro
            // 
            this.numero_logradouro.Location = new System.Drawing.Point(887, 81);
            this.numero_logradouro.Name = "numero_logradouro";
            this.numero_logradouro.Size = new System.Drawing.Size(86, 20);
            this.numero_logradouro.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numeral:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CEP:";
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(100, 115);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(239, 20);
            this.complemento.TabIndex = 18;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(426, 112);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(239, 20);
            this.bairro.TabIndex = 19;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(734, 108);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(239, 20);
            this.cep.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nome do Entrevistado:";
            // 
            // nome_entrevistado
            // 
            this.nome_entrevistado.Location = new System.Drawing.Point(121, 150);
            this.nome_entrevistado.Name = "nome_entrevistado";
            this.nome_entrevistado.Size = new System.Drawing.Size(852, 20);
            this.nome_entrevistado.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Setor/Quadra:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Selo/Lote:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Dominícilo (A, B, C...):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Primeiro morador?";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(527, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 26);
            this.label16.TabIndex = 27;
            this.label16.Text = "Número de famílias \r\nno Domicilio:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(679, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 26);
            this.label17.TabIndex = 28;
            this.label17.Text = "Número de pessoas\r\nna sua família:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(827, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 26);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mulher responsável\r\npela unidade familiar?";
            // 
            // primeiro_no_domicilio
            // 
            this.primeiro_no_domicilio.FormattingEnabled = true;
            this.primeiro_no_domicilio.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.primeiro_no_domicilio.Location = new System.Drawing.Point(472, 188);
            this.primeiro_no_domicilio.Name = "primeiro_no_domicilio";
            this.primeiro_no_domicilio.Size = new System.Drawing.Size(45, 21);
            this.primeiro_no_domicilio.TabIndex = 30;
            this.primeiro_no_domicilio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mulher_resp_fam
            // 
            this.mulher_resp_fam.FormattingEnabled = true;
            this.mulher_resp_fam.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.mulher_resp_fam.Location = new System.Drawing.Point(937, 191);
            this.mulher_resp_fam.Name = "mulher_resp_fam";
            this.mulher_resp_fam.Size = new System.Drawing.Size(45, 21);
            this.mulher_resp_fam.TabIndex = 31;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(337, 189);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(37, 20);
            this.domicilio.TabIndex = 32;
            // 
            // selo_lote
            // 
            this.selo_lote.Location = new System.Drawing.Point(186, 188);
            this.selo_lote.Name = "selo_lote";
            this.selo_lote.Size = new System.Drawing.Size(37, 20);
            this.selo_lote.TabIndex = 33;
            // 
            // setor_quadra
            // 
            this.setor_quadra.Location = new System.Drawing.Point(86, 189);
            this.setor_quadra.Name = "setor_quadra";
            this.setor_quadra.Size = new System.Drawing.Size(37, 20);
            this.setor_quadra.TabIndex = 34;
            // 
            // num_fam_dom
            // 
            this.num_fam_dom.Location = new System.Drawing.Point(627, 192);
            this.num_fam_dom.Name = "num_fam_dom";
            this.num_fam_dom.Size = new System.Drawing.Size(37, 20);
            this.num_fam_dom.TabIndex = 35;
            // 
            // num_pess_fam
            // 
            this.num_pess_fam.Location = new System.Drawing.Point(786, 197);
            this.num_pess_fam.Name = "num_pess_fam";
            this.num_pess_fam.Size = new System.Drawing.Size(37, 20);
            this.num_pess_fam.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Deficientes na família?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(174, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 26);
            this.label20.TabIndex = 38;
            this.label20.Text = "No de deficientes/\r\nPNE na família:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(345, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 26);
            this.label21.TabIndex = 39;
            this.label21.Text = "Possui cadeirante\r\nna família?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(527, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 26);
            this.label22.TabIndex = 40;
            this.label22.Text = "Há alguém com \r\ndificuldade demobilidade?";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(710, 234);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 26);
            this.label23.TabIndex = 41;
            this.label23.Text = "A família é cadastrada\r\nno Cadúnico?";
            // 
            // desficiente_fam
            // 
            this.desficiente_fam.AutoSize = true;
            this.desficiente_fam.Location = new System.Drawing.Point(130, 234);
            this.desficiente_fam.Name = "desficiente_fam";
            this.desficiente_fam.Size = new System.Drawing.Size(15, 14);
            this.desficiente_fam.TabIndex = 42;
            this.desficiente_fam.UseVisualStyleBackColor = true;
            // 
            // possui_cadeirante
            // 
            this.possui_cadeirante.AutoSize = true;
            this.possui_cadeirante.Location = new System.Drawing.Point(454, 234);
            this.possui_cadeirante.Name = "possui_cadeirante";
            this.possui_cadeirante.Size = new System.Drawing.Size(15, 14);
            this.possui_cadeirante.TabIndex = 43;
            this.possui_cadeirante.UseVisualStyleBackColor = true;
            // 
            // deficiencia_mobilidade
            // 
            this.deficiencia_mobilidade.AutoSize = true;
            this.deficiencia_mobilidade.Location = new System.Drawing.Point(662, 234);
            this.deficiencia_mobilidade.Name = "deficiencia_mobilidade";
            this.deficiencia_mobilidade.Size = new System.Drawing.Size(15, 14);
            this.deficiencia_mobilidade.TabIndex = 45;
            this.deficiencia_mobilidade.UseVisualStyleBackColor = true;
            // 
            // cadunico
            // 
            this.cadunico.AutoSize = true;
            this.cadunico.Location = new System.Drawing.Point(856, 233);
            this.cadunico.Name = "cadunico";
            this.cadunico.Size = new System.Drawing.Size(15, 14);
            this.cadunico.TabIndex = 46;
            this.cadunico.UseVisualStyleBackColor = true;
            // 
            // num_port_def
            // 
            this.num_port_def.Location = new System.Drawing.Point(275, 234);
            this.num_port_def.Name = "num_port_def";
            this.num_port_def.Size = new System.Drawing.Size(37, 20);
            this.num_port_def.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(48, 277);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 26);
            this.label24.TabIndex = 48;
            this.label24.Text = "No do NIS do \r\nresp. familiar:";
            // 
            // numero_nis
            // 
            this.numero_nis.Location = new System.Drawing.Point(121, 283);
            this.numero_nis.Name = "numero_nis";
            this.numero_nis.Size = new System.Drawing.Size(348, 20);
            this.numero_nis.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(493, 277);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 26);
            this.label25.TabIndex = 50;
            this.label25.Text = "Renda\r\nfamiliar (R$):";
            // 
            // renda_familiar
            // 
            this.renda_familiar.Location = new System.Drawing.Point(564, 283);
            this.renda_familiar.Name = "renda_familiar";
            this.renda_familiar.Size = new System.Drawing.Size(100, 20);
            this.renda_familiar.TabIndex = 51;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 492);
            this.Controls.Add(this.renda_familiar);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.numero_nis);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.num_port_def);
            this.Controls.Add(this.cadunico);
            this.Controls.Add(this.deficiencia_mobilidade);
            this.Controls.Add(this.possui_cadeirante);
            this.Controls.Add(this.desficiente_fam);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.num_pess_fam);
            this.Controls.Add(this.num_fam_dom);
            this.Controls.Add(this.setor_quadra);
            this.Controls.Add(this.selo_lote);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.mulher_resp_fam);
            this.Controls.Add(this.primeiro_no_domicilio);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nome_entrevistado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numero_logradouro);
            this.Controls.Add(this.area);
            this.Controls.Add(this.compl_logradouro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nome_logradouro);
            this.Controls.Add(this.tipo_logradouro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nome_subarea);
            this.Controls.Add(this.cod_area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "1 - Idêntificação";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.identificacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod_area;
        private System.Windows.Forms.TextBox nome_subarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tipo_logradouro;
        private System.Windows.Forms.TextBox nome_logradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compl_logradouro;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.TextBox numero_logradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nome_entrevistado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox primeiro_no_domicilio;
        private System.Windows.Forms.ComboBox mulher_resp_fam;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox selo_lote;
        private System.Windows.Forms.TextBox setor_quadra;
        private System.Windows.Forms.TextBox num_fam_dom;
        private System.Windows.Forms.TextBox num_pess_fam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox desficiente_fam;
        private System.Windows.Forms.CheckBox possui_cadeirante;
        private System.Windows.Forms.CheckBox deficiencia_mobilidade;
        private System.Windows.Forms.CheckBox cadunico;
        private System.Windows.Forms.TextBox num_port_def;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox numero_nis;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox renda_familiar;
        private System.Windows.Forms.BindingSource identificacaoBindingSource;
    }
}