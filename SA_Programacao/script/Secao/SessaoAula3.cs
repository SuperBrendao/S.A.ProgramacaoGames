namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;

    public class SecaoAula3 : Abs_Secao
    {
        public SecaoAula3(PersonagemProtagonista protagista) :
            base(protagista, new SA_Programacao.script.Secao.Imagens.CenarioAula3()) 
        { }
        
        public override void Iniciar()
        {
            Verificarsechutou();
            TextoS("Após isso os alunos chegam e o professor\n" +
                "separa Philip que partiu para cima de Hendriks então a aula ocorre");
          
            Escolher_Secao escolher_Secao = new Escolher_Secao(protagonista);
            escolher_Secao.IniciarSecao("aula4");
        }
         

     private void Verificarsechutou() 
        {
            PersonagemRepresentante Philip = new PersonagemRepresentante();

          if (protagonista.chutou)
          {
               Philip.MostrarMensagem(1);
               protagonista.MostrarMensagem(8);
               return;
          }

            Philip.MostrarMensagem(0);
            protagonista.MostrarMensagem(9);
            return;
        }
    }
}
