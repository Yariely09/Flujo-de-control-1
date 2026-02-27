namespace Flujo_de_control1
{

    /*
     Crear un programa que lea el sueldo de un empleado, calcule el ISR (Impuesto Sobre la
Renta) y muestre en pantalla el resultado, de acuerdo con una escala salarial disponible
en la plataforma de la DGII. Para realizar el cálculo, debe investigar cómo se realiza
para este país y en base a este año. El resultado debe ser el sueldo y cuanto debe pagar
por el ISR, si no aplica, colocar N/A
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string empleado;
            double sueldo, isr;

            Console.WriteLine("Ingrese el nombre del empleado:");
            empleado = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = Convert.ToDouble(Console.ReadLine());
            double sanual = sueldo * 12;

            isr = 0;

            if (sanual < 416220)
            {
                Console.WriteLine($"el ISR a pagar es: N/A");
            }
            else if (sanual >= 416220 && sanual <= 624329)
            {
                isr = (sanual - 416220) * 0.15;
                Console.WriteLine("el ISR a pagar es: " + isr);
            }
            else if (sanual >= 624330 && isr <= 867123)
            {
                isr = (sanual - 624330) * 0.20 + 31216.5;
                Console.WriteLine("el ISR a pagar es: " + isr);
            }
            else if (sanual >= 867124)
            {
                isr = (sanual - 867124) * 0.25 + 79776.5;
                Console.WriteLine("el ISR a pagar es: " + isr);
            }

            Console.WriteLine("El sueldo del empleado " + empleado + " es: " + sueldo);
            Console.WriteLine("El sueldo anual del empleado " + empleado + " es: " + sanual);

            double IsrMen = isr / 12;
            Console.WriteLine("El ISR mensual del empleado " + empleado + " es: " + IsrMen);

        }
    }
}