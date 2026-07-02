
namespace SA_Programacao.script.Personagem.Mensagem
{
    using System;
    using System.Collections.Generic;
    public class MensagemMenina : Abs_Mensagem
    {
        public MensagemMenina() =>
            Texto = new List<string>
            {
             "Foi engraçado você chutar a perna dele em meio ao jogo, eu não acho que você tenha sido babaca como as pessoas dizem, elas não vêem as injustiças que Philip faz com você.", //0
             "Eu gostava mais quando era apenas nós dois contra a sala toda, mas fico feliz que seja visto como um herói por eles" //1
            };
    } 
}
