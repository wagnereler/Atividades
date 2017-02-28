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
        public string codProjetoVinculado;


        public FormDeslocamento()
        {
            InitializeComponent();
        }

        private void FormDeslocamento_Load(object sender, EventArgs e)
        {
            carregarUf();
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
        public void carregarCidadeOrigem()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nomeCidade FROM tbCidades WHERE codUf = '" + comboUfOrigem.Text.Trim() + "'", conn);
                    SQLiteDataAdapter daComboCidade = new SQLiteDataAdapter(cmd);
                    DataTable dtComboCidade = new DataTable();
                    daComboCidade.Fill(dtComboCidade);
                    foreach (DataRow drComboCidade in dtComboCidade.Rows)

                    {
                        comboCidadeOrigem.Items.Add(drComboCidade["nomeCidade"]);

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

        }
        public void carregarCidadeDestino()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nomeCidade FROM tbCidades WHERE codUf = '" + comboUfDestino.Text.Trim() + "'", conn);
                    SQLiteDataAdapter daComboCidade = new SQLiteDataAdapter(cmd);
                    DataTable dtComboCidade = new DataTable();
                    daComboCidade.Fill(dtComboCidade);
                    foreach (DataRow drComboCidade in dtComboCidade.Rows)

                    {
                        comboCidadeDestino.Items.Add(drComboCidade["nomeCidade"]);

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

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
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void carregarCodigoCidadeDestino()
        {
            try
            {
                {
                    //consulta código da cidade origem
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmdOrigem = new SQLiteCommand("SELECT codCidade FROM tbCidades WHERE nomeCidade = '" + comboCidadeDestino.Text.Trim() + "'", conn);
                    SQLiteDataReader lerOrigem = cmdOrigem.ExecuteReader();
                    lerOrigem.Read();
                    codCidadeDestino = lerOrigem["codCidade"].ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void carregarCodigoProjeto()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT codProjeto FROM tbProjetos WHERE nomeProjeto = '" + comboProjetoVinculado.Text.Trim() + "'", conn);
                    SQLiteDataReader ler = cmd.ExecuteReader();
                    ler.Read();
                    codProjetoVinculado = ler["codProjeto"].ToString();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o gerente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //Formata campo hora início para o formato adequado
        private void validaHoraOrigem(object sender, EventArgs e)
        {
            string Entrada = textHoraInicio.Text.Trim();
            int z = Entrada.Length;
            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        textHoraInicio.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            textHoraInicio.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            textHoraInicio.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            textHoraInicio.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            textHoraInicio.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        textHoraInicio.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = textHoraInicio.Text.Substring(0, 2);
                    string b = textHoraInicio.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("O  formato da hora está incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textHoraInicio.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("O  formato da hora está incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textHoraInicio.Focus();
                    }
                    //calculando valor em minutos
                    int minutosEntrada1 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));

                }
                catch
                {
                    MessageBox.Show("Só é permitido caracteres numéricos. Não utilize ':' ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textHoraInicio.Text = String.Empty;
                    textHoraInicio.Focus();
                }
            }

        }
        //Formata campo hora termino para o formato adequado
        private void validaHoraDestino(object sender, EventArgs e)
        {
            string Entrada = textHoraTermino.Text.Trim();
            int z = Entrada.Length;
            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        textHoraTermino.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            textHoraTermino.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            textHoraTermino.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            textHoraTermino.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            textHoraTermino.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        textHoraTermino.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = textHoraTermino.Text.Substring(0, 2);
                    string b = textHoraTermino.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("O  formato da hora está incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textHoraTermino.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("O  formato da hora está incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textHoraTermino.Focus();
                    }
                    //calculando valor em minutos
                    int minutosEntrada1 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));

                }
                catch
                {
                    MessageBox.Show("Só é permitido caracteres numéricos. Não utilize ':' ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textHoraTermino.Text = String.Empty;
                    textHoraTermino.Focus();
                }
            }

        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void comboUfOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega combo cidade origem
            comboCidadeOrigem.Items.Clear();
            comboCidadeOrigem.Text = String.Empty;
            carregarCidadeOrigem();

        }

        private void comboUfDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega combo cidade destino
            comboCidadeDestino.Items.Clear();
            comboCidadeDestino.Text = String.Empty;
            carregarCidadeDestino();
        }

        private void comboCidadeOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigoCidadeOrigem();
        }

        private void comboCidadeDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigoCidadeDestino();
        }

        private void comboProjetoVinculado_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigoProjeto();
        }
    }
}
