using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoriaRepository
    {
        public int Inserir(Categoria categoria)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = "INSERT INTO "
        }
        
        
    }
}
