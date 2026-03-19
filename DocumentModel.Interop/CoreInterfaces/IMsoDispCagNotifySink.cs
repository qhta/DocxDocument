using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C0359-0000-0000-C000-000000000046")]
public interface IMsoDispCagNotifySink
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void InsertClip
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object pClipMoniker,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object pItemMoniker);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void WindowIsClosing();
}