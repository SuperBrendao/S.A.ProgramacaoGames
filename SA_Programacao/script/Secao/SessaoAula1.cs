
namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem; 

    public class SecaoAula1 : Abs_Secao
    {
        public SecaoAula1(PersonagemProtagonista protagonista) :
            base(protagonista, new SA_Programacao.script.Secao.Imagens.CenarioAula1()) 
        { }
        public override void Iniciar() 
        {
            TextoS("Após recusar ajudar a senhora Hendriks chega no Primeiro horário");
            TextoS("O professor explica sobre álgebra enquanto isso Hendriks analisa cada aluno da turma e pensa internamente");
            protagonista.MostrarMensagem(3);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);
            escolher.IniciarSecao("aula2");
        }
    }
}
