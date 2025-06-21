using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int costoTelebingo = 400;
            const int costoQuini = 800;
            const int costoToto = 750;

            int mejorVendedor = -1;
            int totalVentasMejorVendedor = -1;

            int cantidadTelebingoTotal = 0,
                cantidadQuiniTotal = 0,
                cantidadTotoTotal = 0;

            int totalVentas = 0;

            int vendedor = 0;
            int opcion;
            do
            {
                Console.WriteLine("==========");
                Console.WriteLine("1. Ingresar ventas de un nuevo vendedor");
                Console.WriteLine("2. Finalizar día y ver informes");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    int opcionVendedor = 2;
                    vendedor++;

                    // estas tienen el total de las ventas de UN VENDEDOR
                    int totalVentasVendedor = 0,
                        totalTelebingoVendedor = 0,
                        totalQuiniVendedor = 0,
                        totalTotoVendedor = 0;

                    do
                    {
                        Console.WriteLine("----------");
                        Console.WriteLine("Vendedor " + vendedor);
                        Console.WriteLine("1. Procesar una venta");
                        Console.WriteLine("2. Finalizar ventas e informar");

                        opcionVendedor = Convert.ToInt32(Console.ReadLine());

                        int cantidadTelebingo = 0,
                            cantidadQuini = 0,
                            cantidadToto = 0;

                        if (opcionVendedor == 1)
                        {
                            // le pido todos los datos de la venta
                            // * tipo de cartón
                            // * cantidad de cartones
                            // * monto total
                            int tipoCarton;
                            do
                            {
                                Console.WriteLine("Elija el tipo de cartón a cargar: ");
                                Console.WriteLine("1. Cartón del Tele Bingo");
                                Console.WriteLine("2. Un cartón de Quini seis");
                                Console.WriteLine("3. Un cartón del Toto Bingo");
                                Console.WriteLine("4. Finalizar venta");
                                tipoCarton = Convert.ToInt32(Console.ReadLine());

                                int cantidad,
                                    totalVentaVendedor,
                                    totalVenta;

                                if (tipoCarton != 4)
                                {
                                    Console.WriteLine("Ingrese la cantidad: ");
                                    cantidad = Convert.ToInt32(Console.ReadLine());
                                    switch (tipoCarton)
                                    {
                                        case 1:
                                            cantidadTelebingo += cantidad;
                                            break;
                                        case 2:
                                            cantidadQuini += cantidad;
                                            break;
                                        case 3:
                                            cantidadToto += cantidad;
                                            break;
                                    }
                                }
                                else
                                {
                                    // cuando elegimos la opción 4 y terminamos esta venta
                                    Console.WriteLine("Ingrese el total de la venta: ");
                                    totalVentaVendedor = Convert.ToInt32(Console.ReadLine());
                                    totalVenta =
                                        cantidadTelebingo * costoTelebingo
                                        + cantidadQuini * costoQuini
                                        + cantidadToto * costoToto;

                                    if (totalVentaVendedor != totalVenta)
                                    {
                                        Console.WriteLine(
                                            "AVISO IMPORTANTE: El valor de la venta ingresada es incorrecto. El valor es $"
                                                + totalVenta
                                        );
                                    }

                                    totalVentasVendedor += totalVenta;
                                    totalTelebingoVendedor += cantidadTelebingo;
                                    totalQuiniVendedor += cantidadQuini;
                                    totalTotoVendedor += cantidadToto;
                                }
                            } while (tipoCarton != 4);
                        }
                    } while (opcionVendedor == 1);

                    // informar cosas de este vendedor solamente si se cargaron ventas (totalVentasVendedor != 0)
                    if (totalVentasVendedor != 0)
                    {
                        if (totalVentasMejorVendedor < totalVentasVendedor)
                        {
                            totalVentasMejorVendedor = totalVentasVendedor;
                            mejorVendedor = vendedor;
                        }

                        // acumulamos a las ventas globales
                        totalVentas += totalVentasVendedor;
                        cantidadTelebingoTotal += totalTelebingoVendedor;
                        cantidadQuiniTotal += totalQuiniVendedor;
                        cantidadTotoTotal += totalTotoVendedor;

                        Console.WriteLine("---------------");
                        Console.WriteLine(
                            "Recaudación total del vendedor #"
                                + vendedor
                                + ": $"
                                + totalVentasVendedor
                        );

                        Console.WriteLine("Cantidad TeleBingo: " + totalTelebingoVendedor);
                        Console.WriteLine(
                            "Total TeleBingo: " + totalTelebingoVendedor * costoTelebingo
                        );

                        Console.WriteLine("Cantidad Quini 6: " + totalQuiniVendedor);
                        Console.WriteLine("Total Quini 6: " + totalQuiniVendedor * costoQuini);

                        Console.WriteLine("Cantidad Toto: " + totalTotoVendedor);
                        Console.WriteLine("Total Toto: " + totalTotoVendedor * costoToto);
                    }
                }
            } while (opcion == 1);



            Console.WriteLine("===========");
            Console.WriteLine(
                "La recaudación total entre todos los vendedores fue: " + totalVentas
            );

            int montoTelebingo = cantidadTelebingoTotal * costoTelebingo;
            float porcentajeTelebingo = montoTelebingo * 100 / totalVentas;

            int montoQuini = cantidadQuiniTotal * costoQuini;
            float porcentajeQuini = montoQuini * 100 / totalVentas;

            int montoToto = cantidadTotoTotal * costoToto;
            float porcentajeToto = montoToto * 100 / totalVentas;

            Console.WriteLine(
                "El porcentaje de Telebingo fue "
                    + porcentajeTelebingo
                    + "% por un monto de $"
                    + montoTelebingo
            );
            Console.WriteLine(
                "El porcentaje de Quini 6 fue "
                    + porcentajeQuini
                    + "% por un monto de $"
                    + montoQuini
            );
            Console.WriteLine(
                "El porcentaje de Toto fue " + porcentajeToto + "% por un monto de $" + montoToto
            );

            Console.WriteLine(
                "El vendedor #"
                    + mejorVendedor
                    + " fue el mejor, con un total de $"
                    + totalVentasMejorVendedor
            );
        }
    }
}
