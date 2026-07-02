namespace SA_Programacao.script.Personagem.Mensagem
{
    using System.Collections.Generic;
    public class MensagemRepresentante : Abs_Mensagem
    {
        public MensagemRepresentante() =>
            Texto = new List<string>
            {
             "Porque Você quer sair como um herói? você não passa de um cara sem caráter que todos odeiam e desprezam.",//0
             "Você me fez sair da partida e fez o meu time perder, todos dessa sala te odeiam e te desprezam você é um fracassado."//1




            };
    }
}
