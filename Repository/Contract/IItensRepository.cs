using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.Repository.Contract
{
    public interface IItensRepository
    {
        // CRUD
        IEnumerable<Livro> ObterTodosItens();
        void CadastrarItens(Itens itens);
        void AtualizarItens(Itens itens);
        void DeletarItens(Itens itens);
        Livro ObterItemPorId(int codItem);
    }
}
