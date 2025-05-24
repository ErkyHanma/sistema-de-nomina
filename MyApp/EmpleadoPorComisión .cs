using System;

namespace SistemaNomina.MyApp
{
    public class EmpleadoPorComisión : Empleado
    {
        private decimal ventasBrutas;
        private decimal tarifaComision;

        public decimal VentasBrutas
        {
            get { return ventasBrutas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las ventas brutas no pueden ser negativas.");
                ventasBrutas = value;
            }
        }

        public decimal TarifaComision
        {
            get { return tarifaComision; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La tarifa de comisión debe estar entre 0 y 1.");
                tarifaComision = value;
            }
        }

        public EmpleadoPorComisión(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
           : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;

        }


        public override decimal CalcularPago()
        {
            return ventasBrutas * tarifaComision;
        }

        public override string ToString()
        {
            return $"Empleado por Comisiones\n{base.ToString()}\n" +
                $"Total en Ventas Brutas: ${ventasBrutas:F2}\n" +
                $"Tarifa por comision: {tarifaComision}";

        }

        public void ModificarDatos(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }


    }
}


