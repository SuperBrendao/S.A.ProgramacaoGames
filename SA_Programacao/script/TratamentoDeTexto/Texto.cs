using System;
using System.Threading;

namespace SA_Programacao.script.TratamentoDeTexto
{
    public static class Texto
    {
        private static int tamanhoMax = 100;
        private static  int TempoDeExecução = 20;

        private static void Escrever(string texto,int time=0) 
        {

            if (time == 0) { System.Console.Write(texto); return; }
            
                for (int indice = 0; indice < texto.Length; indice++)
                {
                    Thread.Sleep(time);
                    System.Console.Write(texto[indice]);
                }
                System.Console.WriteLine("\n");
        }



        private static void MensagemEnter() 
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            Escrever("\nAperte qualquer tecla para continuar");

          

            System.Console.ReadKey(true);
            System.Console.ResetColor();
            System.Console.Clear();
        }    

        //
        //
        //

        public static string FiltroDeEntrada(string[] filtro) 
        {
            var Entrada = System.Console.ReadLine();

            foreach (var item in filtro)
                if (Entrada.ToLower() == item) {
                    Console.Clear();
                    return item;
                    }
            
            Console.Clear();
            Mostrar("Por favor digite aquilo que foi pedido");
            Console.Clear();

            return null;
        }

        //
        //
        //

        public static void Mostrar(string texto) 
        {
            string MolturaDaMensagem = "";
            
            //Moldura Mensagem
            for (int indice = 0; indice < tamanhoMax; indice++)
                MolturaDaMensagem += "=";

          
            Escrever(MolturaDaMensagem+"\n");
            Escrever(texto,TempoDeExecução);
            MensagemEnter();
        }

        //
        //
        //

        public static void Mostrar(string nome, string texto) 
        {
            nome ="|| "+nome+" ||"; 
            string MolturaDoNome="";
            string MolturaDaMensagem="";
           
            //Moldura Nome
            for (int indice = 0; indice < nome.Length-2; indice++)
                MolturaDoNome += "=";
            
            MolturaDoNome = "X" + MolturaDoNome + "X";

            //Moldura Mensagem
            for (int indice = 0; indice < tamanhoMax - MolturaDoNome.Length; indice++)
                MolturaDaMensagem += "=";

            MolturaDoNome = MolturaDoNome + "\n" + nome + "\n" + MolturaDoNome; 
            MolturaDaMensagem += "\n";

            Escrever(MolturaDoNome+MolturaDaMensagem);
            Escrever(texto, TempoDeExecução);
            MensagemEnter();
        }
    }
}
