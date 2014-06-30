namespace LaborSoft
{
    partial class Form8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.numero_logradouro = new System.Windows.Forms.MaskedTextBox();
            this.complemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tel_celular = new System.Windows.Forms.MaskedTextBox();
            this.tel_recado = new System.Windows.Forms.TextBox();
            this.tel_comercial = new System.Windows.Forms.MaskedTextBox();
            this.tel_residencial = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bairro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cep);
            this.groupBox1.Controls.Add(this.numero_logradouro);
            this.groupBox1.Controls.Add(this.complemento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.logradouro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tel_celular);
            this.groupBox1.Controls.Add(this.tel_recado);
            this.groupBox1.Controls.Add(this.tel_comercial);
            this.groupBox1.Controls.Add(this.tel_residencial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "7";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(871, 102);
            this.cep.Mask = "00000-000";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(57, 20);
            this.cep.TabIndex = 15;
            // 
            // numero_logradouro
            // 
            this.numero_logradouro.Location = new System.Drawing.Point(62, 103);
            this.numero_logradouro.Name = "numero_logradouro";
            this.numero_logradouro.Size = new System.Drawing.Size(118, 20);
            this.numero_logradouro.TabIndex = 14;
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(264, 103);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(397, 20);
            this.complemento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(834, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número:";
            // 
            // logradouro
            // 
            this.logradouro.Location = new System.Drawing.Point(177, 60);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(779, 20);
            this.logradouro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço para correspondência:";
            // 
            // tel_celular
            // 
            this.tel_celular.Location = new System.Drawing.Point(325, 13);
            this.tel_celular.Name = "tel_celular";
            this.tel_celular.Size = new System.Drawing.Size(118, 20);
            this.tel_celular.TabIndex = 7;
            // 
            // tel_recado
            // 
            this.tel_recado.Location = new System.Drawing.Point(816, 13);
            this.tel_recado.Name = "tel_recado";
            this.tel_recado.Size = new System.Drawing.Size(140, 20);
            this.tel_recado.TabIndex = 6;
            // 
            // tel_comercial
            // 
            this.tel_comercial.Location = new System.Drawing.Point(555, 13);
            this.tel_comercial.Mask = "(00) 0000-0000";
            this.tel_comercial.Name = "tel_comercial";
            this.tel_comercial.Size = new System.Drawing.Size(100, 20);
            this.tel_comercial.TabIndex = 5;
            // 
            // tel_residencial
            // 
            this.tel_residencial.Location = new System.Drawing.Point(118, 16);
            this.tel_residencial.Mask = "(00) 0000-0000";
            this.tel_residencial.Name = "tel_residencial";
            this.tel_residencial.Size = new System.Drawing.Size(100, 20);
            this.tel_residencial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone de recado / nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone comercial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone residencial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bairro:";
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(717, 102);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(100, 20);
            this.bairro.TabIndex = 17;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "7 - Dados de Contato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox cep;
        private System.Windows.Forms.MaskedTextBox numero_logradouro;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox logradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tel_celular;
        private System.Windows.Forms.TextBox tel_recado;
        private System.Windows.Forms.MaskedTextBox tel_comercial;
        private System.Windows.Forms.MaskedTextBox tel_residencial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label9;
    }
}