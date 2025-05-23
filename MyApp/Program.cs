using SistemaNomina.AMyApppp;
using SistemaNomina.MyApp;
using System;
using System.Collections.Generic;

namespace Sistema_de_nonima
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new EmpleadoAsalariado("Julio", "Rodriguez", "0-1234-562", 4500));
            empleados.Add(new EmpleadoPorHoras("Albert", "Pujols", "0-1234-565", 35, 200));
            empleados.Add(new EmpleadoPorComisión("Manny", "Ramirez", "0-1234-512", 20000, (decimal)0.10));
            empleados.Add(new EmpleadoAsalariadoPorComision("Placido", "Polanco", "0-1234-987", 3000, (decimal)0.10, 5000));


            Boolean isTrue = true;

            while (isTrue)
            {
                Console.Clear();
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("Elige una Opcion:");
                Console.WriteLine("1.Generar Nomina:");
                Console.WriteLine("2.Añadir Empleado:");
                Console.WriteLine("3.Modificar Empleado");
                Console.WriteLine("4.Salir");
                Console.WriteLine();

                int result;
                bool answer = int.TryParse(Console.ReadLine(), out result);

                if (answer)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Clear();
                            foreach (Empleado empleado in empleados)
                            {
                                Console.WriteLine(empleado + "\nIngresos: $" + empleado.CalcularPago() + "\n");
                            }
                            Continuar();
                            break;
                        case 2:
                            Console.Clear();
                            AñadirEmpleado(empleados);
                            Continuar();
                            break;
                        case 3:
                            break;
                        case 4:
                            isTrue = false;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }






            }

        }

        static void Continuar()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarEmpleado(string primerNombre, string apellidoPaterno)
        {
            Console.WriteLine($"\nEmpleado {primerNombre} {apellidoPaterno} añadido correctamente");
        }

        static void AñadirEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Elige el tipo de Empleado");
            Console.WriteLine("1.Empleado Asalariado\n2.Empleado por Hora\n3.Empleado por Comision\n4.Salario + Empleado por Comision");

            bool answer = int.TryParse(Console.ReadLine(), out int result);

            if (answer)
            {


                string primerNombre;
                string apellidoPaterno;
                string numeroSeguroSocial;
                decimal salario;
                decimal sueldoPorHora;
                int horasTrabajadas;
                decimal ventasBrutas;
                decimal tarifaComision;


                switch (result)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        primerNombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        apellidoPaterno = Console.ReadLine();
                        Console.Write("Seguro Social: ");
                        numeroSeguroSocial = Console.ReadLine();
                        Console.Write("Salario: ");
                        salario = int.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoAsalariado(primerNombre, apellidoPaterno, numeroSeguroSocial, salario));
                        MostrarEmpleado(primerNombre, apellidoPaterno);
                        break;
                    case 2:
                        Console.Write("Nombre: ");
                        primerNombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        apellidoPaterno = Console.ReadLine();
                        Console.Write("Seguro Social: ");
                        numeroSeguroSocial = Console.ReadLine();
                        Console.Write("Sueldo por hora: ");
                        sueldoPorHora = int.Parse(Console.ReadLine());
                        Console.Write("Horas Trabajadas: ");
                        horasTrabajadas = int.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoPorHoras(primerNombre, apellidoPaterno, numeroSeguroSocial, horasTrabajadas, sueldoPorHora));
                        Console.WriteLine("Empleado Agregado con exito");
                        MostrarEmpleado(primerNombre, apellidoPaterno);
                        break;
                    case 3:
                        Console.Write("Nombre: ");
                        primerNombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        apellidoPaterno = Console.ReadLine();
                        Console.Write("Seguro Social: ");
                        numeroSeguroSocial = Console.ReadLine();
                        Console.Write("Ventas bruta: ");
                        ventasBrutas = int.Parse(Console.ReadLine());
                        Console.Write("Tarifa de Comision: ");
                        tarifaComision = int.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoPorComisión(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision));
                        Console.WriteLine("Empleado Agregado con exito");
                        MostrarEmpleado(primerNombre, apellidoPaterno);
                        break;
                    case 4:
                        Console.Write("Nombre: ");
                        primerNombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        apellidoPaterno = Console.ReadLine();
                        Console.Write("Seguro Social: ");
                        numeroSeguroSocial = Console.ReadLine();
                        Console.Write("Salario: ");
                        salario = int.Parse(Console.ReadLine());
                        Console.Write("Ventas bruta: ");
                        ventasBrutas = int.Parse(Console.ReadLine());
                        Console.Write("Tarifa de Comision: ");
                        tarifaComision = int.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoAsalariadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salario));
                        Console.WriteLine("Empleado Agregado con exito");
                        MostrarEmpleado(primerNombre, apellidoPaterno);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }



    }
}
