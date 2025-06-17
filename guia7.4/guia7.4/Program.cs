using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalEncuestas = 0;
            int totalBici = 0, totalMoto = 0, totalAuto = 0, totalTran = 0;
            int totalAcBici = 0, totalAcMoto = 0;

            for (int i = 0; i < 2; i++)

            {
                bool continuar = true;
                int contBiciPersona = 0, contMotoPersona = 0, contAutoPersona = 0, contTranPersona = 0;
                string rta1, rta2;
                int distanciaAprox = 0;
                int contBici = 0, contMoto = 0, contAuto = 0, contTran = 0;
                int encuestas = 0;
                double promedioBici = 0, promedioMoto = 0;
                int acBici = 0, acMoto = 0;

                do
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("1. Tipo de transporte que considera más frecuente }");
                    Console.WriteLine("a. Bicicleta                                      }");
                    Console.WriteLine("b. Motocicleta                                    }");
                    Console.WriteLine("c. Automóvil                                      }");
                    Console.WriteLine("d. Transporte Público                             }");
                    Console.WriteLine("--------------------------------------------------");
                    rta1 = Console.ReadLine();

                    switch (rta1)
                    {
                        case "a":
                            contBici++;
                            contBiciPersona++;
                            break;
                        case "b":
                            contMoto++;
                            contMotoPersona++;
                            break;
                        case "c":
                            contAuto++;
                            contAutoPersona++;
                            break;
                        case "d":
                            contTran++;
                            contTranPersona++;
                            break;
                        default:
                            Console.WriteLine("Porfavor selecciona una opción válida dentro de la encuesta");
                            break;


                    }

                    Console.WriteLine("2. Cuál es la distancia aproximada en la que utiliza el vehículo seleccionado? (km)");
                    distanciaAprox = Convert.ToInt32(Console.ReadLine());
                    encuestas++;
                    switch (rta1)
                    {
                        case "a":
                            acBici += distanciaAprox;
                            break;
                        case "b":
                            acMoto += distanciaAprox;
                            break;
                        default:
                            break;
                    }

                    if (contBici > 0)
                    {
                        promedioBici = acBici / contBici;
                    }
                    if (contMoto > 0)
                    {
                        promedioMoto = acMoto / contMoto;
                    }

                    Console.WriteLine("Desea agregar datos de otra encuesta? s/n");
                    rta2 = Console.ReadLine();
                    if (rta2 == "n")
                    {
                        Console.WriteLine("Informe del encuestador " + (i + 1));
                        Console.WriteLine($"La cantidad de personas encuestadas fueron: {encuestas}");
                        Console.WriteLine($"Un total de {contBici} personas se manejan mediante bicicleta");
                        Console.WriteLine($"Un total de {contMoto} personas se manejan mediante motocicleta");
                        Console.WriteLine($"Un total de {contAuto} perosnas se manejan mediante auto");
                        Console.WriteLine($"Un total de {contTran} personas se manejan mediante transporte público");
                        Console.WriteLine($"Promedio distancia recorrida en bicicleta: {promedioBici}km");
                        Console.WriteLine($"Promedio distancia recorrida en motocicleta: {promedioMoto}km");

                        continuar = false;
                    }

                }
                while (continuar == true);

                totalEncuestas += encuestas;
                totalBici += contBici;
                totalAuto += contAuto;
                totalTran += contTran;
                totalAcBici += acBici;

            }

            double porcBici = 0, porcAuto = 0, porcTran = 0;
            porcBici = (totalBici * 100) / totalEncuestas;
            porcAuto = (totalAuto * 100) / totalEncuestas;
            porcTran = (totalTran * 100) / totalEncuestas;

            Console.WriteLine("----------------------Informe final por parte de la empresa--------------------------");
            Console.WriteLine($"Cantidad de personas encuestadas: {totalEncuestas}                                  ");
            Console.WriteLine($"Porcentaje total de personas que frecuentemente usan bicicleta: {porcBici}%         ");
            Console.WriteLine($"Porcentaje total de personas que frecuentemente usan autos; {porcAuto}%             ");
            Console.WriteLine($"Porcentaje total de personas que frecuentemente usan transporte público: {porcTran}%");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("Ej 2");
            Ej2 ej2 = new Ej2();
            ej2.Ejecutar();


        }
    }
}
