namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.TratamentoDeTexto;
    using System;

    public class SecaoInicio : Abs_Secao
    {
        public SecaoInicio(PersonagemProtagonista protagista) : base(protagista) { }
        public override void Iniciar()
        {
            Texto.Mostrar("Nesse jogo suas escolhas determinam o Karma de\nseu personagem e dirão se ele é alguém puramente ruim ou alguém bondoso");
            Texto.Mostrar("esse é Hendriks, um Garoto de 18 anos que estuda \nno ensino médio, Hendriks é um garoto Introvertido \nque tem apenas uma amizade e tem leves traços de arrogância e narcisismo e psicopatia");
            Texto.Mostrar("A caminho de sua escola uma Senhora pede ajuda \npara Hendriks");
            Texto.Mostrar("Com licença, querido, será que você poderia \nme dar uma ajudinha?");




            bool saida = true;
            string entrada;

            do
            {
                //Mensagem
                Console.WriteLine("Escolha uma das opções a seguir:");
                Console.WriteLine("1 - ajudar a veia");
                Console.WriteLine("2 - nao ajudar a veia");

                //Entrada
                entrada = Texto.FiltroDeEntrada(new string[] { "1", "2" });

                if (entrada != null) saida = false;


            } while (saida);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);

            if (entrada == "1")//ajuda
            {
                protagonista.MostrarMensagem(1);
                protagonista.ModificarKarma(20);
                protagonista.ChegouAtrasado();
               
                escolher.IniciarSecao("aula2");
                return;

            }
            if (entrada == "2")//nao ajuda
            {
                protagonista.MostrarMensagem(0);
                protagonista.ModificarKarma(-20);

                escolher.IniciarSecao("aula1");
                return;
            }
        }
           
 
            
    }  
}

