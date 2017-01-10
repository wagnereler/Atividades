using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Atividades
{
    class DataInsert : FormAtividades
    {
         
        private static string connectBase = "Data Source=Banco.db";
        private static string bancoName = "Banco.db";
        private static string insertAtividadesQuery = "INSERT INTO tbAtividades (codProjeto, dataAtividade, entrada1, entrada2, entrada3, saida1, saida2, saida3, codColaborador, codGerente, ObsAtividade)  VALUES (@codProjeto, @dataAtividade, @entrada1, @entrada2, @entrada3, @saida1, @saida2, @saida3, @codColaborador, @codGerente, @ObsAtividade)";


        public void InsertAtividades()
        {

            SQLiteConnection conn = new SQLiteConnection(connectBase);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            
            SQLiteCommand cmd = new SQLiteCommand(insertAtividadesQuery, conn);
            cmd.Parameters.AddWithValue("INSERT INTO tbAtividades(codProjeto, dataAtividade, entrada1, entrada2, entrada3, saida1, saida2, saida3, codColaborador, codGerente, ObsAtividade)  VALUES(@codProjeto, @dataAtividade, @entrada1, @entrada2, @entrada3, @saida1, @saida2, @saida3, @codColaborador, @codGerente, @ObsAtividade)", conn);
        }
    }
}
