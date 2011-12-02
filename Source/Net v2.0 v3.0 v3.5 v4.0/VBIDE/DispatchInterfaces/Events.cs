//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface Events SupportByLibraryAttribute VBIDE, 5.3,12
	///</summary>
	[SupportByLibraryAttribute("VBIDE", 5.3,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Events : COMObject
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
                    _type = typeof(Events);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		/// <param name="VBProject">NetOffice.VBIDEApi.VBProject VBProject</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.ReferencesEvents get_ReferencesEvents(NetOffice.VBIDEApi.VBProject vBProject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBProject);
			object returnItem = Invoker.PropertyGet(this, "ReferencesEvents", paramsArray);
			NetOffice.VBIDEApi.ReferencesEvents newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.ReferencesEvents.LateBindingApiWrapperType) as NetOffice.VBIDEApi.ReferencesEvents;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		/// <param name="CommandBarControl">object CommandBarControl</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.CommandBarEvents get_CommandBarEvents(object commandBarControl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(commandBarControl);
			object returnItem = Invoker.PropertyGet(this, "CommandBarEvents", paramsArray);
			NetOffice.VBIDEApi.CommandBarEvents newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.CommandBarEvents.LateBindingApiWrapperType) as NetOffice.VBIDEApi.CommandBarEvents;
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}