using System;
class Programa
{
    static int LIMITE_GLOBAL = 80;
    static double Ingresar()
    {
        Console.WriteLine("Ingrese temperatura: ");
        double temperatura = double.Parse(Console.ReadLine()!);
        return temperatura;
    }
    static bool Validar(double temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("Temperatura invalida");
            return false;
        }
        return true;
    }
    static String Evaluar(double temp)
    {
        if (temp > LIMITE_GLOBAL)
            return "ALERTA";
        return "NORMAL";
    }
    static void Mostrar(string resultado)
    {
        Console.WriteLine("Estado: " + resultado);
    }
    static void Main()
    {
        double temp = Ingresar();

        if (Validar(temp))
        {
            string estado = Evaluar(temp);
            Mostrar(estado);
        }
    }
}