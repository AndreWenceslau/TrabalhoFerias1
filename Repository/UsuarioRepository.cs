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
    public class UsuarioRepository
    {
        public List<Usuario> ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM usuarios";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Usuario> usuarios = new List<Usuario>();

            foreach(DataRow linha in tabela.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(linha["id"]);
                usuario.Nome = linha["nome"].ToString();
                usuario.Login = linha["login"].ToString();
                usuario.Senha = linha["senha"].ToString();
                usuarios.Add(usuario);
            }
            comando.Connection.Close();
            return usuarios;
        }
    }
}
