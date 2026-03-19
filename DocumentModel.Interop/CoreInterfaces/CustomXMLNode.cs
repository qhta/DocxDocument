using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CDB04-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface CustomXMLNode: _IMsoDispObj
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
  CustomXMLNodes Attributes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809346)]
  string BaseName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809346)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809347)]
  CustomXMLNodes ChildNodes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809347)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809348)]
  CustomXMLNode FirstChild
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809349)]
  CustomXMLNode LastChild
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809349)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809350)]
  string NamespaceURI
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809350)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809351)]
  CustomXMLNode NextSibling
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809351)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809352)]
  MsoCustomXMLNodeType NodeType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809352)]
    get;
  }

  [DispId(1610809353)]
  string NodeValue
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809353)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809353)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610809355)]
  object OwnerDocument
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809355)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809356)]
  CustomXMLPart OwnerPart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809356)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809357)]
  CustomXMLNode PreviousSibling
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809357)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809358)]
  CustomXMLNode ParentNode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809358)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809359)]
  string Text
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610809361)]
  string XPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809361)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809362)]
  string XML
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809362)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809363)]
  void AppendChildNode
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name = "", [In] [MarshalAs(UnmanagedType.BStr)] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [In] [MarshalAs(UnmanagedType.BStr)] string NodeValue = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809364)]
  void AppendChildSubtree([In] [MarshalAs(UnmanagedType.BStr)] string XML);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809365)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809366)]
  bool HasChildNodes();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809367)]
  void InsertNodeBefore
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name = "", [In] [MarshalAs(UnmanagedType.BStr)] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [In] [MarshalAs(UnmanagedType.BStr)] string NodeValue = "",
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode NextSibling = null);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809368)]
  void InsertSubtreeBefore
  ([In] [MarshalAs(UnmanagedType.BStr)] string XML,
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode NextSibling = null);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809369)]
  void RemoveChild([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode Child);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809370)]
  void ReplaceChildNode
  ([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode,
    [In] [MarshalAs(UnmanagedType.BStr)] string Name = "",
    [In] [MarshalAs(UnmanagedType.BStr)] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [In] [MarshalAs(UnmanagedType.BStr)] string NodeValue = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809371)]
  void ReplaceChildSubtree
    ([In] [MarshalAs(UnmanagedType.BStr)] string XML, [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809372)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNodes SelectNodes([In] [MarshalAs(UnmanagedType.BStr)] string XPath);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809373)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNode SelectSingleNode([In] [MarshalAs(UnmanagedType.BStr)] string XPath);
}