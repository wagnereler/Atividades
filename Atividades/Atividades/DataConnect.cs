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

                //SE NÃO EXISTIR CRIA A TABELA UF
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbUF] ([codUf] VARCHAR(2) PRIMARY KEY NOT NULL, [nomeEstado] VARCHAR(60));");
                
                //SE NÃO EXISTIR CRIA A TABELA PESSOAS
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbPessoas] ([codPessoa] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[NomePessoa] VARCHAR(100) , [Gerente] BOOL, [colaboradorPadrao] BOOL);");

                //SE NÃO EXISTIR CRIA A TABELA CIDADES
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbCidates] ([codCidade] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[codUf] VARCHAR(2) NOT NULL, [nomeCidade] VARCHAR(60),");
                sql.AppendLine("FOREIGN KEY (codUf) REFERENCES tbUF (codUf) );");
                              

                //SE NÃO EXISTIR CRIA A TABELA PROJEITOS
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbProjetos] ( [codProjeto] INT PRIMARY KEY,");
                sql.AppendLine("[nomeProjeto] VARCHAR(60), [idGerente] INT, [codUf] VARCHAR(2), [codCidade] INT,");
                sql.AppendLine("FOREIGN KEY (idGerente) REFERENCES tbPessoas (idGerente),");
                sql.AppendLine("FOREIGN KEY (codUf) REFERENCES tbUF (codUf),");
                sql.AppendLine("FOREIGN KEY (codCidade) REFERENCES tbCidades (codCidade));");

                //SE NÃO EXISTIR CRIA A TABELA ATIVIDADES
                sql.AppendLine("CREATE TABLE IF NOT EXISTS [tbAtividades] ([codAtividade] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[codProjeto] INT, [dataAtividade] DATETIME, [entrada1] VARCHAR(5), [entrada2] VARCHAR(5),");
                sql.AppendLine("[entrada3] VARCHAR(5), [saida1] VARCHAR(5), [saida2] VARCHAR(5), [saida3] VARCHAR(5),");
                sql.AppendLine("[codColaborador] INT, [codGerente] INT,  [obsAtividade] VARCHAR(1000), [horasTrabalhadas] INT, [extra] INT, ");
                sql.AppendLine("FOREIGN KEY (codProjeto) REFERENCES tbProjetos (codProjeto),");
                sql.AppendLine("FOREIGN KEY (codColaborador) REFERENCES tbPessoas (codPessoa),");
                sql.AppendLine("FOREIGN KEY (codGerente) REFERENCES tbProjetos (codPessoa) );");



                //INSERT NA TABELA DE ESTADOS
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('AC', 'ACRE');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('AL', 'ALAGOAS');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('AP', 'AMAPÁ');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('AM', 'AMAZONAS');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('BA', 'BAHIA');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('CE', 'CEARÁ');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('EX', 'EXTERIOR');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('DF', 'DISTRITO FEDERAL');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('ES', 'ESPÍRITO SANTO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('GO', 'GOIÁS');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('MA', 'MARANHÃO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('MT', 'MATO GROSSO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('MS', 'MATO GROSSO DO SUL');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('MG', 'MINAS GERAIS');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('PA', 'PARÁ');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('PB', 'PARAÍBA');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('PR', 'PARANÁ');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('PE', 'PERNAMBUCO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('PI', 'PIAUÍ');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('RJ', 'RIO DE JANEIRO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('RN', 'RIO GRANDE DO NORTE');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('RS', 'RIO GRANDE DO SUL');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('RO', 'RONDÔNIA');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('RR', 'RORAIMA');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('SC', 'SANTA CATARINA');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('SP', 'SÃO PAULO');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('SE', 'SERGIPE');");
                sql.AppendLine("INSERT INTO tbUF (codUf, nomeEstado) VALUES ('TO', 'TOCANTINS');");



                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Criar Banco de Dados" + ex.Message);
                    
                }
            }
        }
    }
}
