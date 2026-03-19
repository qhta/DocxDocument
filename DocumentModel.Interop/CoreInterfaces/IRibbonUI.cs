using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4160)]
[Guid("000C03A7-0000-0000-C000-000000000046")]
public interface IRibbonUI
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void Invalidate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void InvalidateControl([In] [MarshalAs(UnmanagedType.BStr)] string ControlID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void InvalidateControlMso([In] [MarshalAs(UnmanagedType.BStr)] string ControlID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  void ActivateTab([In] [MarshalAs(UnmanagedType.BStr)] string ControlID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  void ActivateTabMso([In] [MarshalAs(UnmanagedType.BStr)] string ControlID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  void ActivateTabQ
    ([In] [MarshalAs(UnmanagedType.BStr)] string ControlID, [In] [MarshalAs(UnmanagedType.BStr)] string Namespace);
}