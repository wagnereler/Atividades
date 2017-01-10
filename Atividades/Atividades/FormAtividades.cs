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
using System.IO;


namespace Atividades
{
    public partial class FormAtividades : Form
    {
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

            if(z != 0)
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

            
           
            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tbAtividades(codProjeto, dataAtividade, entrada1, entrada2, entrada3, saida1, saida2, saida3, codColaborador, ObsAtividade)  VALUES(@codProjeto, @dataAtividade, @entrada1, @entrada2, @entrada3, @saida1, @saida2, @saida3, @codColaborador, @ObsAtividade)", conn);


            cmd.Parameters.AddWithValue("codProjeto", textCodigoProjeto.Text.Trim());
            cmd.Parameters.AddWithValue("dataAtividade", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("entrada1", maskEntrada1.Text.Trim());
            cmd.Parameters.AddWithValue("entrada2", maskSaida1.Text.Trim());
            cmd.Parameters.AddWithValue("entrada3", maskEntrada3.Text.Trim());
            cmd.Parameters.AddWithValue("saida1", maskSaida1.Text.Trim());
            cmd.Parameters.AddWithValue("saida2", maskSaida2.Text.Trim());
            cmd.Parameters.AddWithValue("saida3", maskSaida3.Text.Trim());
            cmd.Parameters.AddWithValue("codColaborador", textCodColaborador.Text.Trim());
            cmd.Parameters.AddWithValue("ObsAtividade", TextObservacao.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Salvo com Sucesso!");
                maskEntrada1.Text = string.Empty;
                maskSaida1.Text = string.Empty;
                maskEntrada3.Text = string.Empty;
                maskSaida1.Text = string.Empty;
                maskSaida2.Text = string.Empty;
                maskSaida3.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar arquivo: " + ex.Message);
            }


        }

        private void maskEntrada1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
