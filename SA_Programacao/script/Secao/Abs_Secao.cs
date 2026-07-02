namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    public abstract class Abs_Secao
    {
        protected PersonagemProtagonista protagonista;
        protected Abs_Secao(PersonagemProtagonista protagonista) => 
            this.protagonista = protagonista;

        public abstract void Iniciar();
    }
}
