
namespace SA_Programacao.script.Secao
{
    using SA_Programacao.script.Personagem;
    using SA_Programacao.script.TratamentoDeTexto;
    public class SecaoAula1 : Abs_Secao
    {
        public SecaoAula1(PersonagemProtagonista protagonista) : base(protagonista) { }
        public override void Iniciar() 
        {
            Texto.Mostrar("Após recusar ajudar a senhora Hendriks chega no Primeiro horário");
            Texto.Mostrar("O professor explica sobre álgebra enquanto isso Hendriks analisa cada aluno da turma e pensa internamente");
            protagonista.MostrarMensagem(3);


            Escolher_Secao escolher = new Escolher_Secao(protagonista);
            escolher.IniciarSecao("aula2");
        }
    }
}
