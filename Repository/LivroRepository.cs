using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoEmprestimo.Models;
using ProjetoEmprestimo.Repository.Contract;
using System.Data;

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

        public Livro ObterLivros(int codLivro)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from tbLivro where codLivro = @CodLivro", conexao);

                cmd.Parameters.Add("@CodLivro", MySqlDbType.Int32).Value = codLivro;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataReader dr;

                Livro livro = new Livro();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    livro.codLivro = dr.GetInt32(0);
                    livro.nomeLivro = dr.GetString(1);
                    livro.imagemLivro = dr.GetString(2);
                    livro.RefCategoria.codCateg = dr.GetInt32(3);
                }
                return livro;
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
            List<Livro> LivroList = new List<Livro>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from tbLivro", conexao);
                MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sd.Fill(dt);
                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    LivroList.Add(

                        new Livro
                        {
                            codLivro = Convert.ToInt32(dr["codLivro"]),
                            nomeLivro = (String)(dr["nomeLivro"]),
                            imagemLivro = (String)(dr["imagemLivro"]),
                            quantidadeLivro = (int)(dr["quantidadeLivro"]),
                            RefCategoria = new Categoria
                            {
                                codCateg = Convert.ToInt32(dr["codCateg"]),
                                descricao = (String)(dr["descricao"])
                            }
                        }
                     );
                }
                return LivroList;
            }
        }
    }
}
