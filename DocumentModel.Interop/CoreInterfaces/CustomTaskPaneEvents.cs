using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("8A64A872-FC6B-4D4A-926E-3A3689562C1C")]
public interface CustomTaskPaneEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void VisibleStateChange([In] [MarshalAs(UnmanagedType.Interface)] CustomTaskPane CustomTaskPaneInst);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void DockPositionStateChange([In] [MarshalAs(UnmanagedType.Interface)] CustomTaskPane CustomTaskPaneInst);
}