namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.TratamentoDeTexto;
    using System;
    using System.Security;

    public class SecaoAula2 : Abs_Secao
    {
        public SecaoAula2(PersonagemProtagonista protagista) : base(protagista) { }
        public override void Iniciar()
        {

            if (protagonista.chegouatrasado)
            {
                Texto.Mostrar("Após ajudar a senhora Hendriks acaba chegando atrasado de sua escola e tem que esperar o segundo horário para entrar na sala, Hendriks então reflete");
                Escolha();
            }

            Texto.Mostrar("Bate o sinal então Hendriks entra e vai para a educação física");
            Texto.Mostrar("Na sala de educação física vemos sua amiga Kamilly\n" +
                "uma bela garota de olhos azuis e cabelos pretos\n" +
                "que é amiga de Hendriks desde sua infância");
            Texto.Mostrar("E ali vemos Philip o Representante\n" +
                "de sala, que sempre teve uma rincha\n" +
                "com Hendriks, os dois se odeiam desde o começo da escola.");
            Texto.Mostrar("Em meio a educação física a sala toda está focada no Interclasse\n" +
                "o Time de Hendriks precisa marcar um gol para ganhar Hendriks\n" +
                "está com a bola e precisa decidir entre fazer\n" +
                "o gol ou passar a bola para Philip");

            Escolha2();

            Escolher_Secao escolher = new Escolher_Secao(protagonista);
            escolher.IniciarSecao("intervalo");
        }
        public void Escolha() 
        {
            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                Console.WriteLine("1 - Gostou de ajudar"); 
                Console.WriteLine("2 - - Nao Gostou de ajudar");

                //Entrada
                entrada = Texto.FiltroDeEntrada(new string[] { "1", "2" });

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


        public void Escolha2() 
        {
            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                Console.WriteLine("1 - chutar o representante");
                Console.WriteLine("2 - fazer o gol");

                //Entrada
                entrada = Texto.FiltroDeEntrada(new string[] { "1", "2" });

                if (entrada != null) saida = false;


            } while (saida);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);

            if (entrada == "1") //chutar o representante
            {
                protagonista.ModificarKarma(-20);
                protagonista.Chutou();
                protagonista.MostrarMensagem(6);

                Texto.Mostrar("Hendriks pensa em uma forma de sabotar Philip pois colocou a sala toda contra Hendriks");
                Texto.Mostrar("Então Hendriks dá a bola para Philip e chuta a sua canela\n" +
                    "isso causa a saída de Philip da partida, e o time adversário ganha ");
                Texto.Mostrar("Vemos a sala inteira xingando Hendriks\n" +
                    "e ficando contra ele menos sua amiga Kamilly que dá risadas");


            }
            if (entrada == "2")//fazer o gol
            {
                protagonista.ModificarKarma(20);
                protagonista.MostrarMensagem(7);
                Texto.Mostrar("Hendriks dá um sorriso e pensa irei marcar para que a sala inteira me veja como um rei");
                Texto.Mostrar("Então Hendriks faz o gol decisivo e ganha o interclasse");
                Texto.Mostrar("Toda a sala comemora e gritando o nome dele\n, nesse momento vemos Philip o encarando e sentindo rancor");
            }
        }
    }


   
    }

