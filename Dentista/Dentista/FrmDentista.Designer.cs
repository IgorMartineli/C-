namespace Dentista
{
    partial class FrmDentista
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
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_CRO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Masculino = new System.Windows.Forms.RadioButton();
            this.RB_Feminino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CH_Linkedin = new System.Windows.Forms.CheckBox();
            this.CH_Twitter = new System.Windows.Forms.CheckBox();
            this.CH_Facebook = new System.Windows.Forms.CheckBox();
            this.CH_Instagram = new System.Windows.Forms.CheckBox();
            this.Dt_Dentista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Dentista)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(10, 16);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 0;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(118, 16);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 1;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(260, 16);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(377, 16);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 3;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_CRO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Nome);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // Txt_CRO
            // 
            this.Txt_CRO.Location = new System.Drawing.Point(248, 61);
            this.Txt_CRO.Name = "Txt_CRO";
            this.Txt_CRO.Size = new System.Drawing.Size(150, 20);
            this.Txt_CRO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(41, 31);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(357, 20);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(41, 61);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(151, 20);
            this.Txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Masculino);
            this.groupBox2.Controls.Add(this.RB_Feminino);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CH_Linkedin);
            this.groupBox2.Controls.Add(this.CH_Twitter);
            this.groupBox2.Controls.Add(this.CH_Facebook);
            this.groupBox2.Controls.Add(this.CH_Instagram);
            this.groupBox2.Location = new System.Drawing.Point(15, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rede Sociais";
            // 
            // RB_Masculino
            // 
            this.RB_Masculino.AutoSize = true;
            this.RB_Masculino.Location = new System.Drawing.Point(351, 50);
            this.RB_Masculino.Name = "RB_Masculino";
            this.RB_Masculino.Size = new System.Drawing.Size(73, 17);
            this.RB_Masculino.TabIndex = 6;
            this.RB_Masculino.TabStop = true;
            this.RB_Masculino.Text = "Masculino";
            this.RB_Masculino.UseVisualStyleBackColor = true;
            // 
            // RB_Feminino
            // 
            this.RB_Feminino.AutoSize = true;
            this.RB_Feminino.Location = new System.Drawing.Point(351, 27);
            this.RB_Feminino.Name = "RB_Feminino";
            this.RB_Feminino.Size = new System.Drawing.Size(67, 17);
            this.RB_Feminino.TabIndex = 5;
            this.RB_Feminino.TabStop = true;
            this.RB_Feminino.Text = "Feminino";
            this.RB_Feminino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // CH_Linkedin
            // 
            this.CH_Linkedin.AutoSize = true;
            this.CH_Linkedin.Location = new System.Drawing.Point(93, 51);
            this.CH_Linkedin.Name = "CH_Linkedin";
            this.CH_Linkedin.Size = new System.Drawing.Size(66, 17);
            this.CH_Linkedin.TabIndex = 3;
            this.CH_Linkedin.Text = "Linkedin";
            this.CH_Linkedin.UseVisualStyleBackColor = true;
            // 
            // CH_Twitter
            // 
            this.CH_Twitter.AutoSize = true;
            this.CH_Twitter.Location = new System.Drawing.Point(93, 28);
            this.CH_Twitter.Name = "CH_Twitter";
            this.CH_Twitter.Size = new System.Drawing.Size(58, 17);
            this.CH_Twitter.TabIndex = 2;
            this.CH_Twitter.Text = "Twitter";
            this.CH_Twitter.UseVisualStyleBackColor = true;
            // 
            // CH_Facebook
            // 
            this.CH_Facebook.AutoSize = true;
            this.CH_Facebook.Location = new System.Drawing.Point(6, 51);
            this.CH_Facebook.Name = "CH_Facebook";
            this.CH_Facebook.Size = new System.Drawing.Size(74, 17);
            this.CH_Facebook.TabIndex = 1;
            this.CH_Facebook.Text = "Facebook";
            this.CH_Facebook.UseVisualStyleBackColor = true;
            // 
            // CH_Instagram
            // 
            this.CH_Instagram.AutoSize = true;
            this.CH_Instagram.Location = new System.Drawing.Point(6, 28);
            this.CH_Instagram.Name = "CH_Instagram";
            this.CH_Instagram.Size = new System.Drawing.Size(70, 17);
            this.CH_Instagram.TabIndex = 0;
            this.CH_Instagram.Text = "Instagran";
            this.CH_Instagram.UseVisualStyleBackColor = true;
            // 
            // Dt_Dentista
            // 
            this.Dt_Dentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Dentista.Location = new System.Drawing.Point(15, 283);
            this.Dt_Dentista.Name = "Dt_Dentista";
            this.Dt_Dentista.Size = new System.Drawing.Size(437, 115);
            this.Dt_Dentista.TabIndex = 6;
            this.Dt_Dentista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dt_Dentista_CellClick);
            // 
            // FrmDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 410);
            this.Controls.Add(this.Dt_Dentista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_Novo);
            this.Name = "FrmDentista";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Dentista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_CRO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CH_Linkedin;
        private System.Windows.Forms.CheckBox CH_Twitter;
        private System.Windows.Forms.CheckBox CH_Facebook;
        private System.Windows.Forms.CheckBox CH_Instagram;
        private System.Windows.Forms.RadioButton RB_Masculino;
        private System.Windows.Forms.RadioButton RB_Feminino;
        private System.Windows.Forms.DataGridView Dt_Dentista;
    }
}

