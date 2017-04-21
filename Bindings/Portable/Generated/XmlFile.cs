// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// XmlFile.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Resources
{
	/// <summary>
	/// XML document resource.
	/// </summary>
	public unsafe partial class XmlFile : Resource
	{
		unsafe partial void OnXmlFileCreated ();

		[Preserve]
		public XmlFile (IntPtr handle) : base (handle)
		{
			OnXmlFileCreated ();
		}

		[Preserve]
		protected XmlFile (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnXmlFileCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int XmlFile_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (XmlFile_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (XmlFile_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int XmlFile_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(XmlFile));
			return new StringHash (XmlFile_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(XmlFile));
			return Marshal.PtrToStringAnsi (XmlFile_GetTypeNameStatic ());
		}

		[Preserve]
		public XmlFile () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_XMLFile (IntPtr context);

		[Preserve]
		public XmlFile (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(XmlFile));
			handle = XmlFile_XMLFile ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnXmlFileCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void XmlFile_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(XmlFile));
			XmlFile_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_BeginLoad_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_BeginLoad_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_BeginLoad_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_BeginLoad_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_Save_File (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save resource with default indentation (one tab). Return true if successful.
		/// </summary>
		public override bool Save (File dest)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_Save_File (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_Save_MemoryBuffer (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save resource with default indentation (one tab). Return true if successful.
		/// </summary>
		public override bool Save (MemoryBuffer dest)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_Save_MemoryBuffer (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_Save0_File (IntPtr handle, IntPtr dest, string indentation);

		/// <summary>
		/// Save resource with user-defined indentation. Return true if successful.
		/// </summary>
		public bool Save (File dest, string indentation)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_Save0_File (handle, (object)dest == null ? IntPtr.Zero : dest.Handle, indentation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_Save0_MemoryBuffer (IntPtr handle, IntPtr dest, string indentation);

		/// <summary>
		/// Save resource with user-defined indentation. Return true if successful.
		/// </summary>
		public bool Save (MemoryBuffer dest, string indentation)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_Save0_MemoryBuffer (handle, (object)dest == null ? IntPtr.Zero : dest.Handle, indentation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool XmlFile_FromString (IntPtr handle, string source);

		/// <summary>
		/// Deserialize from a string. Return true if successful.
		/// </summary>
		public bool FromString (string source)
		{
			Runtime.ValidateRefCounted (this);
			return XmlFile_FromString (handle, source);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_CreateRoot (IntPtr handle, string name);

		/// <summary>
		/// Clear the document and create a root element.
		/// </summary>
		public XmlElement CreateRoot (string name)
		{
			Runtime.ValidateRefCounted (this);
			return new XmlElement (XmlFile_CreateRoot (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_GetOrCreateRoot (IntPtr handle, string name);

		/// <summary>
		/// Get the root element if it has matching name, otherwise create it and clear the document.
		/// </summary>
		public XmlElement GetOrCreateRoot (string name)
		{
			Runtime.ValidateRefCounted (this);
			return new XmlElement (XmlFile_GetOrCreateRoot (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_GetRoot (IntPtr handle, string name);

		/// <summary>
		/// Return the root element, with optionally specified name. Return null element if not found.
		/// </summary>
		public XmlElement GetRoot (string name)
		{
			Runtime.ValidateRefCounted (this);
			return new XmlElement (XmlFile_GetRoot (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr XmlFile_ToString (IntPtr handle, string indentation);

		/// <summary>
		/// Serialize the XML content to a string.
		/// </summary>
		public string ToDebugString (string indentation)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (XmlFile_ToString (handle, indentation));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void XmlFile_Patch (IntPtr handle, IntPtr patchFile);

		/// <summary>
		/// Patch the XMLFile with another XMLFile. Based on RFC 5261.
		/// </summary>
		public void Patch (Urho.Resources.XmlFile patchFile)
		{
			Runtime.ValidateRefCounted (this);
			XmlFile_Patch (handle, (object)patchFile == null ? IntPtr.Zero : patchFile.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void XmlFile_Patch1 (IntPtr handle, IntPtr patchElement);

		/// <summary>
		/// Patch the XMLFile with another XMLElement. Based on RFC 5261.
		/// </summary>
		public void Patch (XmlElement patchElement)
		{
			Runtime.ValidateRefCounted (this);
			XmlFile_Patch1 (handle, (object)patchElement == null ? IntPtr.Zero : patchElement.Handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}
	}
}
