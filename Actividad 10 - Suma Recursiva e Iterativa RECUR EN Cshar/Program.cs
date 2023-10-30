using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static int SumaRecursiva(int n)
    {
        if (n <= 9)
        {
            return n;
        }
        else
        {
            return SumaRecursiva(n / 10) + n % 10;
        }
    }

    static void Main()
    {
        int numero = 12345;
        int resultado = SumaRecursiva(numero);
        Console.WriteLine($"La suma de los dígitos de {numero} es {resultado}");
    }
}