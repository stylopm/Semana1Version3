using System;
using System.Collections;

namespace Semana01Version3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplos para la semana 1");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            Program test = new Program();
            //test.condicionIf();
            //test.condicionSwitch();
            //test.cicloWhile();
            //test.cicloWhileDo();
            //test.cicloFor();
            //test.cicloForTablas();
            //test.cicloForBreak();
            //test.cicloForContinue();
            //test.mostrarArregloForeach();
            //test.mostrarArregloForeachParametros(cars);
            //test.agregarElementosArreglos(cars);
            //test.agregarElementosArreglosConAdd();
        }
        void condicionIf()
        {
            int age;
            Console.WriteLine("Dame un número");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }

        void condicionSwitch()
        {
            int day;
            Console.WriteLine("Dame el número de la semana");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Es fin de semana");
                    if (day == 6)
                    {
                        Console.WriteLine("Es Sábado");
                    }
                    else
                    {
                        Console.WriteLine("Es Domingo");
                    }
                    break;
                default:
                    Console.WriteLine("El número digitado no es un número de la semana");
                    break;
            }
        }

        void cicloWhile()
        {
            Console.WriteLine("Ejemplo de ciclo While");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        void cicloWhileDo()
        {
            Console.WriteLine("Ejemplo de ciclo While");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }

        void cicloFor()
        {
            Console.WriteLine("Ejemplo de ciclo For");
            for (int ciclo = 0; ciclo < 5; ciclo++)
            {
                Console.WriteLine($"Número {ciclo}");
            }

        }

        void cicloForTablas()
        {
            Console.WriteLine("Ejemplo de ciclo For en tablas de multiplicar");
            int table = 5;
            for (int ciclo = 1; ciclo <= 10; ciclo++)
            {
                Console.WriteLine($"{table} * {ciclo} = {table * ciclo}");
            }
        }

        void cicloForBreak()
        {
            Console.WriteLine("Ejemplo de ciclo For en tablas de multiplicar");
            int table = 5;
            for (int ciclo = 1; ciclo <= 10; ciclo++)
            {
                Console.WriteLine($"{table} * {ciclo} = {table * ciclo}");
                if (ciclo == 5) { break; }
            }
        }

        void cicloForContinue()
        {
            Console.WriteLine("Ejemplo de ciclo For en tablas de multiplicar");
            int table = 5;
            for (int ciclo = 1; ciclo <= 10; ciclo++)
            {
                if (ciclo == 5) { continue; }
                Console.WriteLine($"{table} * {ciclo} = {table * ciclo}");
            }
        }

        void ejemploArreglo()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Ejemplo de un arreglo");
            Console.WriteLine($"{cars}");
        }

        void mostrarArregloForeach()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Ejemplo de un arreglo");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }

        void mostrarArregloForeachParametros(string[] cars)
        {
            Console.WriteLine("Ejemplo de un arreglo parametros");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }

        void agregarElementosArreglos(string[] cars)
        {
            int[] arregloNumeros = new int[5];
            arregloNumeros[0] = 10;
            arregloNumeros[1] = 20;
            arregloNumeros[2] = 30;
            arregloNumeros[3] = 40;
            arregloNumeros[4] = 50;
            for (int ciclo = 0; ciclo < arregloNumeros.Length; ciclo++)
            {
                arregloNumeros[ciclo] = arregloNumeros[ciclo] * 10;
                Console.WriteLine(arregloNumeros[ciclo]);
            }
        }

        void agregarElementosArreglosConAdd()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
            }
            arlist1.Remove(4.5);
            Console.WriteLine("***************");
            Console.WriteLine("Salto de linea");
            Console.WriteLine("***************");
            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
            }
        }

    }
}
