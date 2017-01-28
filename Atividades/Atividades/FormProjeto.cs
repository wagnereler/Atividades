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
    public partial class FormProjeto : Form
    {
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";

        public FormProjeto()
        {
            InitializeComponent();
        }

        private void FormProjeto_Load(object sender, EventArgs e)
        {
            carregarComboGerente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void carregarComboGerente()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nomePessoa FROM tbPessoas WHERE Gerente = 1", conn);
                    //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
                    SQLiteDataAdapter daComboGerente = new SQLiteDataAdapter(cmd);
                    DataTable dtComboGerente = new DataTable();
                    daComboGerente.Fill(dtComboGerente);
                    foreach (DataRow drComboGerente in dtComboGerente.Rows)

                    {
                        comboGerente.Items.Add(drComboGerente["nomePessoa"]);

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
