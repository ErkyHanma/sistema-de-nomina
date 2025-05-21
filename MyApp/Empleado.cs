namespace SistemaNomina.MyApp
{
    public abstract class Empleado
    {
        private string primerNombre { get; set; }
        private string apellidoPaterno { get; set; }
        private string numeroSeguroSocial { get; set; }

        public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }


        public override string ToString()
        {
            return $"Nombre: {primerNombre} {apellidoPaterno}\nSeguro Social: {numeroSeguroSocial}";
        }

        public abstract decimal CalcularPago();


    }
}





