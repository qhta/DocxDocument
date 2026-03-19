using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CDB05-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface _CustomXMLPart: _IMsoDispObj
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [DispId(1610809344)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809345)]
  CustomXMLNode DocumentElement
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809346)]
  string Id
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809346)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809347)]
  string NamespaceURI
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809347)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809348)]
  CustomXMLSchemaCollection SchemaCollection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Interface)]
    set;
  }

  [DispId(1610809350)]
  CustomXMLPrefixMappings NamespaceManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809350)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809351)]
  string XML
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809351)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809352)]
  void AddNode
  ([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode Parent,
    [In] [MarshalAs(UnmanagedType.BStr)] string Name = "",
    [In] [MarshalAs(UnmanagedType.BStr)] string NamespaceURI = "",
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode NextSibling = null,
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [In] [MarshalAs(UnmanagedType.BStr)] string NodeValue = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809353)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809354)]
  bool Load([In] [MarshalAs(UnmanagedType.BStr)] string FilePath);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809355)]
  bool LoadXML([In] [MarshalAs(UnmanagedType.BStr)] string XML);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809356)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNodes SelectNodes([In] [MarshalAs(UnmanagedType.BStr)] string XPath);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809357)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNode SelectSingleNode([In] [MarshalAs(UnmanagedType.BStr)] string XPath);

  [DispId(1610809358)]
  CustomXMLValidationErrors Errors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809358)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809359)]
  bool BuiltIn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    get;
  }
}