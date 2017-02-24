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


        // Classe que cumunicarpa com a gride
        public class gridProjetos
        {
            public int codProjeto { get; set; }
            public string nomeProjeto { get; set; }
            public int codGerente { get; set; }
            public string nomeGerente { get; set; }
            public string codUf { get; set; }
            public int codCidade { get; set; }
            public string nomeCidade { get; set; }
            

        }

        private void carregarGridProjetos()
        {

            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(
                @"SELECT at.codProjeto
                       ,at.nomeProjeto
                       ,at.codGerente
                       ,(SELECT NomePessoa FROM tbPessoas WHERE codPessoa = at.codGerente) nomeGerente
                       ,at.codUF
                       ,at.codCidade
                       ,(SELECT NomeCidade FROM tbCidades WHERE codCidade = at.codCidade) nomeCidade
                       
                FROM tbProjetos at", conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            List<gridProjetos> listGridAtividade = new List<gridProjetos>();
            while (dr.Read())
            {
                listGridAtividade.Add(new gridProjetos
                {
                    codProjeto = Convert.ToInt32(dr["codProjeto"]),
                    nomeProjeto = Convert.ToString(dr["nomeProjeto"]),
                    codGerente = Convert.ToInt32(dr["codGerente"]),
                    nomeGerente = Convert.ToString(dr["nomeCidade"]),
                    codUf = Convert.ToString(dr["saida1"]),
                    codCidade = Convert.ToInt32(dr["entrada2"]),
                    nomeCidade = Convert.ToString(dr["saida2"])
                    
                });
            }

            dataGridProjetos.DataSource = listGridAtividade;

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
                    conn.Close();

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            

        }
        public  class carregarProjetos
        {
            
            public void carregarCodigoGerente()
            {
                
                try
                {

                    {
                        FormProjeto projeto = new FormProjeto();
                        SQLiteConnection conn = new SQLiteConnection(connectBase);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand("SELECT codPessoa FROM tbPessoas WHERE nomePessoa = '" + projeto.comboGerente.Text.Trim() + "'", conn);
                        SQLiteDataReader ler = cmd.ExecuteReader();
                        ler.Read();
                        projeto.textCodGerente.Text = ler["codPessoa"].ToString();
                        conn.Close();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Gerente não selecionado \n ");
                }
            }
        }
        public void carregarCodigoGerente()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT codPessoa FROM tbPessoas WHERE nomePessoa = '" + comboGerente.Text.Trim() + "'", conn);
                    SQLiteDataReader ler = cmd.ExecuteReader();
                    ler.Read();
                    textCodGerente.Text = ler["codPessoa"].ToString();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gerente não selecionado \n ");
            }
        }
        public void carregarCodigoCidade()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT codCidade FROM tbCidades WHERE nomeCidade = '" + comboCidade.Text.Trim() + "'", conn);
                    SQLiteDataReader ler =  cmd.ExecuteReader();
                    ler.Read();
                    textCodCidade.Text = ler["codCidade"].ToString();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cidade não selecionada \n ");
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
                    conn.Close();

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
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nomeCidade FROM tbCidades WHERE codUf = '" + comboUF.Text.Trim() + "'", conn);
                    //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
                    SQLiteDataAdapter daComboCidade = new SQLiteDataAdapter(cmd);
                    DataTable dtComboCidade = new DataTable();
                    daComboCidade.Fill(dtComboCidade);
                    foreach (DataRow drComboCidade in dtComboCidade.Rows)

                    {
                        comboCidade.Items.Add(drComboCidade["nomeCidade"]);

                        


                    }
                    conn.Close();
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
            try
            {
                Convert.ToInt32(textCodProjeto.Text);
                {
                    
                    


                    if (comboGerente.Text.ToUpper() != Convert.ToString(comboGerente.SelectedItem) || textNomeProjeto.Text.Length < 4 || 
                        textCodProjeto.Text == string.Empty || comboUF.Text != Convert.ToString(comboUF.SelectedItem) ||
                        comboCidade.Text.ToUpper() != Convert.ToString(comboCidade.SelectedItem))
                    {
                        MessageBox.Show(@"Prencher todos os campos! \n 
Os campos UF, CIDADE e GERENTE DE PROJETO demve ser selecionados! \n
O campo NOME DO PROJETO deve ter no mínimo 4 caracteres!", "Atenção!");
                    }
                    
                    else
                    {
                        SQLiteConnection conn = new SQLiteConnection(connectBase);
                        MessageBox.Show(Convert.ToString("Entrada do botão " + conn.State));
                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tbProjetos (codProjeto, nomeProjeto, codGerente, codUF, codCidade)
                        VALUES(@codProjeto, @nomeProjeto, @codGerente, @codUF, @codCidade)", conn);

                        //captrua os valores para os parametros do sql
                        cmd.Parameters.AddWithValue("codProjeto", textCodProjeto.Text.Trim());
                        cmd.Parameters.AddWithValue("nomeProjeto", textNomeProjeto.Text.ToUpper().Trim());
                        cmd.Parameters.AddWithValue("codGerente", textCodGerente.Text.Trim());
                        cmd.Parameters.AddWithValue("codUF", comboUF.Text.Trim());
                        cmd.Parameters.AddWithValue("codCidade", textCodCidade.Text.Trim());


                        try
                        {
                            cmd.ExecuteNonQuery();
                            textCodProjeto.Text = string.Empty;
                            textNomeProjeto.Text = string.Empty;
                            textNomeProjeto.Text = string.Empty;
                            textCodCidade.Text = string.Empty;
                            textCodCidade.Text = string.Empty;
                            comboCidade.Text = string.Empty;
                            comboUF.Text = string.Empty;
                            comboGerente.Text = string.Empty;
                            
                            conn.Close();
                            carregarGridProjetos();
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Inserir Dados \n" + ex.Message);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("O campo Código deve conter somente caracteres noméricos.");
                textCodProjeto.Text = string.Empty;
            }

           
        }

        private void comboCidade_Enter(object sender, EventArgs e)
        {

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidades Cidade = new FormCidades();
            Cidade.ShowDialog();
        }

        private void comboGerente_Leave(object sender, EventArgs e)
        {
            
        }

        private void comboCidade_Leave(object sender, EventArgs e)
        {

        }

        private void comboGerente_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigoGerente();
        }

        private void FormProjeto_Activated(object sender, EventArgs e)
        {
            comboGerente.Items.Clear();
            comboUF.Items.Clear();
            carregarComboGerente();
            carregarUF();
        }

        private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCidade.Items.Clear();
            carregarCidade();
        }

        private void FormProjeto_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
