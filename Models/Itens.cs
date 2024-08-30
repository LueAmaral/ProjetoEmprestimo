using System.ComponentModel;

namespace ProjetoEmprestimo.Models
{
    public class Itens
    {
        [DisplayName("Código Emprestimo")]
        public int codEmp { get; set; }
        [DisplayName("Código Livro")]
        public int codLivro { get; set; }
        [DisplayName("Nome Livro")]
        public string nomeLivro { get; set; }
        [DisplayName("Imagem Livro")]
        public string imageLivro { get; set; }
        [DisplayName("Quantidade")]
        public int quantidadeLivro { get; set; }
    }
}
