
namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.TratamentoDeTexto;

    public class SessaoIntervalo : Abs_Secao
    {
        public SessaoIntervalo(PersonagemProtagonista protagonista) : 
            base(protagonista) { }
        public override void Iniciar()
        {
            Texto.Mostrar("Nesse momento O sinal bate e Hendriks e sua turma vão para o Refeitório");
            Texto.Mostrar("Hendriks senta junto de sua amiga Kamilly e os dois conversam");

            ResultadoChute();

            Escolha();
            Texto.Mostrar("O sinal toca e Hendriks decide ir para a sala de aula quando chega lá ele vê que apenas Philip estava lá, Philip estava com uma cara de angústia e ódio");
            
            Escolher_Secao escolher_Secao = new Escolher_Secao(protagonista);
            escolher_Secao.IniciarSecao("aula3");
        }
        public void Escolha() 
        {
            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                System.Console.WriteLine("Após a conversa dos dois Hendriks vê que Kamilly esqueceu uma Carta na mesa enquanto foi para o banheiro, qual será sua decisão?");
                System.Console.WriteLine("1 - ler a carta ");
                System.Console.WriteLine("2 - ignorar a carta");

                //Entrada
                entrada = Texto.FiltroDeEntrada(new string[] { "1", "2" });

                if (entrada != null) saida = false;


            } while (saida);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);

            if (entrada == "1") 
            {
                protagonista.LerLivro();

                if (protagonista.Karma >= 20) 
                {
                    //leu e esta com karma possitivo
                    Texto.Mostrar("Hendriks lê a carta e acaba ficando tímido, Kamilly revela que sempre o amou e queria ficar ao lado dele que ela não se importava com oque as pessoas falavam sobre Hendriks.");
                    return;
                }

                //leu e esta com karma negativo
                Texto.Mostrar("Hendriks lê a carta e ri enquanto debocha, Kamilly revela que sempre o amou e queria ficar ao lado dele que ela não se importava com oque as pessoas falavam sobre Hendriks.");
                Texto.Mostrar("Hendriks cospe na carta e a joga no lixo, ele decide dizer o que sente no Último Horário de aula.");
                return;
            }
                //nao leu
                Texto.Mostrar("Hendriks decide respeitar a privacidade de Kamilly e ignora a carta.");
               return;         
        }

        public void ResultadoChute()
        {
            PersonagemMenina Kamilly = new PersonagemMenina();

            if (protagonista.chutou)
            {
                protagonista.MostrarMensagem(6);
                Kamilly.MostrarMensagem(0);
                return;
            }

            protagonista.MostrarMensagem(7);
            Kamilly.MostrarMensagem(1);
            return;
        }
    }
}
