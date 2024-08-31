using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoEmprestimo.Models;
using ProjetoEmprestimo.Repository.Contract;

namespace ProjetoEmprestimo.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly string _conexaoMySQL;
        public LivroRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

        public void CadastrarLivro(Livro livro)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
               conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into tbLivro " +
                                                    " values (default, @NomeLivro, @ImagemLivro, @CodCateg", conexao);

                cmd.Parameters.Add("@NomeLivro", MySqlDbType.VarChar).Value = livro.nomeLivro;
                cmd.Parameters.Add("@ImagemLivro", MySqlDbType.VarChar).Value = livro.imagemLivro;
                cmd.Parameters.Add("@CodCateg", MySqlDbType.Int32).Value = livro.RefCategoria.codCateg;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void AtualizarLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void DeletarLivro(int codLivro)
        {
            throw new NotImplementedException();
        }

        public Livro ObterLivroPorId(int codLivro)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            throw new NotImplementedException();
        }
    }
}
