namespace SistemaNomina.MyApp
{
    public abstract class Empleado
    {
        public string PrimerNombre { get; protected set; }
        public string ApellidoPaterno { get; protected set; }
        public string NumeroSeguroSocial { get; protected set; }

        public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            this.PrimerNombre = primerNombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.NumeroSeguroSocial = numeroSeguroSocial;
        }


        public override string ToString()
        {
            return $"Nombre: {PrimerNombre} {ApellidoPaterno}\nSeguro Social: {NumeroSeguroSocial}";
        }

        public abstract decimal CalcularPago();



    }
}





