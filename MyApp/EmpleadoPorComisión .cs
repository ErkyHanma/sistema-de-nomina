namespace SistemaNomina.MyApp
{
    public class EmpleadoPorComisión : Empleado
    {
        private decimal ventasBrutas { get; set; }
        private decimal tarifaComision { get; set; }

        public EmpleadoPorComisión(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision = tarifaComision;

        }

        public override decimal CalcularPago()
        {
            return ventasBrutas * tarifaComision;
        }

        public override string ToString()
        {
            return $"Empleado Asalariado + Comisiones\n{base.ToString()}\n" +
                $"Total en Ventas Brutas: {ventasBrutas}\n" +
                $"Tarifa por comision: {tarifaComision}";

        }

    }
}


