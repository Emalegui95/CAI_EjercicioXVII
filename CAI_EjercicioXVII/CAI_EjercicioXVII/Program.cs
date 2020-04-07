using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioXVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[5]; // se declara e instancia un array de tipo Empleado, llamado empleados con una longitud de 5
            float sfloat = 0; // se declara e instancia una variable float que se utilizará para el sueldo
            float smax = 0; // se declara e instancia una variable de tipo float para almacenar el sueldo más alto
            string ecaro = " "; // se declara e instancia una variable de tipo string para almacenar el nombre del empleado más caro

            for (int i = 0; i < 5; i++)
            {
                empleados[i] = new Empleado(); // se instancia un objeto de la clase Empleado

                Console.Write("Ingrese un nombre: ");
                empleados[i].Nombre = Console.ReadLine();

                Console.Write("Ingrese el sueldo del empleado: ");

                try
                {
                    sfloat = float.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Por favor, ingresar solo números: ");
                    Console.Write("Ingrese el sueldo del empleado: ");
                    sfloat = float.Parse(Console.ReadLine());

                }

                empleados[i].Sueldo = sfloat;

                if (empleados[i].Sueldo > smax)
                {
                    smax = empleados[i].Sueldo;
                    ecaro = empleados[i].Nombre;
                }
            }

            Console.Write("El sueldo máximo de $" + smax + " pertenece al empleado " + ecaro);
            Console.ReadKey(true);
        }
    }
}
