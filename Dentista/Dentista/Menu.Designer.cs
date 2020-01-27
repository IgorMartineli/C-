namespace Dentista
{
    partial class Menu
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
            this.Btn_Dentista = new System.Windows.Forms.Button();
            this.Btn_Paciente = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Dentista
            // 
            this.Btn_Dentista.Location = new System.Drawing.Point(115, 287);
            this.Btn_Dentista.Name = "Btn_Dentista";
            this.Btn_Dentista.Size = new System.Drawing.Size(227, 106);
            this.Btn_Dentista.TabIndex = 0;
            this.Btn_Dentista.Text = "Dentista";
            this.Btn_Dentista.UseVisualStyleBackColor = true;
            // 
            // Btn_Paciente
            // 
            this.Btn_Paciente.Location = new System.Drawing.Point(115, 163);
            this.Btn_Paciente.Name = "Btn_Paciente";
            this.Btn_Paciente.Size = new System.Drawing.Size(227, 106);
            this.Btn_Paciente.TabIndex = 1;
            this.Btn_Paciente.Text = "Paciente";
            this.Btn_Paciente.UseVisualStyleBackColor = true;
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.Location = new System.Drawing.Point(115, 40);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(227, 106);
            this.Btn_Consulta.TabIndex = 2;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = true;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 436);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.Btn_Paciente);
            this.Controls.Add(this.Btn_Dentista);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Dentista;
        private System.Windows.Forms.Button Btn_Paciente;
        private System.Windows.Forms.Button Btn_Consulta;
    }
}