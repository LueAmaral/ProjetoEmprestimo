using System.ComponentModel;

namespace ProjetoEmprestimo.Models
{
    public class Livro
    {
        [DisplayName("Código")]
        public int codLivro { get; set; }
        [DisplayName("Nome")]
        public string nomeLivro { get; set; }
        [DisplayName("Imagem")]
        public string imageLivro { get; set; }
        [DisplayName("Quantidade")]
        public int quantidadeLivro { get; set; }
        //[DisplayName("Categoria")]
        //public Categoria RefCategoria { get; set; }

    }
}
