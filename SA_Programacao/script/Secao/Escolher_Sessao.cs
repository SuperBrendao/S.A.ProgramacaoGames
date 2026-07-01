namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    public class Escolher_Secao
    {
        private  PersonagemProtagonista protagonista;
        


        public Escolher_Secao(PersonagemProtagonista protagonista) =>
            this.protagonista = protagonista;


        public  void IniciarSecao(string nome) =>
            Escolher(nome).Iniciar();
 

        private  Abs_Secao Escolher(string nome) 
        {
            switch (nome) 
            {
                case "inicio":
                    return new SecaoInicio(protagonista);
                case "aula1":
                    return new SecaoAula1(protagonista);
                case "aula2":
                    return new SecaoAula2(protagonista);
                case "aula3":
                    return new SecaoAula3(protagonista);
                case "aula4":
                    return new SecaoAula4(protagonista);
                case "final":
                    return new SecaoFinal(protagonista);
                default:
                    return null; 
            }
        }
    }
}
