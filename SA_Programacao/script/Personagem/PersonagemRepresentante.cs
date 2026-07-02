
namespace SA_Programacao.script
{
    using SA_Programacao.script.Personagem.Mensagem;
    using SA_Programacao.script.Personagem.Sprits;
    public class PersonagemRepresentante : Abs_Personagem
    {
        public PersonagemRepresentante() :
           base("Philip", new MensagemRepresentante(), new SpritRepresentante())
        { }
    }
}
