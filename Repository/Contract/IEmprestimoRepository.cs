using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.Repository.Contract
{
    public interface IEmprestimoRepository
    {
        // CRUD
        IEnumerable<Livro> ObterTodosEmprestimos();
        void CadastrarEmprestimo(Emprestimo emprestimo);
        void AtualizarEmprestimo(Emprestimo emprestimo);
        void DeletarEmprestimo(Emprestimo emprestimo);
        Livro ObterEmprestimo(int codEmp);
        Livro ObterEmprestimoPorId(int codEmp);
    }
}
