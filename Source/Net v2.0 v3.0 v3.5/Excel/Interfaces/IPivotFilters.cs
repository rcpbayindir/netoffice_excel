//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// Interface IPivotFilters SupportByLibrary XL12 XL14 
	///</summary>
	[SupportByLibrary("XL12","XL14")]
	public class IPivotFilters : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL12","XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public LateBindingApi.ExcelApi.PivotFilter this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			LateBindingApi.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.PivotFilter;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.PivotFilter get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="Type">LateBindingApi.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="DataField">optional object DataField</param>
		/// <param name="Value1">optional object Value1</param>
		/// <param name="Value2">optional object Value2</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Name">optional object Name</param>
		/// <param name="Description">optional object Description</param>
		/// <param name="MemberPropertyField">optional object MemberPropertyField</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.PivotFilter Add(LateBindingApi.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2, object order, object name, object description, object memberPropertyField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2, order, name, description, memberPropertyField);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="Type">LateBindingApi.ExcelApi.Enums.XlPivotFilterType Type</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.PivotFilter Add(LateBindingApi.ExcelApi.Enums.XlPivotFilterType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.PivotFilter;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL12","XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}