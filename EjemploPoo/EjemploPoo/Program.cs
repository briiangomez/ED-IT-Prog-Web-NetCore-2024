using System;
using System.Collections;
using System.Collections.Generic;

namespace EjemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado(5,4,3);
            //Console.WriteLine(String.Format("El perimetro del cuadrado es: {0}",cuadrado1.Perimetro));
            //Console.WriteLine($"El area del cuadrado es {cuadrado1.CalcularArea()}");
            //Console.ReadKey();

            /*Triangulo triangulo = new Triangulo(6,5,4);
            //Console.WriteLine(String.Format("El perimetro del triangulo es: {0}", triangulo.CalcularPerimetro()));
            //Console.WriteLine($"El area del triangulo es {triangulo.CalcularArea()}");
            Console.ReadKey();


            //Ejemplo Array
            int[] arrayEnteros = new int[5];
            Random random = new Random(); // Para agregar numeros aleatorios
            //iterar el Array
            Console.WriteLine("Agregando Info e Iterando el Array");
            for (int i = 0; i < 5; i++)
            {
                arrayEnteros[i] = random.Next(1, 100);
                Console.WriteLine($"Posicion: {i + 1} - Valor {arrayEnteros[i]}");
            }*/


            //Ejemplo ArrayList

            /*ArrayList lista1 = new ArrayList();

            lista1.Add(1);
            lista1.Add("Hola a todos!");
            lista1.Add(cuadrado1);
            lista1.Add(10.50);

            RecorrerArrayList(lista1);*/

            //Ordenamos la lista
            /*lista1.Sort();

            Console.WriteLine("\n Post Ordenamiento... \n");

            RecorrerArrayList(lista1);*/

            /*Console.WriteLine($"Verificacion 1 - Existe A - {lista1.Contains("A")}");
            Console.WriteLine($"Verificacion 2 - Existe 10.50 - {lista1.Contains(10.50)}");


            lista1.RemoveAt(0); // Eliminar por indice o posicion 
            lista1.Remove(10.50); // Eliminar por valor

            Console.WriteLine("\n Post Eliminacion... \n");

            RecorrerArrayList(lista1);

            //Verificar si existe en una lista

            Console.WriteLine($"Verificacion 1 - Existe A - {lista1.Contains("A")}");
            Console.WriteLine($"Verificacion 2 - Existe 10.50 - {lista1.Contains(10.50)}");

            List<string> nombres = new List<string>();

            nombres.Add("Brian");
            nombres.Add("Nicole");
            nombres.Add("Juan");
            nombres.Add("Agustin");

            foreach (string item in nombres)
            {
                Console.WriteLine(item + "\n");
            }*/

            /*SortedList<string, int> ListaOrdenada = new SortedList<string, int>();

            ListaOrdenada.Add("300", 3);
            ListaOrdenada.Add("100", 1);
            ListaOrdenada.Add("200", 2);
            ListaOrdenada.Add("500", 4);
            ListaOrdenada.Add("150", 5);

            foreach (var item in ListaOrdenada)
            {
                Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value}");
            }*/
            /*Random random = new Random(); // Para agregar numeros aleatorios
            List<int> numerosRandom = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 100);
                numerosRandom.Add(num);
            }
            //Ejemplo Cola

            Console.WriteLine("\n Cola \n");

            Queue<int> numeros = new Queue<int>();
            foreach (var item in numerosRandom)
            {
                numeros.Enqueue(item);
            }

            while (numeros.Count > 0) // Count = Devuelve la cantidad de elementos de una coleccion
            {
                int item = numeros.Dequeue();
                Console.WriteLine($"Numero : {item}");
            }

            Console.WriteLine("\n Pila \n");
            Stack<int> pilaNumeros = new Stack<int>();

            foreach (var item in numerosRandom)
            {
                pilaNumeros.Push(item);
            }

            while (pilaNumeros.Count > 0) // Count = Devuelve la cantidad de elementos de una coleccion
            {
                int item = pilaNumeros.Pop();
                Console.WriteLine($"Numero : {item}");
            }*/

            //Inicializador de Objetos
            /*List<string> nombres = new List<string>() { "Brian" , "Nicole", "Juan" ,"Agustin", "Damian", "Fiama" };

            Console.WriteLine("Con Foreach \n");
            foreach (string item in nombres)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("Con For \n");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i] + " ");
            }*/

            /*List<Galaxia> galaxias = new List<Galaxia>(){
                                        new Galaxia() { Nombre="Tadpole", MegaAniosLuz=400},
                                        new Galaxia() { Nombre="Pinwheel", MegaAniosLuz=25},
                                        new Galaxia() { Nombre="MilkyWay", MegaAniosLuz=0},
                                        new Galaxia() { Nombre="Andromeda", MegaAniosLuz=3}
                              };

            foreach (Galaxia item in galaxias)
            {
                Console.WriteLine(item.ToString());
            }

            var nro = 10.50; // Double
            var nro2 = 10.50m; //Decimal =  numero + m;

            Console.WriteLine(nro.GetType().FullName);
            Console.WriteLine(nro2.GetType().FullName);*/


            CuadradoAbs cuadrado = new CuadradoAbs(10);
            Console.WriteLine($"El area del Cuadrado desde la interfaz es {cuadrado.Area()}");
            Console.WriteLine($"El perimetro del Cuadrado desde la clase abstracta es {cuadrado.Perimetro()}");

            Console.ReadKey();
        }


        public static void RecorrerArrayList(ArrayList lista1)
        {
            //Recorrer mi ArrayList
            foreach (object item in lista1)
            {
                //Se muestra el tipo de objeto

                Console.Write($"Tipo de objeto:{ item.GetType().FullName} ");
                //Se decide como mostrar el item segun sea el tipo de objeto
                if (item.GetType() == typeof(System.Int32))
                {
                    int num = (int)item;
                    Console.WriteLine($"Valor Entero: {num}");
                }
                if (item.GetType() == typeof(string))
                {
                    Console.WriteLine($"Valor Texto: { item.ToString()}");
                }
                if (item.GetType() == typeof(Cuadrado))
                {
                    Cuadrado objCuadrado = (Cuadrado)item;
                    Console.WriteLine($"Valor: { objCuadrado.Perimetro}");
                }
                if (item.GetType() == typeof(System.Double))
                {
                    Console.WriteLine($"Valor Decimal: {(double)item}");
                }
            }
        }
    }
}
