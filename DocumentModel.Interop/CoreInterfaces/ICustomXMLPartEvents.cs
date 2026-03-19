using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CDB06-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface ICustomXMLPartEvents
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