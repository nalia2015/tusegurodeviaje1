﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TuSegurodeViaje.AccesoDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TuSegurodeViaje")]
	public partial class DatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DatosDataContext() : 
				base(global::TuSegurodeViaje.AccesoDatos.Properties.Settings.Default.TuSegurodeViajeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
       // [global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spBusquedaAvanzadadeTarifas")]
       //// [Function(Name = ("dbo.spBusquedaAvanzadadeTarifas"))]
       // public ISingleResult<Cotizacion> BusquedaCotizacion ([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOrigen", DbType="Int")] System.Nullable<int> iDOrigen, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDDestino", DbType="Int")] System.Nullable<int> iDDestino, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaDesde", DbType="DateTime")] System.Nullable<System.DateTime> fechaDesde, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaHasta", DbType="DateTime")] System.Nullable<System.DateTime> fechaHasta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad1", DbType="Int")] System.Nullable<int> edad1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad2", DbType="Int")] System.Nullable<int> edad2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad3", DbType="Int")] System.Nullable<int> edad3, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad4", DbType="Int")] System.Nullable<int> edad4, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad5", DbType="Int")] System.Nullable<int> edad5, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad6", DbType="Int")] System.Nullable<int> edad6, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email)
       // {
       //     //this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDOrigen, iDDestino, fechaDesde, fechaHasta, edad1, edad2, edad3, edad4, edad5, edad6, email);
       //     IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDOrigen, iDDestino, fechaDesde, fechaHasta, edad1, edad2, edad3, edad4, edad5, edad6, email);
       //     return ((ISingleResult<Cotizacion>)(result.ReturnValue));
       //  }
	}
}
#pragma warning restore 1591