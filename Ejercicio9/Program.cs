using System;

class NumeroPrimoYNoPrimo
{
    static void Main()
    {
        int num, divi, divisi;
        divisi = 0;
        Console.Write("Por favor ingrese un numero: ");
        num = int.Parse(Console.ReadLine());
        for (divi = 1; divi <= num; divi++)
        {
            if (num % divi == 0)
            {
                divisi = divisi + 1;
            }
        }
        if (divisi == 2)
        {
            Console.WriteLine("El número es primo");
        }
        else
        {
            Console.WriteLine("El número no es primo");
        }

        Console.ReadKey();
    }
}
