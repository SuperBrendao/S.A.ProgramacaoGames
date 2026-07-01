namespace SA_Programacao.script.Personagem.Mensagem
{
    using System.Collections.Generic;
    
    public abstract class Abs_Mensagem
    {
        protected List<string> Texto;

        public virtual string MostrarMensagem(int indice) =>
            Texto[indice]; 
    }
}
