using System;

namespace SistemaNomina.MyApp
{
    public abstract class Empleado
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        public string PrimerNombre
        {
            get => primerNombre;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                primerNombre = value;
            }
        }

        public string ApellidoPaterno
        {
            get => apellidoPaterno;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío.");
                apellidoPaterno = value;
            }
        }

        public string NumeroSeguroSocial
        {
            get => numeroSeguroSocial;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de seguro social no puede estar vacío.");
                numeroSeguroSocial = value;
            }
        }

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
