using ProjetoEmprestimo.Models;
using ProjetoEmprestimo.Repository.Contract;

namespace ProjetoEmprestimo.Repository
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        public void AtualizarEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public void CadastrarEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public void DeletarEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public Livro ObterEmprestimo(int codEmp)
        {
            throw new NotImplementedException();
        }

        public Livro ObterEmprestimoPorId(int codEmp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosEmprestimos()
        {
            throw new NotImplementedException();
        }
    }
}
