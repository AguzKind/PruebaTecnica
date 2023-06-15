using System;
using System.Collections.Generic;

namespace Punto_2
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

        /* Para este punto, en vez de comparar todos los pares de numeros posibles dentro del array,
         * lo que se me ocurrio fue utilizar una busqueda lineal y ordenada, ya que el array ya esta ordenado.
         * Despues de ordenarlo, creo un bucle while condicionando que el puntero inicio sea menor que el
         * puntoro fin.
         * Si la suma de los numeros dentro del array en los punteros, devuelve true.
         * Si es menor que 8, se incrementa el puntero inicio para ir buscando combinaciones de numeros mas grandes dentro del array.
         * Si es mayor que 8, se decrementa el puntero fin para buscar combinaciones de numeros mas chicos dentro del array.
         * Si no se encuentra una suma igual a 8, se devuelve false.
        */
        static bool ArraySumaDaOcho(int[] numeros)
        {
            Array.Sort(numeros);
            int inicio = 0;
            int fin = numeros.Length - 1;

            while (inicio < fin)
            {
                int suma = numeros[inicio] + numeros[fin];

                if (suma == 8)
                {
                    return true;
                }
                else if (suma < 8)
                {
                    inicio++;
                }
                else
                {
                    fin--;
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