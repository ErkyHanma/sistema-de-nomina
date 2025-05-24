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
                Console.WriteLine("4.Salir\n");


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
                            Console.Clear();
                            ModificarEmpleado(empleados);
                            Continuar();
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

        static void MostrarEmpleadoCreado(string primerNombre, string apellidoPaterno)
        {
            Console.WriteLine($"\nEmpleado {primerNombre} {apellidoPaterno} añadido correctamente");
        }

        static void MostrarEmpleadoModificado(string primerNombre, string apellidoPaterno)
        {
            Console.WriteLine($"\nEmpleado {primerNombre} {apellidoPaterno} modificado correctamente");
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
                        try
                        {
                            Console.Write("Nombre: ");
                            primerNombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellidoPaterno = Console.ReadLine();
                            Console.Write("Seguro Social: ");
                            numeroSeguroSocial = Console.ReadLine();
                            Console.Write("Salario: ");
                            salario = decimal.Parse(Console.ReadLine());
                            empleados.Add(new EmpleadoAsalariado(primerNombre, apellidoPaterno, numeroSeguroSocial, salario));
                            MostrarEmpleadoCreado(primerNombre, apellidoPaterno);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inesperado: " + ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Nombre: ");
                            primerNombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellidoPaterno = Console.ReadLine();
                            Console.Write("Seguro Social: ");
                            numeroSeguroSocial = Console.ReadLine();
                            Console.Write("Sueldo por hora: ");
                            sueldoPorHora = decimal.Parse(Console.ReadLine());
                            Console.Write("Horas Trabajadas: ");
                            horasTrabajadas = int.Parse(Console.ReadLine());
                            empleados.Add(new EmpleadoPorHoras(primerNombre, apellidoPaterno, numeroSeguroSocial, horasTrabajadas, sueldoPorHora));
                            Console.WriteLine("Empleado Agregado con exito");
                            MostrarEmpleadoCreado(primerNombre, apellidoPaterno);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inesperado: " + ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.Write("Nombre: ");
                            primerNombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellidoPaterno = Console.ReadLine();
                            Console.Write("Seguro Social: ");
                            numeroSeguroSocial = Console.ReadLine();
                            Console.Write("Ventas bruta: ");
                            ventasBrutas = decimal.Parse(Console.ReadLine());
                            Console.Write("Tarifa de Comision: ");
                            tarifaComision = decimal.Parse(Console.ReadLine());
                            empleados.Add(new EmpleadoPorComisión(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision));
                            Console.WriteLine("Empleado Agregado con exito");
                            MostrarEmpleadoCreado(primerNombre, apellidoPaterno);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inesperado: " + ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Nombre: ");
                            primerNombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellidoPaterno = Console.ReadLine();
                            Console.Write("Seguro Social: ");
                            numeroSeguroSocial = Console.ReadLine();
                            Console.Write("Salario: ");
                            salario = decimal.Parse(Console.ReadLine());
                            Console.Write("Ventas bruta: ");
                            ventasBrutas = decimal.Parse(Console.ReadLine());
                            Console.Write("Tarifa de Comision: ");
                            tarifaComision = decimal.Parse(Console.ReadLine());
                            empleados.Add(new EmpleadoAsalariadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salario));
                            Console.WriteLine("Empleado Agregado con exito");
                            MostrarEmpleadoCreado(primerNombre, apellidoPaterno);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inesperado: " + ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Opcion no valida");
            }
        }

        static void ModificarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Seleccione el numero del empleado que desea modificar");
            Console.WriteLine("Lista de Empleados:\n");
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{empleados[i]}\n");
            }


            bool answer = int.TryParse(Console.ReadLine(), out int result);
            Console.Clear();

            string primerNombre;
            string apellidoPaterno;
            string numeroSeguroSocial;
            decimal salario;
            decimal sueldoPorHora;
            int horasTrabajadas;
            decimal ventasBrutas;
            decimal tarifaComision;

            if (answer)
            {
                if (result > 0 && result < empleados.Count)
                {
                    switch (empleados[result - 1])
                    {
                        case EmpleadoAsalariado empleadoAsalariado:
                            try
                            {
                                Console.Write("Nombre: ");
                                primerNombre = Console.ReadLine();
                                Console.Write("Apellido: ");
                                apellidoPaterno = Console.ReadLine();
                                Console.Write("Seguro Social: ");
                                numeroSeguroSocial = Console.ReadLine();
                                Console.Write("Salario: ");
                                salario = decimal.Parse(Console.ReadLine());
                                empleadoAsalariado.ModificarDatos(primerNombre, apellidoPaterno, numeroSeguroSocial, salario);
                                MostrarEmpleadoModificado(primerNombre, apellidoPaterno);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error inesperado: " + ex.Message);
                            }
                            break;

                        case EmpleadoAsalariadoPorComision empleadoAsalariadoPorComision:
                            try
                            {
                                Console.Write("Nombre: ");
                                primerNombre = Console.ReadLine();
                                Console.Write("Apellido: ");
                                apellidoPaterno = Console.ReadLine();
                                Console.Write("Seguro Social: ");
                                numeroSeguroSocial = Console.ReadLine();
                                Console.Write("Salario: ");
                                salario = decimal.Parse(Console.ReadLine());
                                Console.Write("Ventas bruta: ");
                                ventasBrutas = decimal.Parse(Console.ReadLine());
                                Console.Write("Tarifa de Comision: ");
                                tarifaComision = decimal.Parse(Console.ReadLine());
                                empleadoAsalariadoPorComision.ModificarDatos(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salario);
                                MostrarEmpleadoModificado(primerNombre, apellidoPaterno);

                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error inesperado: " + ex.Message);
                            }
                            break;

                        case EmpleadoPorComisión empleadoPorComision:
                            try
                            {
                                Console.Write("Nombre: ");
                                primerNombre = Console.ReadLine();
                                Console.Write("Apellido: ");
                                apellidoPaterno = Console.ReadLine();
                                Console.Write("Seguro Social: ");
                                numeroSeguroSocial = Console.ReadLine();
                                Console.Write("Ventas bruta: ");
                                ventasBrutas = decimal.Parse(Console.ReadLine());
                                Console.Write("Tarifa de Comision: ");
                                tarifaComision = decimal.Parse(Console.ReadLine());
                                empleadoPorComision.ModificarDatos(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision);
                                MostrarEmpleadoModificado(primerNombre, apellidoPaterno);

                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error inesperado: " + ex.Message);
                            }
                            break;

                        case EmpleadoPorHoras empleadoPorHoras:
                            try
                            {
                                Console.Write("Nombre: ");
                                primerNombre = Console.ReadLine();
                                Console.Write("Apellido: ");
                                apellidoPaterno = Console.ReadLine();
                                Console.Write("Seguro Social: ");
                                numeroSeguroSocial = Console.ReadLine();
                                Console.Write("Sueldo por hora: ");
                                sueldoPorHora = decimal.Parse(Console.ReadLine());
                                Console.Write("Horas Trabajadas: ");
                                horasTrabajadas = int.Parse(Console.ReadLine());
                                empleadoPorHoras.ModificarDatos(primerNombre, apellidoPaterno, numeroSeguroSocial, horasTrabajadas, sueldoPorHora);
                                MostrarEmpleadoModificado(primerNombre, apellidoPaterno);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error inesperado: " + ex.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Numero de empleado no disponible");
                }

            }
            else
            {
                Console.WriteLine("Error: Opcion no valida");
            }
        }
    }
}
