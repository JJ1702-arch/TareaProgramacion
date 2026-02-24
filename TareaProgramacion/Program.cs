using System;
using System.Collections.Generic;

namespace ProgramacionEstructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas = 0;
            bool entradaValida = false;

            Console.WriteLine("=== Sistema de Clasificación de Personas ===");

            // Validar cantidad de personas
            while (!entradaValida)
            {
                Console.Write("Ingrese la cantidad de personas a registrar: ");
                if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Esta mal. Vuelva a intentar");
                }
            }

            // Listas para almacenar datos 
            List<string> nombresTodos = new List<string>();
            List<int> edadesTodas = new List<int>();

            // Captura de datos con validación de edad
            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine($"\nRegistro de la persona #{i + 1}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                int edad = 0;
                bool edadValida = false;
                while (!edadValida)
                {
                    Console.Write("Edad: ");
                    if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                    {
                        edadValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Esta mal. Vuelva intentarlo solo con numeros");
                    }
                }

                nombresTodos.Add(nombre);
                edadesTodas.Add(edad);
            }

            // Caso especial: Una sola persona
            if (cantidadPersonas == 1)
            {
                Console.WriteLine("\n--- Resultado ---");
                string estado = (edadesTodas[0] >= 18) ? "Mayor de edad" : "Menor de edad";
                Console.WriteLine($"{nombresTodos[0]} es {estado}.");
            }
            // Caso general: Dos o más personas
            else
            {
                // Mostrar lista general primero
                Console.WriteLine("\n--- Lista General de Registrados ---");
                for (int i = 0; i < nombresTodos.Count; i++)
                {
                    Console.WriteLine($"{nombresTodos[i]} - {edadesTodas[i]} años");
                }

                // Listas para clasificación
                List<string> mayores = new List<string>();
                List<string> menores = new List<string>();

                for (int i = 0; i < nombresTodos.Count; i++)
                {
                    string info = $"{nombresTodos[i]} ({edadesTodas[i]} años)";
                    if (edadesTodas[i] >= 18) mayores.Add(info);
                    else menores.Add(info);
                }

                // Mostrar solo si contienen datos
                if (mayores.Count > 0)
                {
                    Console.WriteLine("\n--- Personas Mayores de Edad ---");
                    mayores.ForEach(p => Console.WriteLine(p));
                }

                if (menores.Count > 0)
                {
                    Console.WriteLine("\n--- Personas Menores de Edad ---");
                    menores.ForEach(p => Console.WriteLine(p));
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
