using SistemaNomina.MyApp;

namespace SistemaNomina.AMyApppp
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComisión
    {


        private decimal salarioBase { get; set; }


        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision)
        {
            this.salarioBase = salarioBase;
        }


        public override decimal CalcularPago()
        {
            return base.CalcularPago() + salarioBase + (salarioBase * (decimal)0.10);
        }

        public override string ToString()
        {
            return $"Salario + {base.ToString()}\n" +
                $"Salario: {salarioBase:F2}";
        }

        public void ModificarDatos(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
        {
            base.ModificarDatos(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision);
            this.salarioBase = salarioBase;
        }



    }
}
