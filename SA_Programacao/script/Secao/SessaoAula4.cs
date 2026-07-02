namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.TratamentoDeTexto;
    public class SecaoAula4 : Abs_Secao
    {
        public SecaoAula4(PersonagemProtagonista protagista) : base(protagista) { }
        public override void Iniciar()
        {
            Texto.Mostrar("Após o término dessa Aula Hendriks vai para o segundo andar de Escola");
            PonteDeEscolha();
            Escolher_Secao escolher_Secao = new Escolher_Secao(protagonista);
            escolher_Secao.IniciarSecao("final");
        }

        public void PonteDeEscolha() 
        {
            if (protagonista.LeuLivro)
            {

                if (protagonista.Karma >= 20) 
                {
                    //leu é gostou
                    Texto.Mostrar("Hendriks diz a ela que aceita ficar ao lado dela e que também sempre amou ela, e que ela é a única pessoa que ele se importa");
                    return;
                }
                //leu mas nao gostou
                Texto.Mostrar("Hendriks dá uma risadinha e olha para a Kamilly então ele diz");
                Texto.Mostrar("Eu nunca senti nada por você, \n" +
                    "você sempre foi apenas um passatempo para mim eu nunca sentiria nada por você.");
                return;
            }
            // nao leu



            return;
        }
    }
}
