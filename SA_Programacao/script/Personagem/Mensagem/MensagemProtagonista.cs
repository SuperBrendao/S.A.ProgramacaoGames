namespace SA_Programacao.script.Personagem.Mensagem
{
    using Microsoft.SqlServer.Server;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Runtime.ConstrainedExecution;

    public class MensagemProtagonista : Abs_Mensagem
    {
        public MensagemProtagonista() =>
            Texto = new List<string>
            {
                "Escute bem sua velha você precisa fazer as coisas sozinhas não seja uma incompetente.",//0
                "Eu te ajudo, deixa que eu carrego as suas compras",//1
                "As pessoas dessa sala são tão hipócritas\n"+
                "elas apenas gostam de quem tem status, são apenas peões manipuláveis, eu as odeio.",//2
                "Será que valeu apena ter ajudado aquela idosa\n" +
                "e ter sido punido chegando atrasado?",//3
                "Eu apenas perdi tempo e não fui beneficiado\n" +
                "ajudando uma velha desprezível uma ajuda sem ganhos não vale de nada.",//4
                "Eu acho que agi certo em ajudar aquela senhora, É bom ser visto como um Herói você pode ganhar a confiança fácil das pessoas e assim conseguir recompensas.",//5
                "Eu sinceramente não me importo com esse interclasse, toda as pessoas da sala são falsas e apenas querem alguém para odiar e crucificar", //6
                "Você viu Kamilly? Agora todos me amam e eu sou melhor que o Philip", //7
                "Eu sempre Senti nojo de todos dessa turma e mais ainda de você, você é uma farsa que faz de tudo para manter uma boa imagem.", //8
                "Eu fui odiado, Agora eu sou o mais importante para a turma e sou melhor que você, nesse momento você não passa de alguém descartável para a sala" //9








            };        
    }
}
