using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C1712-0000-0000-C000-000000000046")]
public interface Axes
{
  [DispId(1610743808)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    get;
  }

  [DispId(1610743809)]
  IMsoAxis Item
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743810)]
  object _NewEnum
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    get;
  }

  [DispId(148)]
  object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(149)]
  int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [IndexerName("_Default")]
  [DispId(0)]
  IMsoAxis this[[In] XlAxisType Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [TypeLibFunc(1024)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }
}