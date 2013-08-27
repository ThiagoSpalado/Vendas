using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class ProdutoDAL : DAL
    {
        public bool Salvar(ProdutoDTO produto)
        {
            try
            {
                OpenConnection();

                string strConn = "INSERT INTO Pessoa (Nome, Quantidade, Preco, Texto, FlagAtiva)" +
                                     "VALUES (@Nome, @Quantidade, @Preco, @Texto, @FlagAtiva)";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                Cmd.Parameters.AddWithValue("@Quantidade ", produto.Quantidade);
                Cmd.Parameters.AddWithValue("@Preco ", produto.Preco);
                Cmd.Parameters.AddWithValue("@Texto ", produto.Texto);
                Cmd.Parameters.AddWithValue("@FlagAtiva ", produto.FlagAtiva);

                return Cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ExcluirEditar(ProdutoDTO produto, string opcao)
        {
            try
            {
                OpenConnection();

                string strConn = "";

                if (opcao.ToLower() == "editar")
                {
                    strConn = @"UPDATE Produto set Nome = @Nome, Quantidade = @Quantidade, 
                                Preco = @Preco, Texto = @Texto, FlagAtiva = @FlagAtiva,
                                WHERE Id = @Id";
                }
                else
                {
                    strConn = @"DELETE from Produto WHERE IdProduto = @IdProduto";
                }

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                Cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                Cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                Cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                Cmd.Parameters.AddWithValue("@Texto", produto.Texto);
                Cmd.Parameters.AddWithValue("@FlagAtiva", produto.FlagAtiva);

                Cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<ProdutoDTO> Buscar(string busca, string opcao)
        {
            List<ProdutoDTO> listProduto = new List<ProdutoDTO>();

            try
            {
                OpenConnection();

                string strConn;

                if (opcao.ToLower() == "id")
                {
                    strConn = @"SELECT * from Produto WHERE id = @id";
                }
                else if (opcao.ToLower() == "nomeeativo")
                {
                    strConn = @"SELECT * from Produto WHERE Nome like @nome AND FlagAtiva = 1";
                }
                else if (opcao.ToLower() == "ativo")
                {
                    strConn = @"SELECT * from Produto WHERE FlagAtiva = 1";
                }
                else if (opcao.ToLower() == "inativo")
                {
                    strConn = @"SELECT * from Produto WHERE FlagAtiva = 0";
                }
                else
                {
                    strConn = @"SELECT * from Produto WHERE Nome like @nome";
                }

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Nome", "%" + busca + "%");
                Cmd.Parameters.AddWithValue("@id", busca);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    ProdutoDTO objProduto = new ProdutoDTO();

                    objProduto.IdProduto = Convert.ToInt32(Dr["Id"]);
                    objProduto.Nome = Dr["Nome"].ToString();
                    objProduto.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                    objProduto.Preco = Dr["Preco"].ToString();
                    objProduto.Texto = Dr["Texto"].ToString();
                    objProduto.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);

                    listProduto.Add(objProduto);
                }
                return listProduto;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<ProdutoDTO> GetAll()
        {
            List<ProdutoDTO> listProduto = new List<ProdutoDTO>();

            try
            {
                OpenConnection();

                string strConn = @"SELECT * from Produto";

                Cmd = new SqlCommand(strConn, Con);

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    ProdutoDTO objProduto = new ProdutoDTO();

                    objProduto.IdProduto = Convert.ToInt32(Dr["Id"]);
                    objProduto.Nome = Dr["Nome"].ToString();
                    objProduto.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                    objProduto.Texto = Dr["Texto"].ToString();
                    objProduto.Preco = Dr["Preco"].ToString();
                    objProduto.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);

                    listProduto.Add(objProduto);
                }
                return listProduto;
            }
            finally
            {
                CloseConnection();
            }
        }

        public ProdutoDTO GetById(string id)
        {
            try
            {
                OpenConnection();
                ProdutoDTO objProduto = new ProdutoDTO();
                string strConn = @"SELECT * from Produto where id = @id";

                Cmd = new SqlCommand(strConn, Con);
                Cmd.Parameters.AddWithValue("@id", id);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    objProduto.IdProduto = Convert.ToInt32(Dr["Id"]);
                    objProduto.Nome = Dr["Nome"].ToString();
                    objProduto.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                    objProduto.Texto = Dr["Texto"].ToString();
                    objProduto.Preco = Dr["Preco"].ToString();
                    objProduto.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);
                }
                return objProduto;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
