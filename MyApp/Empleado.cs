namespace SistemaNomina.MyApp
{
    public abstract class Empleado
    {
        protected string primerNombre { get; set; }
        protected string apellidoPaterno { get; set; }
        protected string numeroSeguroSocial { get; set; }

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





