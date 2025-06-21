using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rta1, rta2;
            int zonas = 0;
            bool continuar = true;
            int i = 0;
            int acContMoto = 0, acContAuto = 0, acContUtilitario = 0, acContCamion = 0;
            int acPrecioTotalMoto = 0, acPrecioTotalAuto = 0, acPrecioTotalUtilitario = 0, acPrecioTotalCamion = 0;
            int acRecaudacionTotal = 0;
            int acContZona = 0;
            int contZona = 0;

            do
            {

                int contMoto = 0, contAuto = 0, contUtilitario = 0, contCamion = 0;
                int impuestoMoto = 0, impuestoAuto = 0, impuestoUtilitario = 0, impuestoCamion = 0;
                int precioTotalMoto = int.MinValue, precioTotalAuto = int.MinValue, precioTotalUtilitario = int.MinValue, precioTotalCamion = int.MinValue;
                int horasMoto = 0, horasAuto = 0, horasUtilitario = 0, horasCamion = 0;

                Console.WriteLine("Desea registrar un estacionamiento? s/n");
                rta1 = Console.ReadLine().ToLower();
                if (rta1 == "s")
                {
                    contZona++;
                    Console.WriteLine("Evaluando zona número " + (contZona));
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
                        Console.WriteLine("Ingrese la cantidad de horas compradas de la moto");
                        horasMoto = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contAuto > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas del auto");
                        horasAuto = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contUtilitario > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas del utilitario");
                        horasUtilitario = Convert.ToInt32(Console.ReadLine());
                    }
                    if (contCamion > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de horas compradas del camión");
                        horasCamion = Convert.ToInt32(Console.ReadLine());
                    }

                    precioTotalMoto = impuestoMoto * horasMoto;
                    precioTotalAuto = impuestoAuto * horasAuto;
                    precioTotalUtilitario = impuestoUtilitario * horasUtilitario;
                    precioTotalCamion = impuestoCamion * horasCamion;
                    int recaudacionTotal;
                    recaudacionTotal = precioTotalMoto + precioTotalAuto + precioTotalUtilitario + precioTotalCamion;

                    acContMoto += contMoto;
                    acContAuto += contAuto;
                    acContUtilitario += contUtilitario;
                    acContCamion += contCamion;

                    acPrecioTotalMoto += precioTotalMoto;
                    acPrecioTotalAuto += precioTotalAuto;
                    acPrecioTotalUtilitario += precioTotalUtilitario;
                    acPrecioTotalCamion += precioTotalCamion;

                    acRecaudacionTotal += recaudacionTotal;

                    Console.WriteLine("Datos:");

                    if (contMoto > 0 || contAuto > 0 || contUtilitario > 0 || contCamion > 0)
                    {
                        Console.WriteLine($"El precio total a pagar de estacionamieto por tener la moto como vechículo es de {precioTotalMoto}$ (100$ la hora)");
                        Console.WriteLine($"El precio total a pagar de estacionamiento por tener el auto como vehículo es de {precioTotalAuto}$ (200$ la hora)");
                        Console.WriteLine($"El precio total a pagar de estacionamiento por tener un utilitario como vehículo es de {precioTotalUtilitario}$ (250$ la hora)");
                        Console.WriteLine($"El precio total a pagar de estacionamiento por tener un camión como vehículo es de {precioTotalCamion}$ (700$ la hora)");
                    }

                }

                else
                {
                    

                    
                    continuar = false;
                }

            }
            while (continuar == true);

            double porcMoto, porcAuto, porcUtilitario, porcCamion;
            porcMoto = (double)acContMoto / contZona * 100;
            porcAuto = (double)acContAuto / contZona * 100;
            porcUtilitario = (double)acContUtilitario / contZona * 100;
            porcCamion = (double)acContCamion / contZona * 100;

            Console.WriteLine("Informe de estacionamiento por parte de la empresa:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Recaudación total: {acRecaudacionTotal}$");
            Console.WriteLine($"En total, se registraron {contZona}, porcentaje de cantidades de vehículo de cada tipo:");
            Console.WriteLine($"Porcentaje de motos estacionadas: {porcMoto}%");
            Console.WriteLine($"Porcentaje de autos estacionados: {porcAuto}%");
            Console.WriteLine($"Porcentaje de utilitarios estacionados: {porcUtilitario}%");
            Console.WriteLine($"Porcentaje de camiones estacionados: {porcCamion}%");
            Console.WriteLine("<3");

        }
    }
}
