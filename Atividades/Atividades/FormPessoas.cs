using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Atividades
{
    public partial class FormPessoas : Form
    {
       
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";
        private string owner;
        

        public FormPessoas()
        {
            InitializeComponent();
            
        }

        public class gridPessoas
        {
            public string NomePessoa { get; set; }
            public bool Gerente { get; set; }
            public bool colaborador { get; set; }
        }


        private void carregarGridPessoass()
        {

            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(
                @"SELECT NomePessoa
                       ,Gerente
                       ,colaborador   
                FROM tbPessoas", conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            List<gridPessoas> listGridPessoas = new List<gridPessoas>();
            while (dr.Read())
            {
                listGridPessoas.Add(new gridPessoas
                {
                    NomePessoa = Convert.ToString(dr["NomePessoa"]),
                    Gerente = Convert.ToBoolean(dr["Gerente"]),
                    colaborador = Convert.ToBoolean(dr["colaborador"])
                });
            }
            dataGridPessoas.DataSource = listGridPessoas;

        }




        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butInserirPessoa_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            if (radioUsuarioPadrao.Checked == false & radioGerente.Checked == false || textNomePessoa.Text == string.Empty)
            {
                MessageBox.Show("Verifique se as informações foram preenchidas \b E se o tipo de pessoa foi selecionado");
            }else
            {
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tbPessoas (NomePessoa, Gerente, colaborador)
            VALUES(@nomePessoa, @Gerente, @colaborador)", conn);

                //captrua os valores para os parametros do sql
                cmd.Parameters.AddWithValue("NomePessoa", textNomePessoa.Text.Trim().ToUpper());
                //convert verifica se é falso e converte para zero

                if (radioGerente.Checked == true)
                {
                    cmd.Parameters.AddWithValue("Gerente", "1");
                }
                else
                {
                    cmd.Parameters.AddWithValue("Gerente", "0");
                }
                if (radioUsuarioPadrao.Checked == true)
                {
                    cmd.Parameters.AddWithValue("colaborador", "1");
                }
                else
                {
                    cmd.Parameters.AddWithValue("colaborador", "0");
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    textNomePessoa.Clear();
                    radioGerente.Checked = false;
                    radioUsuarioPadrao.Checked = false;
                    carregarGridPessoass();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Criar Banco de Dados" + ex.Message);
                }
            }
        }

        private void FormPessoas_Load(object sender, EventArgs e)
        {
            carregarGridPessoass();
        }
    }

   
}
