namespace SistemaNomina.MyApp
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal { get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.salarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago()
        {
            return salarioSemanal;
        }

        public override string ToString()
        {
            return $"Empleado Asalariado\n{base.ToString()}\n" +
                $"Salario semanal : {salarioSemanal}\n";
        }

    }
}


