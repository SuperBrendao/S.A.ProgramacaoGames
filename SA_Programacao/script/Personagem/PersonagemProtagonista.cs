namespace SA_Programacao.script.Personagem
{
    using SA_Programacao.script.Personagem.Mensagem;
    using SA_Programacao.script.Personagem.Sprits;
    public class PersonagemProtagonista : Abs_Personagem
    {
        public int Karma { get; private set; }
        public bool LeuLivro { get; private set; }
        public bool chegouatrasado { get; private set; }
        public bool chutou {  get; private set; }


        public PersonagemProtagonista(string nome) :
            base(nome, new MensagemProtagonista(), new SpritProtagonista()) 
        {
            Karma = 0;
            LeuLivro = false; 
            chegouatrasado = false;
            chutou = false;
        }

        public void LerLivro() => LeuLivro = true;
        public void ModificarKarma(int valor) => Karma += valor; 
        public void ChegouAtrasado () => chegouatrasado = true;
        public void Chutou () => chutou = true;
    }
}
