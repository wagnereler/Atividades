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
    public partial class FormCidades : Form
    {
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";
        public FormCidades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            carregarUF();
        }
        public void carregarUF()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT CodUf FROM tbUf", conn);
                    //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
                    SQLiteDataAdapter daComboUF = new SQLiteDataAdapter(cmd);
                    DataTable dtComboUF = new DataTable();
                    daComboUF.Fill(dtComboUF);
                    foreach (DataRow drComboUF in dtComboUF.Rows)

                    {
                        comboCadatroUF.Items.Add(drComboUF["codUf"]);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            {
                SQLiteConnection conn = new SQLiteConnection(connectBase);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (comboCadatroUF.Text.ToUpper() != Convert.ToString(comboCadatroUF.SelectedItem) || comboCadatroUF.Text == string.Empty)
                {
                    MessageBox.Show("Selecione uma UF");
                }
                
                else
                {
                    SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tbCidades (codUf, nomeCidade)
                    VALUES(@codUf, @nomeCidade)", conn);

                    //captrua os valores para os parametros do sql
                    cmd.Parameters.AddWithValue("codUf", comboCadatroUF.Text.Trim());
                    cmd.Parameters.AddWithValue("nomeCidade", textCadastroCidade.Text.Trim());
              

                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        textCadastroCidade.Text = string.Empty;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Criar Banco de Dados" + ex.Message);
                    }
                }
            }
        }
    }
}
