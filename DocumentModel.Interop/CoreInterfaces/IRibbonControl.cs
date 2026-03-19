using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4160)]
[Guid("000C0395-0000-0000-C000-000000000046")]
public interface IRibbonControl
{
  [DispId(1)]
  string Id
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(2)]
  object Context
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(3)]
  string Tag
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }
}