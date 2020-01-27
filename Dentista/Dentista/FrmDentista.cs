using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dentista
{
    public partial class FrmDentista : Form,Icadform

    {
        Dentista objDentista;
        Conexao con = new Conexao();
        public FrmDentista()
        {
            InitializeComponent();
            con = new Conexao();
        }
        // criando limparcampo 
        public void limparcampo()
        {
            Txt_ID.Text = "";
            Txt_Nome.Text = "";
            Txt_CRO.Text = "";
        }
        // criando desbloquear campo
        private void desbloquearcampo()
        {
            Txt_ID.ReadOnly = false;
            Txt_Nome.ReadOnly = false;
            Txt_CRO.ReadOnly = false;
        }
        // criando bloquear campo
        private void bloquearcampo()
        {
            Txt_ID.ReadOnly = true;
            Txt_Nome.ReadOnly = true;
            Txt_CRO.ReadOnly = true;
        }
        //Ler dados já criados
        public void lerdados()
        {
            objDentista = new Dentista();
            objDentista.ID = int.Parse(Txt_ID.Text.Trim());
            objDentista.nome = Txt_Nome.Text;
            objDentista.CRO = Txt_CRO.Text;

            objDentista.Instagran = CH_Instagram.Checked ? 1 : 0;
            objDentista.Facebook = CH_Facebook.Checked ? 1 : 0;
            objDentista.Twitter = CH_Twitter.Checked ? 1 : 0;
            objDentista.Linkedin = CH_Linkedin.Checked ? 1 : 0;

            if (RB_Feminino.Checked)
            {
                objDentista.sexo = "F";
            }
            else
            {
                objDentista.sexo = "M";
            }

        }
        // lista do banco de dados para aparecer no GRID VIEW
        public void atualizargrid()
        {
            List<Dentista> listDentista = new List<Dentista>();
            con.Conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from TB_Dentista");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dentista dentista = new Dentista();
                    dentista.ID = reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);
                    dentista.CRO = reader.GetString(2);
                    dentista.sexo = reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString();
                    dentista.Instagran = reader.GetValue(4).ToString() == "True" ? 1 : 0;
                    dentista.Twitter = reader.GetValue(5).ToString() == "True" ? 1 : 0;
                    dentista.Facebook = reader.GetValue(6).ToString() == "True" ? 1 : 0;
                    dentista.Linkedin = reader.GetValue(7).ToString() == "True" ? 1 : 0;
                    listDentista.Add(dentista);
                }
                reader.Close();
            }
            //DTGW caso não abra
            else
            {
                Console.WriteLine("Inválido");
            }
            Dt_Dentista.DataSource = null;
            Dt_Dentista.DataSource = listDentista;

        }
        // LOAD carregar informações Gridview
        private void FrmDentista_Load(object sender, EventArgs e)
        {
            atualizargrid();
            bloquearcampo();
        }


        private void Btn_Novo_Click(object sender, EventArgs e)
        {

            limparcampo();
            desbloquearcampo();
            Txt_ID.Focus();



        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into TB_Dentista values(" + objDentista.ID + ",'" +
                objDentista.nome + "','"
                +objDentista.CRO+"','"
                + objDentista.sexo + "',"
                + objDentista.Instagran + ","
                + objDentista.Facebook + ","
                + objDentista.Twitter + ","
                + objDentista.Linkedin + ")";
            con.Conectar();
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados Salvos com Sucesso");

            }
            else
            {
                MessageBox.Show("Erro!");
            }
            bloquearcampo();
            atualizargrid();


        }

        private void Dt_Dentista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = Dt_Dentista.CurrentRow.Cells[0].Value.ToString();
            Txt_Nome.Text = Dt_Dentista.CurrentRow.Cells[1].Value.ToString();
            Txt_CRO.Text = Dt_Dentista.CurrentRow.Cells[2].Value.ToString();
            RB_Feminino.Checked = Dt_Dentista.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            RB_Masculino.Checked = Dt_Dentista.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            CH_Instagram.Checked = Dt_Dentista.CurrentRow.Cells[4].Value.Equals(1);
            CH_Facebook.Checked = Dt_Dentista.CurrentRow.Cells[5].Value.Equals(1);
            CH_Twitter.Checked = Dt_Dentista.CurrentRow.Cells[6].Value.Equals(1);
            CH_Linkedin.Checked = Dt_Dentista.CurrentRow.Cells[7].Value.Equals(1);
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text.Equals(""))
            {
                MessageBox.Show("Clique em um campo primeiro");
            }
            else
            {
                String sql = "Delete from TB_Dentista where id=" + Txt_ID.Text;
                con.executar(sql);
                atualizargrid();
            }
        }


    }
    }

