using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C0936-0000-0000-C000-000000000046")]
public interface NewFile: _IMsoDispObj
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  bool Add
  ([In] [MarshalAs(UnmanagedType.BStr)] string FileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Section,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Action);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  bool Remove
  ([In] [MarshalAs(UnmanagedType.BStr)] string FileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Section,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Action);
}