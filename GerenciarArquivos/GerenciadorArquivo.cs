namespace ProjetoEmprestimo.GerenciarArquivos
{
    public class GerenciadorArquivo
    {
        public static string CadastrarImagemProduto(IFormFile file)
        {
            var NomeArquivo = Path.GetFileName(file.FileName);
            var CaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Imagens", NomeArquivo);

            using (var stream = new FileStream(CaminhoArquivo, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Path.Combine("/Imagens", NomeArquivo).Replace("\\", "/");
        }
    }
}
