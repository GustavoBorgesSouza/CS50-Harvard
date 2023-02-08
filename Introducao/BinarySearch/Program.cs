using System;

namespace BinarySearch
{
    class Program
    {
        /// <summary>
        /// Função que ordena o array
        /// </summary>
        /// <param name="array">array a ser ordenado</param>
        /// <returns>array ordenado</returns>
        static string[] OrdenarArray(string[] array)
        {
            Array.Sort(array);

            return array;
        }

        /// <summary>
        /// Função que vai procurar a pessoa desejada na lista entregue
        /// </summary>
        /// <param name="array">Lista/Vetor ordenado com as pessoas</param>
        /// <param name="pessoaASerProcurada">Pessoa a ser procurada na lista</param>
        /// <param name="esquerdaMaxima">Pensando como um livro, a parte máxima a esquerda possível</param>
        /// <param name="direitaMaxima">Pensando como um livro, a parte máxima a direita possível</param>
        /// <returns>Uma string dizendo se a pessoa foi encontrada, mostrando tambem o índice da pessoa quando encontrada</returns>
        static string ProcurarPessoaNaLista(string[] array, string pessoaASerProcurada, int esquerdaMaxima, int direitaMaxima)
        {
            if (esquerdaMaxima > direitaMaxima)
            {
                return "A pessoa não foi encontrada na lista :(";
            } 

            int meio = (esquerdaMaxima + direitaMaxima) / 2;

            if (array[meio].CompareTo(pessoaASerProcurada) == 0)
            {
                string encontrado = $"\n Aqui está:  {array[meio]} foi encontrado(a) na posição {meio + 1} da lista \n";

                return encontrado;
            }
            else if (array[meio].CompareTo(pessoaASerProcurada) < 0)
            {
                return ProcurarPessoaNaLista(array, pessoaASerProcurada, meio + 1, direitaMaxima);
            }
            else
            {
                return ProcurarPessoaNaLista(array, pessoaASerProcurada, esquerdaMaxima, meio - 1);
            }
        }

        static void Main(string[] args)
        {

            string[] listaNomes = { "Sheldon Krueger", "Keeley Nickerson", "Bill Derrick", "Clare Casteel", "Zachariah Heller", "Baby Wimberly", "Tylor Givens", "Susan Mathias", "Hailey Leavitt", "Haylie Hough", "Bridgett Kunz", "Leroy Hagan", "Daryl Isaacs", "Roy Riggins", "Monserrat Anderson", "Roland Earle", "Daren Voss", "Steve Cormier", "Notnamed Fenton", "Wilson Howard", "Callie Coble", "Mindy Dougherty", "Kameron Hollingsworth", "Tea Caron", "Breana Lackey", "Zoie Rios", "Glen Solorzano", "Kaylee Vega", "Sydni Kay", "Elisha Crews" };

            Console.WriteLine("Hello World!");

            string[] listaAlfabetica = OrdenarArray(listaNomes);

            Console.WriteLine("Olá, quem você gostaria de achar na nossa lista telefônica?");
            string pessoaProcurada = Console.ReadLine();

            Console.WriteLine($"\n A pessoa a ser procurada na lista de {listaAlfabetica.Length} pessoas é {pessoaProcurada}\n");


            string resultado = ProcurarPessoaNaLista(listaAlfabetica, pessoaProcurada, 0, listaAlfabetica.Length - 1);

            Console.WriteLine(resultado);
        }

    }
}
