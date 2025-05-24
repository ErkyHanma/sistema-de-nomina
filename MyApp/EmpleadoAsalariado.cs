using System;

namespace SistemaNomina.MyApp
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal;

        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario semanal no puede ser negativo.");
                salarioSemanal = value;
            }
        }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago()
        {
            return salarioSemanal;
        }

        public override string ToString()
        {
            return $"Empleado Asalariado\n{base.ToString()}\n" +
                $"Salario semanal: ${salarioSemanal:F2}";
        }

        public void ModificarDatos(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            SalarioSemanal = salarioSemanal;
        }
    }
}
