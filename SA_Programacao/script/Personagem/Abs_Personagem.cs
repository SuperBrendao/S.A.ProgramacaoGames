namespace SA_Programacao
{
    using SA_Programacao.script.Personagem.Mensagem;
    using SA_Programacao.script.Personagem.Sprits;
    using SA_Programacao.script.TratamentoDeTexto;
    public abstract class Abs_Personagem
    {
        public readonly string nome;
        protected Abs_Mensagem Mensagem;
        protected Abs_Sprit Sprit;

        protected Abs_Personagem(string nome, Abs_Mensagem Mensagem, Abs_Sprit Sprit) 
        {
            this.nome = nome;
            this.Mensagem = Mensagem;
            this.Sprit = Sprit;
        }

        public void MostrarMensagem(int indice) =>
            Texto.Mostrar(this.nome, Mensagem.MostrarMensagem(indice));
           

        public void MostarSprit(int indice) =>
            Sprit.MostrarSprit(indice);
    }
}
