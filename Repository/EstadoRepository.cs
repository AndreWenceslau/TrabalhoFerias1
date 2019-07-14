using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EstadoRepository
    {
        public int Inserir(Estado estado)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = "INSERT INTO estados (nome, sigla) OUTPUT INSERTED VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", estado.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estado.Sigla);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;

        }
    }
}
