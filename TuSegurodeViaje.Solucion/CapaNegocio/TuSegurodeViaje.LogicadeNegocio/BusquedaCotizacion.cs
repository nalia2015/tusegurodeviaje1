using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuSegurodeViaje.AccesoDatos;

namespace TuSegurodeViaje.LogicadeNegocio
{
    public interface ICotizacion
    {
        #region Atributos

        long IdProducto
        {
            get;
            set;
        }

        long IdProveedor
        {
            get;
            set;
        }

        string NombreProd
        {
            get;
            set;
        }

        decimal TotalTarifaPorModulo
        {
            get;
            set;
        }

        decimal TotalTarifaPorDiaAdicional
        {
            get;
            set;
        }

        decimal TotalTarifa
        {
            get;
            set;
        }

        decimal PorcentajeExcento
        {
            get;
            set;
        }

        decimal PorcentajeGravado
        {
            get;
            set;
        }


        decimal TotalTarifaPorModuloExcenta
        {
            get;
            set;
        }


        decimal TotalTarifaPorModuloGravada
        {
            get;
            set;
        }


        decimal TotalTarifaPorDíaAdicionalExcenta
        {
            get;
            set;
        }


        decimal TotalTarifaPorDíaAdicionalGravada
        {
            get;
            set;
        }


        int Pasajero
        {
            get;
            set;
        }


        int Edad
        {
            get;
            set;
        }


        decimal PorcentajeDescuentoxGrupo
        {
            get;
            set;
        }


        decimal TotalDescuentoxGrupo
        {
            get;
            set;
        }


        decimal PorcentajeDescuentoPromocion
        {
            get;
            set;
        }


        decimal TotalDescuentoPromocion
        {
            get;
            set;
        }

        decimal TotalTarifaConDtoAplicados
        {
            get;
            set;
        }

        decimal TotalTarifaFinal
        {
            get;
            set;
        }

        #endregion Atributos

        #region Metodos

        List<BusquedaCotizacion> getCotizacion(int IDOrigen, int IDDestino, DateTime FechaDesde, DateTime FechaHasta, int Edad1, int Edad2, int Edad3, int Edad4, int Edad5, int Edad6, string email);

        #endregion Metodos


    }
    
    public abstract class BusquedaCotizacion : ICotizacion
    {

       #region  Atributos

       public long IdProducto
        {
            get;
            set;
        }

        public long IdProveedor
        {
            get;
            set;
        }

        public string NombreProd
        {
            get;
            set;
        }

        public decimal TotalTarifaPorModulo
        {
            get;
            set;
        }

        public decimal TotalTarifaPorDiaAdicional
        {
            get;
            set;
        }

        public decimal TotalTarifa
        {
            get;
            set;
        }

        public decimal PorcentajeExcento
        {
            get;
            set;
        }

        public decimal PorcentajeGravado
        {
            get;
            set;
        }


        public decimal TotalTarifaPorModuloExcenta
        {
            get;
            set;
        }


        public decimal TotalTarifaPorModuloGravada
        {
            get;
            set;
        }


        public decimal TotalTarifaPorDíaAdicionalExcenta
        {
            get;
            set;
        }


        public decimal TotalTarifaPorDíaAdicionalGravada
        {
            get;
            set;
        }


        public int Pasajero
        {
            get;
            set;
        }


        public int Edad
        {
            get;
            set;
        }


        public decimal PorcentajeDescuentoxGrupo
        {
            get;
            set;
        }


        public decimal TotalDescuentoxGrupo
        {
            get;
            set;
        }


        public decimal PorcentajeDescuentoPromocion
        {
            get;
            set;
        }


        public decimal TotalDescuentoPromocion
        {
            get;
            set;
        }

        public decimal TotalTarifaConDtoAplicados
        {
            get;
            set;
        }

        public decimal TotalTarifaFinal
        {
            get;
            set;
        }

        #endregion

        #region Metodos
        public abstract List<BusquedaCotizacion> getCotizacion(int IDOrigen, int IDDestino, DateTime FechaDesde, DateTime FechaHasta, int Edad1, int Edad2, int Edad3, int Edad4, int Edad5, int Edad6, string email);
        #endregion Metodos


    }
}
