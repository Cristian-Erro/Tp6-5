using System;

namespace C_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Variables e inicializacion.
            
            int nro1=0;
            int nro2=0;
            //Entradas de datos.
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Por favor, ingrese el primer numero a calcular");
            Console.WriteLine("--------------------------------------------");
            nro1=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Por favor, ingrese el segundo numero a calcular");
            Console.WriteLine("--------------------------------------------");
            nro2=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Resultado y llamado a la funcion.
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Resulta que "+comparar(nro1,nro2));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("////////Presione una tecla para salir///////");
            Console.ReadKey();
            Console.ResetColor();
        }
            //Funcion que compara los dos Int para determinar cual numero es mayor o si son iguales.
            static string comparar(int nro1,int nro2)
            {
             string resultado="";
             if (nro1<nro2){ 
                resultado="el segundo numero es mayor :)";
            }
            if (nro1>nro2){ 
                resultado="el primer numero es mayor :)";
            }
            if (nro1==nro2){
                resultado="ambos numeros son iguales :(";
            }
            return resultado;
            }
    }
}
