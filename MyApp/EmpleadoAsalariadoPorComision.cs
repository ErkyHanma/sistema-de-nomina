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
            return $"Empleado por Comisiones\n{base.ToString()}\n" +
                $"Salario: {salarioBase}\n";
        }

    }
}
