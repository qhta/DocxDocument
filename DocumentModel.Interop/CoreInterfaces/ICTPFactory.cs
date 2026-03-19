using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C033D-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface ICTPFactory
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomTaskPane CreateCTP
  ([In] [MarshalAs(UnmanagedType.BStr)] string CTPAxID, [In] [MarshalAs(UnmanagedType.BStr)] string CTPTitle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CTPParentWindow);
}