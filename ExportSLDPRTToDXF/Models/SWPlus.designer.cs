﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExportSLDPRTToDXF.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SWPlusDB")]
	public partial class SWPlusDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public SWPlusDataContext() : 
				base(global::ExportSLDPRTToDXF.Properties.Settings.Default.SWPlusDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SWPlusDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SWPlusDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SWPlusDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SWPlusDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Part> View_Parts
		{
			get
			{
				return this.GetTable<View_Part>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DXF_GET")]
		public int DXF_GET([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDPDM", DbType="Int")] System.Nullable<int> iDPDM, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ConfigName", DbType="NVarChar(255)")] string configName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Vertion", DbType="Int")] System.Nullable<int> vertion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DXF", DbType="VarBinary(MAX)")] ref System.Data.Linq.Binary dXF)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDPDM, configName, vertion, dXF);
			dXF = ((System.Data.Linq.Binary)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DXFCheck")]
		public int DXFCheck([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDPDM", DbType="Int")] System.Nullable<int> iDPDM, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Configuration", DbType="NVarChar(255)")] string configuration, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Version", DbType="Int")] System.Nullable<int> version)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDPDM, configuration, version);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DXFUpDateCutList")]
		public int DXFUpDateCutList([global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkpieceX", DbType="Decimal(10,2)")] System.Nullable<decimal> workpieceX, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkpieceY", DbType="Decimal(10,2)")] System.Nullable<decimal> workpieceY, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bend", DbType="Int")] System.Nullable<int> bend, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thickness", DbType="Decimal(10,2)")] System.Nullable<decimal> thickness, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Configuration", DbType="NVarChar(255)")] string configuration, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Version", DbType="Int")] System.Nullable<int> version, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PaintX", DbType="Int")] System.Nullable<int> paintX, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PaintY", DbType="Int")] System.Nullable<int> paintY, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PaintZ", DbType="Int")] System.Nullable<int> paintZ, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDPDM", DbType="Int")] System.Nullable<int> iDPDM, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaterialID", DbType="Int")] System.Nullable<int> materialID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SurfaceArea", DbType="Decimal(10,3)")] System.Nullable<decimal> surfaceArea, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DXF", DbType="VarBinary(MAX)")] System.Data.Linq.Binary dXF)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), workpieceX, workpieceY, bend, thickness, configuration, version, paintX, paintY, paintZ, iDPDM, materialID, surfaceArea, dXF);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DXFDelete")]
		public int DXFDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDPDM", DbType="Int")] System.Nullable<int> iDPDM, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Configuration", DbType="NVarChar(255)")] string configuration, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Version", DbType="Int")] System.Nullable<int> version)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDPDM, configuration, version);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Parts")]
	public partial class View_Part
	{
		
		private int _Bend;
		
		private int _PaintX;
		
		private int _PaintY;
		
		private int _PaintZ;
		
		private decimal _SurfaceArea;
		
		private decimal _Thickness;
		
		private int _Version;
		
		private decimal _WorkpieceX;
		
		private decimal _WorkpieceY;
		
		private System.Nullable<int> _IDPDM;
		
		private string _ConfigurationName;
		
		private string _DXF;
		
		public View_Part()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bend", DbType="Int NOT NULL")]
		public int Bend
		{
			get
			{
				return this._Bend;
			}
			set
			{
				if ((this._Bend != value))
				{
					this._Bend = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintX", DbType="Int NOT NULL")]
		public int PaintX
		{
			get
			{
				return this._PaintX;
			}
			set
			{
				if ((this._PaintX != value))
				{
					this._PaintX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintY", DbType="Int NOT NULL")]
		public int PaintY
		{
			get
			{
				return this._PaintY;
			}
			set
			{
				if ((this._PaintY != value))
				{
					this._PaintY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintZ", DbType="Int NOT NULL")]
		public int PaintZ
		{
			get
			{
				return this._PaintZ;
			}
			set
			{
				if ((this._PaintZ != value))
				{
					this._PaintZ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurfaceArea", DbType="Decimal(10,3) NOT NULL")]
		public decimal SurfaceArea
		{
			get
			{
				return this._SurfaceArea;
			}
			set
			{
				if ((this._SurfaceArea != value))
				{
					this._SurfaceArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thickness", DbType="Decimal(10,2) NOT NULL")]
		public decimal Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				if ((this._Thickness != value))
				{
					this._Thickness = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Version", DbType="Int NOT NULL")]
		public int Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this._Version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkpieceX", DbType="Decimal(10,2) NOT NULL")]
		public decimal WorkpieceX
		{
			get
			{
				return this._WorkpieceX;
			}
			set
			{
				if ((this._WorkpieceX != value))
				{
					this._WorkpieceX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkpieceY", DbType="Decimal(10,2) NOT NULL")]
		public decimal WorkpieceY
		{
			get
			{
				return this._WorkpieceY;
			}
			set
			{
				if ((this._WorkpieceY != value))
				{
					this._WorkpieceY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPDM", DbType="Int")]
		public System.Nullable<int> IDPDM
		{
			get
			{
				return this._IDPDM;
			}
			set
			{
				if ((this._IDPDM != value))
				{
					this._IDPDM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfigurationName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string ConfigurationName
		{
			get
			{
				return this._ConfigurationName;
			}
			set
			{
				if ((this._ConfigurationName != value))
				{
					this._ConfigurationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DXF", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string DXF
		{
			get
			{
				return this._DXF;
			}
			set
			{
				if ((this._DXF != value))
				{
					this._DXF = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
