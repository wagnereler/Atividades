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
        string b;

        public FormCidades()

        
        {
            InitializeComponent();
        }

        public string verificaRegistroCidades(string b)
        {
            this.b = b;
            try
            {
                {
                    SQLiteConnection conn = new SQLiteConnection(connectBase);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(
                    "SELECT nomeCidade FROM tbCidades WHERE nomeCidade = '" + textCadastroCidade.Text.Trim().ToUpper() + 
                    "' AND codUF ='" + comboCadatroUF.Text.Trim() + "'"  , conn);

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                        b = Convert.ToString(dr["nomeCidade"]);
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return b;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            carregarUF();
            carregarGridCidades();

        }

        public class gridCidades
        {
            public int codCidade { get; set; }
            public string codUf { get; set; }
            public string nomeCidade { get; set; }
        }


        private void carregarGridCidades()
        {

            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(
                @"SELECT codCidade
                       ,codUf
                       ,nomeCidade   
                FROM tbCidades", conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            List<gridCidades> listGridCidades = new List<gridCidades>();
            while (dr.Read())
            {
                listGridCidades.Add(new gridCidades
                {
                    codCidade = Convert.ToInt32(dr["codCidade"]),
                    codUf = Convert.ToString(dr["codUf"]),
                    nomeCidade = Convert.ToString(dr["nomeCidade"])
                });
            }
            dataGridCidades.DataSource = listGridCidades;

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
                    conn.Close();

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
                if (textCadastroCidade.Text.Trim().Length < 4)
                {
                    MessageBox.Show("O nome da cidade deve ter no mínimo 3 caractres", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                else
                {
                    if (textCadastroCidade.Text.Trim().ToUpper() == verificaRegistroCidades(b))
                    {
                        MessageBox.Show("Registro Duplicado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tbCidades (codUf, nomeCidade)
                    VALUES(@codUf, @nomeCidade)", conn);

                        //captrua os valores para os parametros do sql
                        cmd.Parameters.AddWithValue("codUf", comboCadatroUF.Text.Trim());
                        cmd.Parameters.AddWithValue("nomeCidade", textCadastroCidade.Text.ToUpper().Trim());


                        try
                        {
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            textCadastroCidade.Text = string.Empty;
                            carregarGridCidades();
                            MessageBox.Show("Dados gravados com sucesso", "Operação Realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Inserir Dados" + ex.Message);
                        }
                    }
                    
                }
            }
        }
    }
}
