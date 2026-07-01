namespace SA_Programacao.script.Personagem
{
    using SA_Programacao.script.Personagem.Mensagem;
    using SA_Programacao.script.Personagem.Sprits;
    public class PersonagemProtagonista : Abs_Personagem
    {
        public int Karma { get; private set; }
        public bool LeuLivro { get; private set; }


        public PersonagemProtagonista(string nome) :
            base(nome, new MensagemProtagonista(), new SpritProtagonista()) 
        {
            Karma = 0;
            LeuLivro = false;
        }

        public void LerLivro() => LeuLivro = true;
        public void ModificarKarma(int valor) => Karma = valor; 
    }
}
