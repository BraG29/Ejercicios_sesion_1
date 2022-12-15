namespace Ejercicio1
{
    public class Saludo
    {
        public static void saludo()
        {
            Console.WriteLine("Por favor ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}