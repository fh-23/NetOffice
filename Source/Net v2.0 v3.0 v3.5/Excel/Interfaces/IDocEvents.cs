//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IDocEvents SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDocEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 SelectionChange(NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "SelectionChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 BeforeDoubleClick(NetOffice.ExcelApi.Range target, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(target, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeDoubleClick", paramsArray);
			cancel = (bool)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 BeforeRightClick(NetOffice.ExcelApi.Range target, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(target, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeRightClick", paramsArray);
			cancel = (bool)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Activate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Activate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Deactivate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Deactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Calculate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Calculate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Change(NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "Change", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Hyperlink Target</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 FollowHyperlink(NetOffice.ExcelApi.Hyperlink target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "FollowHyperlink", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public Int32 PivotTableUpdate(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableUpdate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="TargetRange">NetOffice.ExcelApi.Range TargetRange</param>
		[SupportByLibrary("XL14")]
		public Int32 PivotTableAfterValueChange(NetOffice.ExcelApi.PivotTable targetPivotTable, NetOffice.ExcelApi.Range targetRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, targetRange);
			object returnItem = Invoker.MethodReturn(this, "PivotTableAfterValueChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL14")]
		public Int32 PivotTableBeforeAllocateChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeAllocateChanges", paramsArray);
			cancel = (bool)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL14")]
		public Int32 PivotTableBeforeCommitChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeCommitChanges", paramsArray);
			cancel = (bool)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		[SupportByLibrary("XL14")]
		public Int32 PivotTableBeforeDiscardChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeDiscardChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("XL14")]
		public Int32 PivotTableChangeSync(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableChangeSync", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}