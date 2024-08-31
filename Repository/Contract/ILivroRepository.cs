﻿using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.Repository.Contract
{
    public interface ILivroRepository
    {
        // CRUD
        IEnumerable<Livro> ObterTodosLivros();
        void CadastrarLivro(Livro livro);
        void AtualizarLivro(Livro livro);
        void DeletarLivro(int codLivro);
        Livro ObterLivroPorId(int codLivro);
    }
}
