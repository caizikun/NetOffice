//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IDOMMouseWheelEvent SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IDOMMouseWheelEvent : COMObject
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
                    _type = typeof(IDOMMouseWheelEvent);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseWheelEvent(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseWheelEvent(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseWheelEvent(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseWheelEvent() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseWheelEvent(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 wheelDelta
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "wheelDelta", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="eventType">string eventType</param>
		/// <param name="canBubble">bool canBubble</param>
		/// <param name="cancelable">bool cancelable</param>
		/// <param name="viewArg">LateBindingApi.MSHTMLApi.IHTMLWindow2 viewArg</param>
		/// <param name="detailArg">Int32 detailArg</param>
		/// <param name="screenXArg">Int32 screenXArg</param>
		/// <param name="screenYArg">Int32 screenYArg</param>
		/// <param name="clientXArg">Int32 clientXArg</param>
		/// <param name="clientYArg">Int32 clientYArg</param>
		/// <param name="buttonArg">Int16 buttonArg</param>
		/// <param name="relatedTargetArg">LateBindingApi.MSHTMLApi.IEventTarget relatedTargetArg</param>
		/// <param name="modifiersListArg">string modifiersListArg</param>
		/// <param name="wheelDeltaArg">Int32 wheelDeltaArg</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void initMouseWheelEvent(string eventType, bool canBubble, bool cancelable, LateBindingApi.MSHTMLApi.IHTMLWindow2 viewArg, Int32 detailArg, Int32 screenXArg, Int32 screenYArg, Int32 clientXArg, Int32 clientYArg, Int16 buttonArg, LateBindingApi.MSHTMLApi.IEventTarget relatedTargetArg, string modifiersListArg, Int32 wheelDeltaArg)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, buttonArg, relatedTargetArg, modifiersListArg, wheelDeltaArg);
			Invoker.Method(this, "initMouseWheelEvent", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}