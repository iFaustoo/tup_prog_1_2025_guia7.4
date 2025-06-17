using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejj2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string rta1, rta2;
            int impuestoMoto = 0, impuestoAuto = 0, impuestoUtilitario = 0, impuestoCamion = 0;
            int zonas = 0;
            int contMoto = 0, contAuto = 0, contUtilitario = 0, contCamion = 0;
            bool continuar = true;
            int i = 0;
            int horasMoto = 0, horasAuto = 0, horasUtilitario = 0, horasCamion = 0;
            double precioTotalMoto = 0, precioTotalAuto = 0, precioTotalUtilitario = 0, precioTotalCamion = 0;

            do
            {
                Console.WriteLine("Desea evaluar una zona? s/n");
                rta1 = Console.ReadLine().ToLower();
                if (rta1 == "s")
                {
                    Console.WriteLine("Evaluando zona número " + (i + 1));
                    Console.WriteLine("Ingrese vehículo a registrar: ");
                    Console.WriteLine("a. Moto");
                    Console.WriteLine("b. Auto");
                    Console.WriteLine("c. Utilitario");
                    Console.WriteLine("d. Camión");
                    rta2 = Console.ReadLine().ToLower();
                    switch (rta2)
                    {
                        case "a":
                            impuestoMoto += 100;
                            contMoto++;
                            break;
                        case "b":
                            impuestoAuto += 200;
                            contAuto++;
                            break;
                        case "c":
                            impuestoUtilitario += 250;
                            contUtilitario++;
                            break;
                        case "d":
                            impuestoCamion += 700;
                            contCamion++;
                            break;
                        default:
                            Console.WriteLine("Porfavor seleccione una opción válida");
                            break;
                    }

                    if (contMoto > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas");
                        horasMoto = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contAuto > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas");
                        horasAuto = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contUtilitario > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas");
                        horasUtilitario = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contCamion > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas");
                        horasCamion = Convert.ToInt32(Console.ReadLine());
                    }

                    precioTotalMoto = impuestoMoto * horasMoto;
                    precioTotalAuto = impuestoAuto * horasAuto;
                    precioTotalUtilitario = impuestoUtilitario * horasUtilitario;
                    precioTotalCamion = impuestoCamion * horasCamion;


                }

            }
            while (continuar == true);




        }
    }
}
