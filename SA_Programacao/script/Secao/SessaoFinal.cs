namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
 
    public class SecaoFinal : Abs_Secao
    {
        public SecaoFinal(PersonagemProtagonista protagista) : 
            base(protagista, new SA_Programacao.script.Secao.Imagens.CenarioFinal()) 
        { }
      
        public override void Iniciar()
        {
            Final();
            TextoS("O obrigado por jogar.....",true);
        }

        private void Final() 
        {
            if (protagonista.LeuLivro)
            {
                if (protagonista.Karma >= 20)
                {
                    //leu carta mas esta com karma alto
                    TextoS("Hendriks se torna o novo representante e vira o aluno favorito,\n" +
                        "acaba por ficar com Kamilly e se torna oque ele sempre quis ser o \n" +
                        "Cara Mais importante da escola");
                    TextoS("E bom lembramos que mesmo com as suas decisões\n" +
                        "sendo positivas Hendriks é um personagem que apresenta\n" +
                        "desvio de caráter e que fez tudo apenas para seu ganho pessoal.");
                    return;
                }
                //leu carta mas esta com karma baixo
                TextoS("Hendriks é visto como um monstro pela sala inteira\n" +
                    "e perde Kamilly, Após isso Hendriks acaba enlouquecendo e é\n" +
                    "internado com uma crise existencial grave.");
                return;
            }
            //nao leu carta
            TextoS("As pessoas da escola mantém opiniões divididas sobre Hendriks,\n" +
                "porém por ter ignorado a carta, Kamilly ficou esperando por ele e acabou\n" +
                "adoecendo e saindo da escola. Não houve uma despedida entre os dois e nem\n" +
                "nada do tipo, Hendriks acaba se culpando muito afinal perdeu a única pessoa\n" +
                "que o amava e agora estava sozinho em meio a pessoas que gostavam\n" +
                "momentaneamente e pessoas que o odiavam Como Hendriks não era alguém\n" +
                "sociável o suficiente ele ficaria sozinho de lá para frente e então\n" +
                "vira uma pessoa mais depressiva e melancólica.");
            return;
        }
    }
}

