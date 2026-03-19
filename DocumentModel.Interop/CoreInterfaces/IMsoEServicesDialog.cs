using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C0372-0000-0000-C000-000000000046")]
public interface IMsoEServicesDialog
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743808)]
  void Close([In] bool ApplyWebComponentChanges = false);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743809)]
  void AddTrustedDomain([In] [MarshalAs(UnmanagedType.BStr)] string Domain);

  [DispId(1610743810)]
  string ApplicationName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610743811)]
  object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743811)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743812)]
  object WebComponent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743813)]
  object ClipArt
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743813)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }
}