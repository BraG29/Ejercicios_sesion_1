using Ejercicio1;
using Ejercicio2;

namespace Main
{
    public class main
    {
        static void Main(string[] args)
        {
            short opcion = 0;
            Console.WriteLine("Por favor ingrese una opcion y presione enter: " +
                "\n1. Un saludo del programa (Ejercio 1)" +
                "\n2. Obtener la hora (Ejercicio 2)" +
                "\nPara salir ingrese cualquier otro numero");
            opcion = Int16.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Saludo.saludo();
                    break;
                case 2:
                    Hora.mostrarHora();
                    break;
                default:
                    break;
            }

        }
    }
}