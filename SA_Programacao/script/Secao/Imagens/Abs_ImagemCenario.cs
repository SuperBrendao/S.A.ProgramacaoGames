namespace SA_Programacao.script.Secao.Imagens
{
    public abstract class  Abs_ImagemCenario
    {
        public string imagem;
        public string nome;

        protected Abs_ImagemCenario(string imagem) => this.imagem = imagem;

        public virtual void MostarImagem() => System.Console.WriteLine(imagem);

    }
}
