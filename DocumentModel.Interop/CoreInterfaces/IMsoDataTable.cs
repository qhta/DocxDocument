using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C1711-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface IMsoDataTable
{
  [DispId(1610743808)]
  bool ShowLegendKey
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [param: In]
    set;
  }

  [DispId(1610743810)]
  bool HasBorderHorizontal
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    [param: In]
    set;
  }

  [DispId(1610743812)]
  bool HasBorderVertical
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    [param: In]
    set;
  }

  [DispId(1610743814)]
  bool HasBorderOutline
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743814)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743814)]
    [param: In]
    set;
  }

  [DispId(1610743816)]
  IMsoBorder Border
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743817)]
  ChartFont Font
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743817)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743818)]
  void Select();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743819)]
  void Delete();

  [DispId(1610743820)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743821)]
  object AutoScaleFont
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743821)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743821)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743823)]
  IMsoChartFormat Format
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743823)]
    [return: MarshalAs(UnmanagedType.Interface)]
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
}