namespace ProgramacionEstructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas;
            string nombrePersona;
            int edadPersona;

            Console.WriteLine("Bienvenido al programa para poder clasificar personas");
            Console.Write("Ingresa la cantidad de personas a registrar: ");
            cantidadPersonas = int.Parse(Console.ReadLine());

            if (cantidadPersonas == 1)
            {
                Console.WriteLine("Ingrese el nombre de la persona 1");
                nombrePersona = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona 1");
                edadPersona = int.Parse(Console.ReadLine());

                if (edadPersona < 18)
                {
                    Console.WriteLine(nombrePersona + " Es menor de edad");
                }
                else
                {
                    Console.Write(nombrePersona + " Es mayor de edad");
                }

            }
            else
            {
                List<int> edadesPersonasMenores = new List<int>();
                List<int> edadesPersonasMayores = new List<int>();
                List<string> nombresPersonasMenores = new List<string>();
                List<string> nombresPersonasMayores = new List<string>();

                for (int i = 1; i <= cantidadPersonas; i++)
                {
                    Console.WriteLine("Ingresa el nombre de la persona " + i);
                    nombrePersona = Console.ReadLine();

                    Console.WriteLine("Ingresa la edad de la persona");
                    edadPersona = int.Parse(Console.ReadLine());

                    if (edadPersona < 18)
                    {
                        nombresPersonasMenores.Add(nombrePersona);
                        edadesPersonasMenores.Add(edadPersona);
                    }
                    else
                    {
                        nombresPersonasMayores.Add(nombrePersona);
                        edadesPersonasMayores.Add(edadPersona);
                    }
                }

                Console.WriteLine("Edades personas mayores");

                for (int i = 0; i < edadesPersonasMayores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMayores[i] + " - " + edadesPersonasMayores[i]);
                }

                Console.WriteLine("Edades personas menores");

                for (int i = 0; i < edadesPersonasMenores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMenores[i] + " - " + edadesPersonasMenores[i]);
                }
            }
        }
    }
}
