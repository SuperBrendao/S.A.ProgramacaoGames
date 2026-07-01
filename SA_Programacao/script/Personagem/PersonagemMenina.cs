namespace SA_Programacao.script.Personagem
{
    using SA_Programacao.script.Personagem.Mensagem;
    using SA_Programacao.script.Personagem.Sprits;
    public class PersonagemMenina : Abs_Personagem
    {
        public PersonagemMenina() :
           base("Maria", new MensagemMenina(), new SpritMenina())
        { }
    }
}
