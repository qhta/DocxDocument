using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4112)]
[Guid("000CDB07-0000-0000-C000-000000000046")]
[InterfaceType(2)]
public interface _CustomXMLPartEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void NodeAfterInsert([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode NewNode, [In] bool InUndoRedo);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void NodeAfterDelete
  ([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode,
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldParentNode,
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNextSibling, [In] bool InUndoRedo);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void NodeAfterReplace
  ([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode,
    [In] [MarshalAs(UnmanagedType.Interface)] CustomXMLNode NewNode, [In] bool InUndoRedo);
}