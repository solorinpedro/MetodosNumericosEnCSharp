using System;

namespace Metodos_Numericos_En_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int Option;

            Console.WriteLine("Presione Cualquier Tecla Para Iniciar");
            Console.ReadKey();
            Console.Clear();

            //Mostrando el menu principal
            Console.WriteLine("Metodos Mumericos En C#\n");
            Console.WriteLine("1. Errores De Precisión\n");
            Console.WriteLine("2. Método De Disección\n");
            Console.WriteLine("3. Método De Newton Raphson\n");
            Console.WriteLine("4. Diferenciación Numérica\n");
            Console.WriteLine("5. Integración Numérica Método Del Rectángulo\n");
            Console.WriteLine("6. Integración Numérica Método Del Trapecio\n");
            Console.WriteLine("7. Integración Numérica Regla De Simpson\n");
            Console.WriteLine("Presione un numeró que pertenesca al rango y Luego Presione ENTER");
            Option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (Option)
            {

                case 1:
                    Console.WriteLine("Error De Precisión");
                    var metodo1 = new Errores_De_Precision();
                    metodo1.ErrorDePrecision();
                    break;

                case 2:
                    Console.WriteLine("Método De Bisección");
                    var metodo2 = new Metodo_De_Diseccion();
                    metodo2.MetodoDeDiseccion();
                    break;

                case 3:
                    Console.WriteLine("Método De Newton Raphson");
                    var metodo3 = new Metodo_De_Newton_Raphson();
                    metodo3.MetodoDeNewtonRaphson();
                    break;

                case 4:
                    Console.WriteLine("Diferenciación Numérica");
                    var menu4 = new Diferenciacion_Numerica();
                    menu4.DiferenciacionNumerica();
                    break;

                case 5:
                    Console.WriteLine("Integración Numérica Método Del Rectángulo");
                    var metodo5 = new Metodo_Del_Rectangulo();
                    metodo5.MetodoDelRectangulo();
                    break;

                case 6:
                    Console.WriteLine("Integración Numérica Método Del Trapecio");
                    var metodo6 = new Metodo_Del_Trapecio();
                    metodo6.MetodoDelTrapecio();
                    break;

                case 7:
                    Console.WriteLine("Integración Numérica Regla De Simpson");
                    var metodo7 = new Regla_De_Simpson();
                    metodo7.ReglaDeSimpson();
                    break;


                default:
                    Console.Write("Se ingreso un valor fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
