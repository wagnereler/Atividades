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
            comboGerente.Items.Clear();
            comboUF.Items.Clear();
            carregarComboGerente();
            carregarUF();
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
                        comboUF.Items.Add(drComboUF["codUf"]);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


        }
        public void carregarCidade()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nomeCidade FROM tbCidades WHERE codUf = '" + comboUF.Text + "'", conn);
                    //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
                    SQLiteDataAdapter daComboCidade = new SQLiteDataAdapter(cmd);
                    DataTable dtComboCidade = new DataTable();
                    daComboCidade.Fill(dtComboCidade);
                    foreach (DataRow drComboCidade in dtComboCidade.Rows)

                    {
                        comboCidade.Items.Add(drComboCidade["nomeCidade"]);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoas Pessoas = new FormPessoas();
            Pessoas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboCidade_Enter(object sender, EventArgs e)
        {
            comboCidade.Items.Clear();
            comboCidade.Text = string.Empty;
            carregarCidade();
            MessageBox.Show("Lista Carregada");
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidades Cidade = new FormCidades();
            Cidade.ShowDialog();
        }
    }
    }
