namespace SA_Programacao.script.TratamentoDeTexto
{
    public static class Texto
    {
        static int tamanhoMax = 50;

        private static void Escrever(string texto) => 
            System.Console.WriteLine(texto);

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
                if (Entrada.ToLower() == item) 
                    return item;

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

            MolturaDaMensagem += "\n" + texto;
            Escrever(MolturaDaMensagem);
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
            MolturaDaMensagem += "\n" + texto;

            Escrever(MolturaDoNome+MolturaDaMensagem);
            MensagemEnter();
        }
    }
}
