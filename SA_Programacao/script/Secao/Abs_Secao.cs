namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.Secao.Imagens;

    public abstract class Abs_Secao
    {
        protected PersonagemProtagonista protagonista;
        private Abs_ImagemCenario cenario;

        public abstract void Iniciar();

        protected Abs_Secao(PersonagemProtagonista protagonista, Abs_ImagemCenario cenario = null)
        {
            this.protagonista = protagonista;
            this.cenario = (cenario==null)?new CenarioVasio() : cenario;
        }

        protected void TextoS(string texto,bool most=false) 
        {
            if(!most)EscolhaImagemCenario.Imagem(cenario);
            TratamentoDeTexto.Texto.Mostrar(texto);
        }
    }
}
