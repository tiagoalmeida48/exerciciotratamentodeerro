using System;

namespace ExercicioConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            try
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Não foi possivel converter");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Final da execução do programa");
            }
        }
    }
}
