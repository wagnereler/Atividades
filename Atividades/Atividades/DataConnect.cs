using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Atividades
{
    class DataConnect

    {
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";

        public void conectar()
        {
            if (!File.Exists(bancoName))
            {
                MessageBox.Show("O banco Não está criado!");
                SQLiteConnection.CreateFile(bancoName);
                SQLiteConnection conn = new SQLiteConnection(connectBase);
                conn.Open();

                StringBuilder sql = new StringBuilder();
                //SE NÃO EXISTIR CRIA A TABELA ATIVIDADES
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbAtividades] ([codAtividade] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[codProjeto] INTEGER, [dataAtividade]DATETIME, [entrada1] VARCHAR(5), [entrada2] VARCHAR(5),");
                sql.AppendLine("[entrada3] VARCHAR(5), [saida1] VARCHAR(5), [saida2] VARCHAR(5), [saida3] VARCHAR(5),");
                sql.AppendLine("[ObsAtividade] VARCHAR(1000), [Extra]VARCHAR(10));");

                //SE NÃO EXISTIR CRIA A TABELA PROJEITOS
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbProjetos] ( [codProjeto] INTEGER PRIMARY KEY,");
                sql.AppendLine("[nomeProjeto] VARCHAR[60], [idGerente] INT, [codUf] VARCHAR(2), [codCidade] INT);");

                //SE NÃO EXISTIR CRIA A TABELA PESSOAS
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbPessoas] ([codPessoa] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[NomePessoa] VARCHAR(100) , [Gerente] BOOL, [colaboradorPadrao] BOOL);");

                //SE NÃO EXISTIR CRIA A TABELA UF
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbUF] ([codUf] VARCHAR(2) PRIMARY KEY NOT NULL, [nomeEstado] VARCHAR(60));");

                //SE NÃO EXISTIR CRIA A TABELA ATIVIDADES
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbCidates] ([codCidade] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[codUf] VARCHAR(2) NOT NULL, [nomeCidade] VARCHAR(60));");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Criar Banco de Dados" + ex.Message);
                }
            }
        }
    }
}
