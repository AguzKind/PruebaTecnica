using System;
using System.Collections.Generic;

namespace Punto_1
{
    internal class Program
    {
        /* 
             * Dada la siguiente problemática: ¿puede un número X formarse
             * usando la suma de 2 elementos de un array?
             * 
             * Ejemplo 1:
             * Input: nums = [1,4,3,9], requiredSum = 8
             * Output: False
             * 
             * Ejemplo 2:
             * Input: nums = [1,2,4,4], requiredSum = 8
             * Output: True
             * 
             * 1.Desarrolle un algoritmo que resuelva el problema asumiendo que la máquina en donde va a correrse el
             * programa tiene recursos infinitos, que el tiempo de ejecución no importa y que lo más
             * importante es realizar el desarrollo en el menor tiempo posible.
             * 
             * 2. Un algoritmo que resuelva el problema asumiendo que los recursos son un bien preciado,
             * que el tiempo de ejecución si importa y que el tiempo de desarrollo no es importante.
        */
        
        // Lo mas rapido que se me ocurrio fue crear una funcion la cual reciba el array por parametro
        // y luego inicializar 2 bucles for para comparar cada valor dentro del array. Si es igual a 8
        // retorna true, caso contrario false.
        static bool ArraySumaDaOcho(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] + numeros[j] == 8)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] numerosEjemplo1 = {1, 4, 3, 9};
            int[] numerosEjemplo2 = {1, 2, 4, 4};
            string resultadoEjemplo1 = $" El primer ejemplo da como resultado: {ArraySumaDaOcho(numerosEjemplo1)}";
            string resultadoEjemplo2 = $" El segundo ejemplo da como resultado: {ArraySumaDaOcho(numerosEjemplo2)}";
            Console.WriteLine(resultadoEjemplo1);
            Console.WriteLine(resultadoEjemplo2);
        }
    }
}
