using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C033C-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[TypeLibType(4112)]
public interface _CustomTaskPaneEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void VisibleStateChange([In] [MarshalAs(UnmanagedType.Interface)] CustomTaskPane CustomTaskPaneInst);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void DockPositionStateChange([In] [MarshalAs(UnmanagedType.Interface)] CustomTaskPane CustomTaskPaneInst);
}