using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("6EA00553-9439-4D5A-B1E6-DC15A54DA8B2")]
[TypeLibType(4304)]
public interface IMsoDisplayUnitLabel: IMsoChartTitle
{
  [DispId(1610743808)]
  new string Caption
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610743810)]
  new IMsoCharacters Characters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743811)]
  new ChartFont Font
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743811)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743812)]
  new object HorizontalAlignment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743814)]
  new double Left
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
  new object Orientation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743818)]
  new bool Shadow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743818)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743818)]
    [param: In]
    set;
  }

  [DispId(1610743820)]
  new string Text
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610743822)]
  new double Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743822)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743822)]
    [param: In]
    set;
  }

  [DispId(1610743824)]
  new object VerticalAlignment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743824)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743824)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743826)]
  new int ReadingOrder
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743826)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743826)]
    [param: In]
    set;
  }

  [DispId(1610743828)]
  new object AutoScaleFont
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743830)]
  new IMsoInterior Interior
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743830)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743831)]
  new ChartFillFormat Fill
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743831)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743832)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object Delete();

  [DispId(1610743833)]
  new IMsoBorder Border
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743833)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743834)]
  new string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743834)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610743835)]
  new object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743835)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743836)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object Select();

  [DispId(2418)]
  new bool IncludeInLayout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2418)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2418)]
    [param: In]
    set;
  }

  [DispId(1671)]
  new XlChartElementPosition Position
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1671)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1671)]
    [param: In]
    set;
  }

  [DispId(1610743841)]
  new IMsoChartFormat Format
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743841)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743842)]
  new double Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743842)]
    get;
  }

  [DispId(148)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(149)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(1610743845)]
  new double Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743845)]
    get;
  }

  [DispId(1610743846)]
  new string Formula
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743846)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743846)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610743848)]
  new string FormulaR1C1
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743848)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743848)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610743850)]
  new string FormulaLocal
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743850)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743850)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610743852)]
  new string FormulaR1C1Local
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743852)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743852)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }
}