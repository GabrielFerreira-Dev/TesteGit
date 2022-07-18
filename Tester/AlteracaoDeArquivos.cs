namespace TesteGit.Tester
{
    public class AlteracaoDeArquivos
    {
        public string Arquivo { get; set; }

        public AlteracaoDeArquivos()
        {

        }
        public AlteracaoDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
        }

        public override string ToString()
        {
            return "Arquivo "
            + Arquivo
            + " alterado.".ToString();
        }
    }
}