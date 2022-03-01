using System;

namespace TarefaProgramaçãoEstruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] números = new int[10];
            int resultadoMaior = 0;
            int resultadoMenor;
            
            números=pegarNúmeros();
            números=TransformarArray(números);
            acharMaior( ref resultadoMaior,números );
            acharMenor(out resultadoMenor, números);
            mostrarMenorMaior(resultadoMaior,resultadoMenor);
            ValorMedio(números);
            TresMaiores(números);
            numerosNegativos(números);
            númerosSequencia(números);
            Console.WriteLine("Escreva o número para remover");
            int NúmeroParaRemover = Convert.ToInt32(Console.ReadLine());
            RemovendoUmNúmero(números, NúmeroParaRemover);

        }
        static int[] pegarNúmeros()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int a;
                Console.WriteLine($"Escreva os números {i+1}");
                a = Convert.ToInt32(Console.ReadLine());
                arr[i] = a;
            }
            
            return arr;
        }
        static int[] TransformarArray(int[]array)
        {  
            Array.Sort(array);
            return array;
        } 
        static void acharMaior(ref int resultado, int[] números)
        {
            resultado = números[9];
        }
        static void acharMenor(out int menor,int[] números )
        {
            menor = números[0];
           
        }
        static void mostrarMenorMaior(int resultadoMaior, int resultadoMenor)
        {
            Console.WriteLine($"O Maior número é: {resultadoMaior} ");
            Console.WriteLine($"O Menor número é: {resultadoMenor} ");
        }
        static void ValorMedio(int[] números)
        {
            float a = 0;
            float media = 0;
            for (int i = 0; i < números.Length; i++)
            {
                media = (a += números[i]) / 10;
            }
            Console.WriteLine($"A média é: {media}");
        }
        static void TresMaiores(int[] números )
        {
            int numberLenth = números.Length; 
            Console.WriteLine($"Os tres maiores números são: {números[numberLenth-3]},{números[numberLenth-2]},{números[numberLenth-1]}");
        }
        static void numerosNegativos(int[] números)
        {

            Console.Write("os números Negativos são: ");
            for (int i = 0; i < números.Length; i++)
            {
                
                if (números[i] < 0)
                {
                    
                    Console.Write(números[i]);
                }
            }
            Console.WriteLine();
        }  
        static void númerosSequencia(int[] números)
        {
            string a = "";
            Console.Write("Os números em sequencia são: ");
            for (int i = 0; i < números.Length; i++)
            {                   
                a += Convert.ToString(números[i]);
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < 9)
                {
                    Console.Write(',');
                }
            }
                Console.WriteLine();
        }
        static void RemovendoUmNúmero(int[] números,int numeroParaRemover)
        {
            string a = "";
            int qtdRemover = 0;
            Console.Write("Removendo o Número escolhido: ");
            for (int i = 0; i < números.Length; i++)
            {
                if (números[i] == numeroParaRemover)
                {
                    qtdRemover++;
                }
            }
            int[] novaArray = new int[números.Length - qtdRemover];
            int j = 0;
            for (int i = 0; i < números.Length; i++)
            {
                if (números[i] != numeroParaRemover)
                {
                    novaArray[j] = números[i];
                    j++;
                }
            }
            números = novaArray;
            for (int i = 0; i < números.Length; i++)
            {
                Console.Write(números[i]);
            }
            Console.WriteLine();
        }
    }
}
