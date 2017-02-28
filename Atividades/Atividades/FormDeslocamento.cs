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
    public partial class FormDeslocamento : Form
    {
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";
        public string codCidadeOrigem;
        public string codCidadeDestino;


        public FormDeslocamento()
        {
            InitializeComponent();
        }

        private void FormDeslocamento_Load(object sender, EventArgs e)
        {
            carregarUf();
        }

        public void carregarCodigoCidadeOrigem()
        {
            try
            {
                {
                    //consulta código da cidade origem
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmdOrigem = new SQLiteCommand("SELECT codCidade FROM tbCidades WHERE nomeCidade = '" + comboCidadeOrigem.Text.Trim() + "'", conn);
                    SQLiteDataReader lerOrigem = cmdOrigem.ExecuteReader();
                    lerOrigem.Read();
                    codCidadeOrigem = lerOrigem["codCidade"].ToString();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cidade não selecionada \n ");
            }
        }

        public void carregarUf()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT CodUf FROM tbUf", conn);
                    SQLiteDataAdapter daComboUF = new SQLiteDataAdapter(cmd);
                    DataTable dtComboUF = new DataTable();
                    daComboUF.Fill(dtComboUF);
                    foreach (DataRow drComboUF in dtComboUF.Rows)

                    {
                        comboUfDestino.Items.Add(drComboUF["codUf"]);
                        comboUfOrigem.Items.Add(drComboUF["codUf"]);

                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
