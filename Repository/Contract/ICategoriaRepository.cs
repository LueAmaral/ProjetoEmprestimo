﻿using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.Repository.Contract
{
    public interface ICategoriaRepository
    {
        // CRUD
        IEnumerable<Livro> ObterTodasCategorias();
        void CadastrarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        void DeletarCategoria(Categoria categoria);
        Livro ObterCategoria(int codCateg);
        Livro ObterCategoriaPorId(int codCateg);
    }
}
