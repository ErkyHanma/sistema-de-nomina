namespace SistemaNomina.MyApp
{
    public class EmpleadoPorHoras : Empleado
    {
        private decimal sueldoPorHora { get; set; }
        private int horasTrabajadas { get; set; }


        public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, int horasTrabajadas, decimal sueldoPorHora)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.sueldoPorHora = sueldoPorHora;
            this.horasTrabajadas = horasTrabajadas;
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
            this.primerNombre = primerNombre;
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
            this.sueldoPorHora = sueldoPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }
    }
}


