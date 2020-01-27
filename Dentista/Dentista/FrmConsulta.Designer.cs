namespace Dentista
{
    partial class FrmConsulta
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
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Dentista = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmb_Paciente = new System.Windows.Forms.ComboBox();
            this.Txt_MRetorno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Receita = new System.Windows.Forms.TextBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Retorno = new System.Windows.Forms.DateTimePicker();
            this.DT_Consulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ID_Consulta = new System.Windows.Forms.TextBox();
            this.ID_consulta_lbl = new System.Windows.Forms.Label();
            this.DTGW_Consulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(18, 19);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(112, 23);
            this.Btn_Novo.TabIndex = 0;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(147, 19);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(110, 23);
            this.Btn_Salvar.TabIndex = 1;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Excluir);
            this.groupBox1.Controls.Add(this.Btn_Cancelar);
            this.groupBox1.Controls.Add(this.Btn_Salvar);
            this.groupBox1.Controls.Add(this.Btn_Novo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(401, 19);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(114, 23);
            this.Btn_Excluir.TabIndex = 3;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(273, 19);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(112, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Cmb_Dentista);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Cmb_Paciente);
            this.groupBox2.Controls.Add(this.Txt_MRetorno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_Diagnostico);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txt_Receita);
            this.groupBox2.Controls.Add(this.Txt_Motivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DT_Retorno);
            this.groupBox2.Controls.Add(this.DT_Consulta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Txt_ID_Consulta);
            this.groupBox2.Controls.Add(this.ID_consulta_lbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nome do  Dentista";
            // 
            // Cmb_Dentista
            // 
            this.Cmb_Dentista.FormattingEnabled = true;
            this.Cmb_Dentista.Location = new System.Drawing.Point(107, 94);
            this.Cmb_Dentista.Name = "Cmb_Dentista";
            this.Cmb_Dentista.Size = new System.Drawing.Size(255, 21);
            this.Cmb_Dentista.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nome do Paciente";
            // 
            // Cmb_Paciente
            // 
            this.Cmb_Paciente.FormattingEnabled = true;
            this.Cmb_Paciente.Location = new System.Drawing.Point(107, 121);
            this.Cmb_Paciente.Name = "Cmb_Paciente";
            this.Cmb_Paciente.Size = new System.Drawing.Size(255, 21);
            this.Cmb_Paciente.TabIndex = 18;
            // 
            // Txt_MRetorno
            // 
            this.Txt_MRetorno.Location = new System.Drawing.Point(107, 226);
            this.Txt_MRetorno.Name = "Txt_MRetorno";
            this.Txt_MRetorno.Size = new System.Drawing.Size(408, 20);
            this.Txt_MRetorno.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motivo do Retorno";
            // 
            // Txt_Diagnostico
            // 
            this.Txt_Diagnostico.Location = new System.Drawing.Point(75, 200);
            this.Txt_Diagnostico.Name = "Txt_Diagnostico";
            this.Txt_Diagnostico.Size = new System.Drawing.Size(440, 20);
            this.Txt_Diagnostico.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Diagnostico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Receita";
            // 
            // Txt_Receita
            // 
            this.Txt_Receita.Location = new System.Drawing.Point(60, 174);
            this.Txt_Receita.Name = "Txt_Receita";
            this.Txt_Receita.Size = new System.Drawing.Size(455, 20);
            this.Txt_Receita.TabIndex = 12;
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Location = new System.Drawing.Point(60, 148);
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(455, 20);
            this.Txt_Motivo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data do Retorno";
            // 
            // DT_Retorno
            // 
            this.DT_Retorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Retorno.Location = new System.Drawing.Point(363, 61);
            this.DT_Retorno.Name = "DT_Retorno";
            this.DT_Retorno.Size = new System.Drawing.Size(112, 20);
            this.DT_Retorno.TabIndex = 8;
            // 
            // DT_Consulta
            // 
            this.DT_Consulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Consulta.Location = new System.Drawing.Point(119, 61);
            this.DT_Consulta.Name = "DT_Consulta";
            this.DT_Consulta.Size = new System.Drawing.Size(112, 20);
            this.DT_Consulta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data da Consulta";
            // 
            // Txt_ID_Consulta
            // 
            this.Txt_ID_Consulta.Location = new System.Drawing.Point(119, 25);
            this.Txt_ID_Consulta.Name = "Txt_ID_Consulta";
            this.Txt_ID_Consulta.Size = new System.Drawing.Size(112, 20);
            this.Txt_ID_Consulta.TabIndex = 5;
            // 
            // ID_consulta_lbl
            // 
            this.ID_consulta_lbl.AutoSize = true;
            this.ID_consulta_lbl.Location = new System.Drawing.Point(6, 28);
            this.ID_consulta_lbl.Name = "ID_consulta_lbl";
            this.ID_consulta_lbl.Size = new System.Drawing.Size(77, 13);
            this.ID_consulta_lbl.TabIndex = 4;
            this.ID_consulta_lbl.Text = "ID da Consulta";
            // 
            // DTGW_Consulta
            // 
            this.DTGW_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGW_Consulta.Location = new System.Drawing.Point(12, 365);
            this.DTGW_Consulta.Name = "DTGW_Consulta";
            this.DTGW_Consulta.Size = new System.Drawing.Size(532, 187);
            this.DTGW_Consulta.TabIndex = 4;
            this.DTGW_Consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGW_Consulta_CellClick);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 564);
            this.Controls.Add(this.DTGW_Consulta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsulta";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_Retorno;
        private System.Windows.Forms.DateTimePicker DT_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ID_Consulta;
        private System.Windows.Forms.Label ID_consulta_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_MRetorno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Diagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Receita;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.ComboBox Cmb_Paciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Dentista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DTGW_Consulta;
    }
}