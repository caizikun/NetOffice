using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOTOOLBARSETS 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOTOOLBARSETS : COMObject ,IEnumerable<NetOffice.VisioApi.IVToolbarSet>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LPVISIOTOOLBARSETS);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOTOOLBARSETS(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOTOOLBARSETS(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOTOOLBARSETS(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOTOOLBARSETS() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOTOOLBARSETS(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="lIndex">Int32 lIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVToolbarSet this[Int32 lIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(lIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVToolbarSet newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVToolbarSet;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVToolbarSet get_ItemAtID(Int32 lID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(lID);
			object returnItem = Invoker.PropertyGet(this, "ItemAtID", paramsArray);
			NetOffice.VisioApi.IVToolbarSet newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVToolbarSet;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Alias for get_ItemAtID
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVToolbarSet ItemAtID(Int32 lID)
		{
			return get_ItemAtID(lID);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVUIObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.VisioApi.IVUIObject newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVUIObject;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVToolbarSet Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVToolbarSet newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVToolbarSet;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVToolbarSet AddAtID(Int32 lID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lID);
			object returnItem = Invoker.MethodReturn(this, "AddAtID", paramsArray);
			NetOffice.VisioApi.IVToolbarSet newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVToolbarSet;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVToolbarSet> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
       public IEnumerator<NetOffice.VisioApi.IVToolbarSet> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVToolbarSet item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}