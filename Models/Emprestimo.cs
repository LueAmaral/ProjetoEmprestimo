using System.ComponentModel;

namespace ProjetoEmprestimo.Models
{
    public class Emprestimo
    {
        [DisplayName("Código Emprestimo")]
        public int codEmp { get; set; }
        [DisplayName("Data do Emprestimo")]
        public string dtEmp { get; set; }
        [DisplayName("Data de Devolução")]
        public string dtDev { get; set; }
        [DisplayName("Código Usuário")]
        public string codUsu { get; set; }
    }
}
