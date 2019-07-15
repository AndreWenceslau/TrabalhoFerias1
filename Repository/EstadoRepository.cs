using Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            comando.Parameters.AddWithValue("@NOME", estado.NomeEstado);
            comando.Parameters.AddWithValue("@SIGLA", estado.Sigla);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;

        }
        public List<Estado>ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = "SELECT * FROM estados";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Estado> estados = new List<Estado>();
            foreach(DataRow linha in tabela.Rows)
            {
                Estado estado = new Estado();
                estado.Id = Convert.ToInt32(linha["id"]);
                estado.NomeEstado = linha["nome"].ToString();
                estado.Sigla = linha["sigla"].ToString();
                estados.Add(estado);
            }
            comando.Connection.Close();
            return estados;
        }
    }
}
