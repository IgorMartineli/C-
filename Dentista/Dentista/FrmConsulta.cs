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
    public partial class FrmConsulta : Form
    {
        Consulta objConsulta;
        Conexao con = new Conexao();
        public FrmConsulta()
        {
            InitializeComponent();
            con = new Conexao();
        }
        // criando limparcampo 
        public void limparcampo()
        {
            Txt_ID_Consulta.Text = "";
            Txt_Motivo.Text = "";
            Txt_Diagnostico.Text = "";
            Txt_MRetorno.Text = "";
            Txt_Receita.Text = "";
        }
        // criando desbloquear campo
        private void desbloquearcampo()
        {

            Txt_ID_Consulta.ReadOnly = false;
            Txt_Motivo.ReadOnly = false;
            Txt_Diagnostico.ReadOnly = false;
            Txt_MRetorno.ReadOnly = false;
            Txt_Receita.ReadOnly = false;
            DT_Consulta.Value = DateTime.Today;
            DT_Retorno.Value = DateTime.Today;

        }
        // criando bloquear campo
        private void bloquearcampo()
        {
            Txt_ID_Consulta.ReadOnly = true;
            Txt_Motivo.ReadOnly = true;
            Txt_Diagnostico.ReadOnly = true;
            Txt_MRetorno.ReadOnly = true;
            Txt_Receita.ReadOnly = true;
           
                DT_Consulta.Value = DateTime.Today;
            DT_Retorno.Value = DateTime.Today;
                




        }
        //Ler Dados
        public void lerdados()
        {
            objConsulta = new Consulta();
            objConsulta.IDConsulta = int.Parse(Txt_ID_Consulta.Text.Trim());
            objConsulta.IDdentista = int.Parse(Cmb_Dentista.SelectedValue.ToString());
            objConsulta.IDPaciente = int.Parse(Cmb_Paciente.SelectedValue.ToString());
            objConsulta.Motivo = Txt_Motivo.Text;
            objConsulta.Receita = Txt_Receita.Text;
            objConsulta.Diagnostico = Txt_Diagnostico.Text;
            objConsulta.MotivoR = Txt_MRetorno.Text;
            objConsulta.DTconsulta = DT_Consulta.Value;
            objConsulta.DTretorno = DT_Retorno.Value;
        }
        // lista do banco dados para aparecer no GRID VIEW
        public void atualizargrid()
        {
            List<Consulta> listConsulta = new List<Consulta>();
            con.Conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from TB_Consulta");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.IDConsulta = reader.GetInt32(0);
                    consulta.Motivo = reader.GetString(1);
                    consulta.DTconsulta = reader.GetDateTime(2);
                    consulta.Receita = reader.GetString(3);
                    consulta.Diagnostico = reader.GetString(4);
                    consulta.DTretorno = reader.GetDateTime(5);
                    consulta.MotivoR = reader.GetString(6);
                    consulta.IDPaciente = reader.GetInt32(7);
                    consulta.IDdentista = reader.GetInt32(8);
                    listConsulta.Add(consulta);

                }
                reader.Close();
            }
            // caso DTGW nao abra 

            else
            {
                Console.WriteLine("Inválido");
            }
            DTGW_Consulta.DataSource = null;
            DTGW_Consulta.DataSource = listConsulta;
        }

        // LOAD carregar informações Gridview
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            atualizargrid();
            bloquearcampo();
            preecheCmbDentista();
            preecheCmbPaciente();

        }
        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            limparcampo();
            desbloquearcampo();
            Txt_ID_Consulta.Focus();

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into TB_Consulta values(" + objConsulta.IDConsulta + ",'"
                + objConsulta.Motivo + "','"
                + objConsulta.DTconsulta + "','"
                + objConsulta.Receita + "','"
                + objConsulta.Diagnostico + "','"
                + objConsulta.DTretorno + "','"
                + objConsulta.MotivoR + "',"
                + objConsulta.IDPaciente + ","
                + objConsulta.IDdentista + ")";
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

        private void DTGW_Consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID_Consulta.Text = DTGW_Consulta.CurrentRow.Cells[0].Value.ToString();
            Txt_Motivo.Text = DTGW_Consulta.CurrentRow.Cells[1].Value.ToString();
            DT_Consulta.Value = DateTime.Parse(DTGW_Consulta.CurrentRow.Cells[2].Value.ToString());
            Txt_Receita.Text = DTGW_Consulta.CurrentRow.Cells[3].Value.ToString();
            Txt_Diagnostico.Text = DTGW_Consulta.CurrentRow.Cells[4].Value.ToString();
            DT_Retorno.Value = DateTime.Parse(DTGW_Consulta.CurrentRow.Cells[3].Value.ToString());
            Txt_MRetorno.Text = DTGW_Consulta.CurrentRow.Cells[5].Value.ToString();
            Cmb_Paciente.Text = DTGW_Consulta.CurrentRow.Cells[6].Value.ToString();
            Cmb_Dentista.Text = DTGW_Consulta.CurrentRow.Cells[7].Value.ToString();

        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Txt_ID_Consulta.Text.Equals(""))
            {
                MessageBox.Show("Clique em um campo primeiro");
            }
            else
            {
                String sql = "Delete from TB_Consulta where id=" + Txt_ID_Consulta.Text;
                con.executar(sql);
                atualizargrid();
            }
        }

        private void preecheCmbDentista()
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
                    listDentista.Add(dentista);
                }
                reader.Close();
            }
            //DTGW caso não abra
            else
            {
                Console.WriteLine("Inválido");
            }
            Cmb_Dentista.DataSource = null;
            Cmb_Dentista.DataSource = listDentista;
            Cmb_Dentista.DisplayMember = "nome";
            Cmb_Dentista.ValueMember = "ID";
        }

        private void preecheCmbPaciente()
        {
            List<Paciente> listPaciente = new List<Paciente>();
            con.Conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from TB_Paciente");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   Paciente paciente = new Paciente();
                    paciente.ID = reader.GetInt32(0);
                    paciente.nome = reader.GetString(1);
                    listPaciente.Add(paciente);
                }
                reader.Close();
            }
            //DTGW caso não abra
            else
            {
                Console.WriteLine("Inválido");
            }
            Cmb_Paciente.DataSource = null;
            Cmb_Paciente.DataSource = listPaciente;
            Cmb_Paciente.DisplayMember = "Nome";
            Cmb_Paciente.ValueMember = "ID";
        }

    }

}

