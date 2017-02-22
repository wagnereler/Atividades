using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Atividades
{
    public partial class FormAtividades : Form
    {
        private string b;
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";
        

        public FormAtividades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancia a classe DataConnect para efetuar a conexão com o banco
            DataConnect connex = new DataConnect();
            connex.conectar();

            comboProjeto.Items.Clear();
            comboColaborador.Items.Clear();
            carregarComboColaborador();
            carregarComboProjetos();

        }



        public string verificaRegistro(string b)
        {
            this.b = b;
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT dataAtividade FROM tbAtividades WHERE dataAtividade='" + dateTimePicker1.Text.TrimStart() + "'", conn);
                    //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    b = Convert.ToString(dr["dataAtividade"]);
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            return b;
        }

        public void carregarComboProjetos()
        {
            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT NomeProjeto FROM tbProjetos", conn);
            SQLiteDataAdapter daComboProjeto = new SQLiteDataAdapter(cmd);
            DataTable dtComboProjetos = new DataTable();
            daComboProjeto.Fill(dtComboProjetos);
            foreach (DataRow drComboProjeto in dtComboProjetos.Rows)

            {
                comboProjeto.Items.Add(drComboProjeto["NomeProjeto"]);

            }
            conn.Close();

        }
        /*Alternativa para a solução
         * {

            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT NomeProjeto FROM tbProjetos", conn);
            SQLiteDataReader DataReaderComboProjetos = cmd.ExecuteReader();
            DataTable tabelaComboProjetos = new DataTable();
            tabelaComboProjetos.Load(DataReaderComboProjetos);
            comboProjeto.DisplayMember = "nomeProjeto";
            comboProjeto.DataSource = tabelaComboProjetos;
            conn.Close();


        }*/

        public void carregarComboColaborador()
        {
            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT nomePessoa FROM tbPessoas WHERE colaborador = 1", conn);
            //SQLiteDataReader drComboProjeto = cmd.ExecuteReader();
            SQLiteDataAdapter daCombo = new SQLiteDataAdapter(cmd);
            DataTable dtCombo = new DataTable();
            daCombo.Fill(dtCombo);
            foreach (DataRow drCombo in dtCombo.Rows)

            {
                comboColaborador.Items.Add(drCombo["nomePessoa"]);

            }
            conn.Close();

        }
        public void carregarCodigoProjeto()
        {
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT codProjeto FROM tbProjetos WHERE nomeProjeto = '" + comboProjeto.Text.Trim() + "'", conn);
                    SQLiteDataReader ler = cmd.ExecuteReader();
                    ler.Read();
                    textCodigoProjeto.Text = ler["codProjeto"].ToString();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gerente não selecionado \n ");
            }
        }
        public void carregarCodigoColaborador()
        {



            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT codPessoa FROM tbPessoas WHERE nomePessoa = '" + comboColaborador.Text.Trim() + "'", conn);
                    SQLiteDataReader ler = cmd.ExecuteReader();
                    ler.Read();
                    textCodColaborador.Text = ler["codPessoa"].ToString();
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err0 " + ex.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        //Evento que trata o campo para que fique o formato adequado. 
        private void validaHoraEntrada1(object sender, EventArgs e)
        {
            string Entrada = maskEntrada1.Text.Trim();
            int z = Entrada.Length;
            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskEntrada1.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada1.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskEntrada1.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada1.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskEntrada1.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskEntrada1.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskEntrada1.Text.Substring(0, 2);
                    string b = maskEntrada1.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada1.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada1.Focus();
                    }
                    //calculando valor em minutos
                    int minutosEntrada1 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));




                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskEntrada1.Text = String.Empty;
                    maskEntrada1.Focus();
                }
            }

        }

        private void validaHoraEntrada2(object sender, EventArgs e)
        {
            string Entrada = maskEntrada2.Text.Trim();
            int z = Entrada.Length;

            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskEntrada2.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada2.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskEntrada2.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada2.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskEntrada2.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskEntrada2.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskEntrada2.Text.Substring(0, 2);
                    string b = maskEntrada2.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada2.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada2.Focus();
                    }
                    //calculando valor em minutos
                    string c = maskEntrada1.Text.Substring(0, 2);
                    string d = maskEntrada1.Text.Substring(3, 2);

                    int minutosSaida1 = ((Convert.ToInt32(c) * 60) + Convert.ToInt32(d));
                    int minutosEntrada2 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));
                    if (minutosEntrada2 <= minutosSaida1)
                    {
                        MessageBox.Show("Atenção! \n O valor informado deve ser maior que o valor do campo anteriro");
                        maskEntrada2.Focus();
                    }


                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskEntrada2.Text = String.Empty;
                    maskEntrada2.Focus();
                }
            }

        }

        private void validaHoraEntrada3(object sender, EventArgs e)
        {
            string Entrada = maskEntrada3.Text.Trim();
            int z = Entrada.Length;

            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskEntrada3.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada3.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskEntrada3.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskEntrada3.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskEntrada3.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskEntrada3.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskEntrada3.Text.Substring(0, 2);
                    string b = maskEntrada3.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada3.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskEntrada3.Focus();
                    }
                    //calculando valor em minutos
                    string c = maskEntrada1.Text.Substring(0, 2);
                    string d = maskEntrada1.Text.Substring(3, 2);

                    int minutosSaida2 = ((Convert.ToInt32(c) * 60) + Convert.ToInt32(d));
                    int minutosEntrada3 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));
                    if (minutosEntrada3 <= minutosSaida2)
                    {
                        MessageBox.Show("Atenção! \n O valor informado deve ser maior que o valor do campo anteriro");
                        maskEntrada3.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskEntrada3.Text = String.Empty;
                    maskEntrada3.Focus();
                }
            }
        }

        private void validaHoraSaida1(object sender, EventArgs e)
        {
            string Entrada = maskSaida1.Text.Trim();
            int z = Entrada.Length;

            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskSaida1.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida1.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskSaida1.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida1.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskSaida1.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskSaida1.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskSaida1.Text.Substring(0, 2);
                    string b = maskSaida1.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida1.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida1.Focus();
                    }
                    //calculando valor em minutos
                    string c = maskEntrada1.Text.Substring(0, 2);
                    string d = maskEntrada1.Text.Substring(3, 2);

                    int minutosEntrada1 = ((Convert.ToInt32(c) * 60) + Convert.ToInt32(d));
                    int minutosSaida1 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));
                    if (minutosSaida1 <= minutosEntrada1)
                    {
                        MessageBox.Show("Atenção! \n O valor informado deve ser maior que o valor do campo anteriro");
                        maskSaida1.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskSaida1.Text = String.Empty;
                    maskSaida1.Focus();
                }
            }

        }

        private void validaHoraSaida2(object sender, EventArgs e)
        {
            string Entrada = maskSaida2.Text.Trim();
            int z = Entrada.Length;

            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskSaida2.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida2.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskSaida2.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida2.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskSaida2.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskSaida2.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskSaida2.Text.Substring(0, 2);
                    string b = maskSaida2.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida2.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida2.Focus();
                    }
                    //calculando valor em minutos
                    string c = maskEntrada2.Text.Substring(0, 2);
                    string d = maskEntrada2.Text.Substring(3, 2);

                    int minutosEntrada2 = ((Convert.ToInt32(c) * 60) + Convert.ToInt32(d));
                    int minutosSaida2 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));
                    if (minutosSaida2 <= minutosEntrada2)
                    {
                        MessageBox.Show("Atenção! \n O valor informado deve ser maior que o valor do campo anteriro");
                        maskSaida2.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskSaida2.Text = String.Empty;
                    maskSaida2.Focus();
                }
            }

        }

        private void validaHoraSaida3(object sender, EventArgs e)
        {
            string Entrada = maskSaida3.Text.Trim();
            int z = Entrada.Length;

            if (z != 0)
            {
                try
                {
                    Convert.ToInt32(Entrada);
                    if (z == 1)
                    {
                        maskSaida3.Text = "0" + Entrada + ":00";
                    }
                    if (z == 2)
                    {

                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida3.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 1) + "0";
                        }
                        else
                        {
                            maskSaida3.Text = Entrada + ":00";
                        }

                    }
                    if (z == 3)
                    {
                        if (Entrada.Substring(0, 1) != "0" & Entrada.Substring(0, 1) != "1" & Entrada.Substring(0, 1) != "2")
                        {
                            maskSaida3.Text = "0" + Entrada.Substring(0, 1) + ":" + Entrada.Substring(1, 2);
                        }
                        else
                        {
                            maskSaida3.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 1) + "0";
                        }

                    }
                    if (z == 4)
                    {
                        maskSaida3.Text = Entrada.Substring(0, 2) + ":" + Entrada.Substring(2, 2);
                    }

                    string a = maskSaida3.Text.Substring(0, 2);
                    string b = maskSaida3.Text.Substring(3, 2);

                    if (Convert.ToInt32(a) > 23)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida3.Focus();
                    }
                    if (Convert.ToInt32(b) > 59)
                    {
                        MessageBox.Show("Atenção! O  formato da hora está incorreto.");
                        maskSaida3.Focus();
                    }
                    //calculando valor em minutos
                    string c = maskEntrada3.Text.Substring(0, 2);
                    string d = maskEntrada3.Text.Substring(3, 2);

                    int minutosEntrada3 = ((Convert.ToInt32(c) * 60) + Convert.ToInt32(d));
                    int minutosSaida3 = ((Convert.ToInt32(a) * 60) + Convert.ToInt32(b));
                    if (minutosSaida3 <= minutosEntrada3)
                    {
                        MessageBox.Show("Atenção! \n O valor informado deve ser maior que o valor do campo anteriro");
                        maskSaida3.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Atenção! Só é permitido caracteres numéricos. Não utilize ':' ");
                    maskSaida3.Text = String.Empty;
                    maskSaida3.Focus();
                }
            }
        }






        private void comboProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void butInserirAtividade_Click(object sender, EventArgs e)
        {
            string DiaSemana = Convert.ToString(dateTimePicker1.Value.DayOfWeek);



            //verifica as horas digitadas e as converte em minutos, gravando em uma variável
            int totalMinutos = 0;
            int totalExtra = 0;

            try
            {
                //Primeiro perído
                if (maskEntrada1.Text != string.Empty)
                {
                    //Converte em mintos o valor do primeiro campo
                    int valor1a = (Convert.ToInt32(maskEntrada1.Text.Substring(0, 2)) * 60);
                    int valor1b = (Convert.ToInt32(maskEntrada1.Text.Substring(3, 2)));
                    //Converte em mintos o valor do primeiro campo
                    int valor2a = (Convert.ToInt32(maskSaida1.Text.Substring(0, 2)) * 60);
                    int valor2b = (Convert.ToInt32(maskSaida1.Text.Substring(3, 2)));

                    //calcula a quantidade em mintuso e grava em uma variável
                    totalMinutos += (valor2a + valor2b) - (valor1a + valor1b);
                }

                //Segundo perído
                if (maskEntrada2.Text != string.Empty)
                {
                    //Converte em mintos o valor do primeiro campo
                    int valor1a = (Convert.ToInt32(maskEntrada2.Text.Substring(0, 2)) * 60);
                    int valor1b = (Convert.ToInt32(maskEntrada2.Text.Substring(3, 2)));
                    //Converte em mintos o valor do primeiro campo
                    int valor2a = (Convert.ToInt32(maskSaida2.Text.Substring(0, 2)) * 60);
                    int valor2b = (Convert.ToInt32(maskSaida2.Text.Substring(3, 2)));

                    //calcula a quantidade em mintuso e grava em uma variável
                    totalMinutos += (valor2a + valor2b) - (valor1a + valor1b);
                }

                //Segundo perído
                if (maskEntrada3.Text != string.Empty)
                {
                    //Converte em mintos o valor do primeiro campo
                    int valor1a = (Convert.ToInt32(maskEntrada3.Text.Substring(0, 2)) * 60);
                    int valor1b = (Convert.ToInt32(maskEntrada3.Text.Substring(3, 2)));
                    //Converte em mintos o valor do primeiro campo
                    int valor2a = (Convert.ToInt32(maskSaida3.Text.Substring(0, 2)) * 60);
                    int valor2b = (Convert.ToInt32(maskSaida3.Text.Substring(3, 2)));

                    //calcula a quantidade em mintuso e grava em uma variável
                    totalMinutos += (valor2a + valor2b) - (valor1a + valor1b);
                }

                //Verifique se há campos preenchidos o suficientes para gravar informações. 
                string listaCampos = "";

                if (textCodigoProjeto.Text == string.Empty)
                {
                    listaCampos += "Por favor selecione um projeto ou digite um código válido.\n";
                }
                if (textCodColaborador.Text == string.Empty)
                {
                    listaCampos += "Por favor selecione um colaborador ou digite um código válido.\n";
                }
                if (maskEntrada1.Text == string.Empty || maskSaida1.Text == string.Empty)
                {
                    listaCampos += "Insira pelo menos os dados de entrada e saída do primeiro perído!\n";
                }
                if (TextObservacao.Text.Length < 5)
                {
                    listaCampos += "O campo Observação deve ter no mínimo 5 caracteres.";
                }

                


                //Se os campos obrigadóiro forem preenchido o formulário será gravado
                if (listaCampos.Length == 0)
                {
                    //Verifica Resgistro Duplicato
                    

                    if (verificaRegistro(b) == dateTimePicker1.Text.TrimStart())
                    {
                        DialogResult resultDuplicidadeData = MessageBox.Show(" Registro Duplicado.\n Deseja atualizar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (resultDuplicidadeData == DialogResult.Yes)
                        {
                            SQLiteConnection conn = new SQLiteConnection(connectBase);
                            if (conn.State == System.Data.ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            SQLiteCommand cmd = new SQLiteCommand("UPDATE tbAtividades SET codProjeto=@codProjeto, dataAtividade=@dataAtividade," +
                            "entrada1=@entrada1, entrada2=@entrada2, entrada3=@entrada3, saida1=@saida1, saida2=@saida2, saida3=@saida3," +
                            "codColaborador=@codColaborador, ObsAtividade=@ObsAtividade, totalMinutos=@totalMinutos, minutosExtras=@minutosExtras", conn);

                            cmd.Parameters.AddWithValue("codProjeto", textCodigoProjeto.Text.Trim());
                            cmd.Parameters.AddWithValue("dataAtividade", dateTimePicker1.Text.TrimStart());
                            cmd.Parameters.AddWithValue("entrada1", maskEntrada1.Text.Trim());
                            cmd.Parameters.AddWithValue("entrada2", maskSaida1.Text.Trim());
                            cmd.Parameters.AddWithValue("entrada3", maskEntrada3.Text.Trim());
                            cmd.Parameters.AddWithValue("saida1", maskSaida1.Text.Trim());
                            cmd.Parameters.AddWithValue("saida2", maskSaida2.Text.Trim());
                            cmd.Parameters.AddWithValue("saida3", maskSaida3.Text.Trim());
                            cmd.Parameters.AddWithValue("codColaborador", textCodColaborador.Text.Trim());
                            cmd.Parameters.AddWithValue("ObsAtividade", TextObservacao.Text.Trim());
                            //verificar o que fazer para identificar o domingo, pois atualmente o código não irá gerar horas trabalhadas no domingo como extra

                            if (DiaSemana == "Sunday")
                            {
                                cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                cmd.Parameters.AddWithValue("minutosExtras", (totalMinutos * 2));
                            }
                            if (DiaSemana == "Saturday")
                            {
                                cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                cmd.Parameters.AddWithValue("minutosExtras", totalMinutos);
                            }
                            else
                            {
                                if (totalMinutos > 480)
                                {
                                    cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                    cmd.Parameters.AddWithValue("minutosExtras", (totalMinutos - 480));
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                    cmd.Parameters.AddWithValue("minutosExtras", 0);
                                }
                            }


                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registro Salvo com Sucesso!");
                                statusAtividades.Text = "Status: Registro Salvo com Sucesso!";
                                maskEntrada1.Text = string.Empty;
                                maskSaida1.Text = string.Empty;
                                maskEntrada3.Text = string.Empty;
                                maskSaida1.Text = string.Empty;
                                maskEntrada2.Text = string.Empty;
                                maskSaida2.Text = string.Empty;
                                maskSaida3.Text = string.Empty;
                                TextObservacao.Text = string.Empty;
                                conn.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(Convert.ToString("Erro ao salvar arquivo???: " + ex.Message));
                            }


                        }

                        else
                        {
                            //RETORNAR AO FORMULÁRIO
                        }
                    }
                    else
                    {
                        SQLiteConnection conn = new SQLiteConnection(connectBase);
                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open();
                        }


                        SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tbAtividades(codProjeto, dataAtividade, entrada1, entrada2," +
                        "entrada3, saida1, saida2, saida3, codColaborador, ObsAtividade, totalMinutos, minutosExtras)  VALUES(@codProjeto," +
                        "@dataAtividade, @entrada1, @entrada2, @entrada3, @saida1, @saida2, @saida3, @codColaborador, @ObsAtividade, " +
                        "@totalMinutos, @minutosExtras)", conn);


                        cmd.Parameters.AddWithValue("codProjeto", textCodigoProjeto.Text.Trim());
                        cmd.Parameters.AddWithValue("dataAtividade", dateTimePicker1.Text.TrimStart());
                        cmd.Parameters.AddWithValue("entrada1", maskEntrada1.Text.Trim());
                        cmd.Parameters.AddWithValue("entrada2", maskSaida1.Text.Trim());
                        cmd.Parameters.AddWithValue("entrada3", maskEntrada3.Text.Trim());
                        cmd.Parameters.AddWithValue("saida1", maskSaida1.Text.Trim());
                        cmd.Parameters.AddWithValue("saida2", maskSaida2.Text.Trim());
                        cmd.Parameters.AddWithValue("saida3", maskSaida3.Text.Trim());
                        cmd.Parameters.AddWithValue("codColaborador", textCodColaborador.Text.Trim());
                        cmd.Parameters.AddWithValue("ObsAtividade", TextObservacao.Text.Trim());
                        //verificar o que fazer para identificar o domingo, pois atualmente o código não irá gerar horas trabalhadas no domingo como extra

                        if (DiaSemana == "Sunday")
                        {
                            cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                            cmd.Parameters.AddWithValue("minutosExtras", (totalMinutos * 2));
                        }
                        if (DiaSemana == "Saturday")
                        {
                            cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                            cmd.Parameters.AddWithValue("minutosExtras", totalMinutos);
                        }
                        else
                        {
                            if (totalMinutos > 480)
                            {
                                cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                cmd.Parameters.AddWithValue("minutosExtras", (totalMinutos - 480));
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("totalMinutos", totalMinutos);
                                cmd.Parameters.AddWithValue("minutosExtras", 0);
                            }
                        }





                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registro Salvo com Sucesso!");
                            statusAtividades.Text = "Status: Registro Salvo com Sucesso!";
                            maskEntrada1.Text = string.Empty;
                            maskSaida1.Text = string.Empty;
                            maskEntrada3.Text = string.Empty;
                            maskSaida1.Text = string.Empty;
                            maskEntrada2.Text = string.Empty;
                            maskSaida2.Text = string.Empty;
                            maskSaida3.Text = string.Empty;
                            TextObservacao.Text = string.Empty;
                            conn.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Convert.ToString("Erro ao salvar arquivo: " + ex.Message));
                        }

                    }



                }
                else
                {
                    MessageBox.Show("Atenção! Verifique os seguintes campos:\n\n" + listaCampos);


                }
            }
            catch
            {
                MessageBox.Show("Atenção! Verifique se os campos ENTRADA e Saída forma preenchidos.");
            }










        }

        private void maskEntrada1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregarGridAtividades()
        {
            /*
            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(

                "",

                conn);*/
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormPessoas pessoas = new FormPessoas();
            pessoas.ShowDialog();
            
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjeto Projetos = new FormProjeto();
            Projetos.ShowDialog();
        }

        private void comboProjeto_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarComboColaborador();
        }

        private void comboProjeto_Leave(object sender, EventArgs e)
        {

        }

        private void comboColaborador_Enter(object sender, EventArgs e)
        {
  
        }

        private void comboColaborador_Leave(object sender, EventArgs e)
        {

        }

        private void comboProjeto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void FormAtividades_Activated(object sender, EventArgs e)
        {
            comboColaborador.Items.Clear();
            comboProjeto.Items.Clear();
            carregarComboProjetos();
            carregarComboColaborador();
        }

        private void comboProjeto_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            carregarCodigoProjeto();
        }

        private void comboColaborador_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carregarCodigoColaborador();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidades Cidades = new FormCidades();
            Cidades.ShowDialog();
        }
    }
}