namespace Ejercicio2
{
    public class Hora
    {
        public static void mostrarHora()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("La hora actual es: " + now.ToString("HH:mm"));
        }
    }
}