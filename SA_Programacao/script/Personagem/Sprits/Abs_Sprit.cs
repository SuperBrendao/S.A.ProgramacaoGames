namespace SA_Programacao.script.Personagem.Sprits
{
    using System.Collections.Generic;
    public abstract class Abs_Sprit
    {
        protected List<string> sprit;
        public void MostrarSprit(int indice) => 
            System.Console.WriteLine(sprit[indice]);
    }
}
