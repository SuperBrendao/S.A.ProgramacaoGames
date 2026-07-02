namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;

    public class SecaoAula2 : Abs_Secao
    {
        public SecaoAula2(PersonagemProtagonista protagista) :
            base(protagista, new SA_Programacao.script.Secao.Imagens.CenarioAula2()) 
        { }

        public override void Iniciar()
        {

            PersonagemMenina menina = new PersonagemMenina();
            PersonagemRepresentante cara = new PersonagemRepresentante();

            if (protagonista.chegouatrasado)
            {
                TextoS("Após ajudar a senhora Hendriks acaba chegando atrasado de sua escola e tem que esperar o segundo horário para entrar na sala, Hendriks então reflete");
                Escolha();
            }

            TextoS("Bate o sinal então Hendriks entra e vai para a educação física");

            menina.MostarSprit(0);
            TextoS("Na sala de educação física vemos sua amiga Kamilly\n" +
                "uma bela garota de olhos azuis e cabelos pretos\n" +
                "que é amiga de Hendriks desde sua infância",true);

            cara.MostarSprit(0);
            TextoS("E ali vemos Philip o Representante\n" +
                "de sala, que sempre teve uma rincha\n" +
                "com Hendriks, os dois se odeiam desde o começo da escola.",true);

            TextoS("Em meio a educação física a sala toda está focada no Interclasse\n" +
                "o Time de Hendriks precisa marcar um gol para ganhar Hendriks\n" +
                "está com a bola e precisa decidir entre fazer\n" +
                "o gol ou passar a bola para Philip");

            Escolha2();

            Escolher_Secao escolher = new Escolher_Secao(protagonista);
            escolher.IniciarSecao("intervalo");
        }
        private void Escolha() 
        {
            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                System.Console.WriteLine("O que o " + protagonista.nome + " acha sobre isso?");
                System.Console.WriteLine("1 - Gostou de ajudar");
                System.Console.WriteLine("2 - Nao Gostou de ajudar");

                //Entrada
                entrada = SA_Programacao.script.TratamentoDeTexto.Texto.FiltroDeEntrada(new string[] { "1", "2" });

                if (entrada != null) saida = false;


            } while (saida);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);

            if (entrada == "1")//nao gostou de ajudar
            {
                protagonista.MostrarMensagem(4);

            }
            if (entrada == "2")//gostou de ajudar
            {
                protagonista.MostrarMensagem(5);

            }
        }


        private void Escolha2() 
        {
            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                System.Console.WriteLine("O que o " + protagonista.nome + " vai fazer?");
                System.Console.WriteLine("1 - chutar o representante");
                System.Console.WriteLine("2 - fazer o gol");

                //Entrada
                entrada = SA_Programacao.script.TratamentoDeTexto.Texto.FiltroDeEntrada(new string[] { "1", "2" });

                if (entrada != null) saida = false;


            } while (saida);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);

            //chutar o representante
            if (entrada == "1") 
            {
                protagonista.ModificarKarma(-20);
                protagonista.Chutou();
                protagonista.MostrarMensagem(6);

                TextoS("Hendriks pensa em uma forma de sabotar Philip pois colocou a sala toda contra Hendriks");
                TextoS("Então Hendriks dá a bola para Philip e chuta a sua canela\n" +
                    "isso causa a saída de Philip da partida, e o time adversário ganha ");
                TextoS("Vemos a sala inteira xingando Hendriks\n" +
                    "e ficando contra ele menos sua amiga Kamilly que dá risadas");
                return;
            }

           //fazer o gol
                protagonista.ModificarKarma(20);
                protagonista.MostrarMensagem(7);
                TextoS("Hendriks dá um sorriso e pensa irei marcar para que a sala inteira me veja como um rei");
                TextoS("Então Hendriks faz o gol decisivo e ganha o interclasse");
                TextoS("Toda a sala comemora e gritando o nome dele\n, nesse momento vemos Philip o encarando e sentindo rancor");
            return;
        }
    }


   
    }

