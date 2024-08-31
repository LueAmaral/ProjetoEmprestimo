using ProjetoEmprestimo.Models;
using ProjetoEmprestimo.Repository.Contract;

namespace ProjetoEmprestimo.Repository
{
    public class ItensRepository : IItensRepository
    {
        public void AtualizarItens(Itens itens)
        {
            throw new NotImplementedException();
        }

        public void CadastrarItens(Itens itens)
        {
            throw new NotImplementedException();
        }

        public void DeletarItens(Itens itens)
        {
            throw new NotImplementedException();
        }

        public Livro ObterItemPorId(int codItem)
        {
            throw new NotImplementedException();
        }

        public Livro ObterItens(int codItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosItens()
        {
            throw new NotImplementedException();
        }
    }
}
