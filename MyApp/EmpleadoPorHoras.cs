using System;

namespace SistemaNomina.MyApp
{
    public class EmpleadoPorHoras : Empleado
    {
        private decimal sueldoPorHora;
        private int horasTrabajadas;


        public decimal SueldoPorHora
        {
            get { return sueldoPorHora; }
            set
            {
                if (value >= 0)
                    sueldoPorHora = value;
                else
                    throw new ArgumentException("El sueldo no puede ser negativo");
            }
        }

        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set
            {
                if (value >= 0)
                    horasTrabajadas = value;
                else
                    throw new ArgumentException("La hora no puede ser negativa");
            }
        }

        public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, int horasTrabajadas, decimal sueldoPorHora)
         : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }



        public override decimal CalcularPago()
        {
            if (horasTrabajadas >= 40)
            {
                return sueldoPorHora * horasTrabajadas;
            }
            else
            {
                return (sueldoPorHora * 40) + ((sueldoPorHora) * (decimal)1.5 * (horasTrabajadas - 40));
            }
        }

        public override string ToString()
        {
            return $"Empleado por Hora\n{base.ToString()}\n" +
                $"Sueldo por Hora: ${sueldoPorHora:F2}\n" +
                $"Total horas trabajadas: {horasTrabajadas}";

        }

        public void ModificarDatos(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, int horasTrabajadas, decimal sueldoPorHora)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }
    }
}


