using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class PessoaDAL : DAL
    {
        public bool Insert(PessoaDTO pessoa)
        {
            try
            {
                OpenConnection();

                string strConn = "INSERT INTO Cliente (Nome, Endereco, Bairro, Estado, Cep, Telefone, Telefone2, Email, Observacao, FlagAtiva, FlagInadiplente)" +
                                     "VALUES (@Nome, @Endereco, @Bairro, @Estado, @Cep, @Telefone, @Telefone2, @Email, @Observacao, @FlagAtiva, @FlagInadiplente)";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                Cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                Cmd.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                Cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                Cmd.Parameters.AddWithValue("@Cep", pessoa.Cep);
                Cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                Cmd.Parameters.AddWithValue("@Telefone2", pessoa.Telefone2);
                Cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                Cmd.Parameters.AddWithValue("@Observacao", pessoa.Observacao);
                Cmd.Parameters.AddWithValue("@FlagAtiva", pessoa.FlagAtiva);
                Cmd.Parameters.AddWithValue("@FlagInadiplente", pessoa.FlagInadiplente);

                return Cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(PessoaDTO pessoa)
        {
            try
            {
                OpenConnection();

                string strCon = @"UPDATE Cliente set Nome = @Nome, Endereco = @Endereco, Bairro = @Bairro, Estado = @Estado, Cep = @Cep, FlagInadiplente = @FlagInadiplente,
                                    Telefone = @Telefone, Telefone2 = @Telefone2, Email = @Email, Observacao = @Observacao, FlagAtiva = @FlagAtiva
                                    WHERE Id = @Id";


                Cmd = new SqlCommand(strCon, Con);

                Cmd.Parameters.AddWithValue("@Id", pessoa.IdPessoa);
                Cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                Cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                Cmd.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                Cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                Cmd.Parameters.AddWithValue("@Cep", pessoa.Cep);
                Cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                Cmd.Parameters.AddWithValue("@Telefone2", pessoa.Telefone2);
                Cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                Cmd.Parameters.AddWithValue("@Observacao", pessoa.Observacao);
                Cmd.Parameters.AddWithValue("@FlagAtiva", pessoa.FlagAtiva);
                Cmd.Parameters.AddWithValue("@FlagInadiplente", pessoa.FlagInadiplente);

                Cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<PessoaDTO> Buscar(string busca, string opcao)
        {
            List<PessoaDTO> listPessoa = new List<PessoaDTO>();

            try
            {
                OpenConnection();

                string strConn;

                if (opcao.ToLower() == "id")
                {
                    strConn = @"SELECT * from Cliente WHERE id like @id";
                }
                else if (opcao.ToLower() == "nome")
                {
                    strConn = @"SELECT * from Cliente WHERE Nome like @nome";
                }
                else
                {
                    strConn = @"SELECT * from Cliente WHERE Nome like @nome AND flagAtiva = 1";
                }

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Nome", "%" + busca + "%");
                Cmd.Parameters.AddWithValue("@id", busca);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    PessoaDTO objCliente = new PessoaDTO();

                    objCliente.IdPessoa = Convert.ToInt32(Dr["Id"]);
                    objCliente.Nome = Dr["Nome"].ToString();
                    objCliente.Endereco = Dr["Endereco"].ToString();
                    objCliente.Bairro = Dr["Bairro"].ToString();
                    objCliente.Estado = Dr["Estado"].ToString();
                    objCliente.Cep = Dr["Cep"].ToString();
                    objCliente.Telefone = Dr["Telefone"].ToString();
                    objCliente.Telefone2 = Dr["Telefone2"].ToString();
                    objCliente.Email = Dr["Email"].ToString();
                    objCliente.Email = Dr["PCM"].ToString();
                    objCliente.Observacao = Dr["Observacao"].ToString();
                    objCliente.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);
                    objCliente.FlagInadiplente = Convert.ToBoolean(Dr["FlagInadiplente"]);

                    listPessoa.Add(objCliente);
                }
                return listPessoa;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<PessoaDTO> GetAll()
        {
            List<PessoaDTO> listCliente = new List<PessoaDTO>();

            try
            {
                OpenConnection();

                string strConn = @"SELECT * from Cliente";

                Cmd = new SqlCommand(strConn, Con);

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    PessoaDTO objCliente = new PessoaDTO();

                    objCliente.IdPessoa = Convert.ToInt32(Dr["Id"]);
                    objCliente.Nome = Dr["Nome"].ToString();
                    objCliente.Endereco = Dr["Endereco"].ToString();
                    objCliente.Bairro = Dr["Bairro"].ToString();
                    objCliente.Estado = Dr["Estado"].ToString();
                    objCliente.Cep = Dr["Cep"].ToString();
                    objCliente.Telefone = Dr["Telefone"].ToString();
                    objCliente.Telefone2 = Dr["Telefone2"].ToString();
                    objCliente.Email = Dr["Email"].ToString();
                    objCliente.Observacao = Dr["Observacao"].ToString();
                    objCliente.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);
                    objCliente.FlagInadiplente = Convert.ToBoolean(Dr["FlagInadiplente"]);
                    objCliente.Email = Dr["PCM"].ToString();

                    listCliente.Add(objCliente);
                }
                return listCliente;
            }
            finally
            {
                CloseConnection();
            }
        }

        public PessoaDTO GetById(string id)
        {
            try
            {
                OpenConnection();
                PessoaDTO objCliente = new PessoaDTO();

                string strConn = @"SELECT * from Cliente where id = @id";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@id", id);

                Dr = Cmd.ExecuteReader();


                while (Dr.Read())
                {

                    objCliente.IdPessoa = Convert.ToInt32(Dr["Id"]);
                    objCliente.Nome = Dr["Nome"].ToString();
                    objCliente.Endereco = Dr["Endereco"].ToString();
                    objCliente.Bairro = Dr["Bairro"].ToString();
                    objCliente.Estado = Dr["Estado"].ToString();
                    objCliente.Cep = Dr["Cep"].ToString();
                    objCliente.Telefone = Dr["Telefone"].ToString();
                    objCliente.Telefone2 = Dr["Telefone2"].ToString();
                    objCliente.Email = Dr["Email"].ToString();
                    objCliente.Observacao = Dr["Observacao"].ToString();
                    objCliente.FlagAtiva = Convert.ToBoolean(Dr["FlagAtiva"]);
                    objCliente.FlagInadiplente = Convert.ToBoolean(Dr["FlagInadiplente"]);
                    objCliente.Email = Dr["PCM"].ToString();
                }
                return objCliente;
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}