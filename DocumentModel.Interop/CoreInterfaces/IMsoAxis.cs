using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C1713-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface IMsoAxis
{
  [DispId(1610743808)]
  bool AxisBetweenCategories
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
  XlAxisGroup AxisGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    get;
  }

  [DispId(1610743811)]
  IMsoAxisTitle AxisTitle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743811)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743812)]
  object CategoryNames
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
  XlAxisCrosses Crosses
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
  double CrossesAt
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743818)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete();

  [DispId(1610743819)]
  bool HasMajorGridlines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743819)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743819)]
    [param: In]
    set;
  }

  [DispId(1610743821)]
  bool HasMinorGridlines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743821)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743821)]
    [param: In]
    set;
  }

  [DispId(1610743823)]
  bool HasTitle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743823)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743823)]
    [param: In]
    set;
  }

  [DispId(1610743825)]
  GridLines MajorGridlines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743825)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743826)]
  XlTickMark MajorTickMark
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
  double MajorUnit
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    [param: In]
    set;
  }

  [DispId(1610743830)]
  double LogBase
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743830)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743830)]
    [param: In]
    set;
  }

  [DispId(1610743832)]
  bool TickLabelSpacingIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743832)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743832)]
    [param: In]
    set;
  }

  [DispId(1610743834)]
  bool MajorUnitIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743834)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743834)]
    [param: In]
    set;
  }

  [DispId(1610743836)]
  double MaximumScale
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743836)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743836)]
    [param: In]
    set;
  }

  [DispId(1610743838)]
  bool MaximumScaleIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743838)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743838)]
    [param: In]
    set;
  }

  [DispId(1610743840)]
  double MinimumScale
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743840)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743840)]
    [param: In]
    set;
  }

  [DispId(1610743842)]
  bool MinimumScaleIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743842)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743842)]
    [param: In]
    set;
  }

  [DispId(1610743844)]
  GridLines MinorGridlines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743844)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743845)]
  XlTickMark MinorTickMark
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743845)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743845)]
    [param: In]
    set;
  }

  [DispId(1610743847)]
  double MinorUnit
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743847)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743847)]
    [param: In]
    set;
  }

  [DispId(1610743849)]
  bool MinorUnitIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743849)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743849)]
    [param: In]
    set;
  }

  [DispId(1610743851)]
  bool ReversePlotOrder
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743851)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743851)]
    [param: In]
    set;
  }

  [DispId(1610743853)]
  XlScaleType ScaleType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743853)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743853)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743855)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select();

  [DispId(1610743856)]
  XlTickLabelPosition TickLabelPosition
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743856)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743856)]
    [param: In]
    set;
  }

  [DispId(1610743858)]
  IMsoTickLabels TickLabels
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743858)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743859)]
  int TickLabelSpacing
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743859)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743859)]
    [param: In]
    set;
  }

  [DispId(1610743861)]
  int TickMarkSpacing
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743861)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743861)]
    [param: In]
    set;
  }

  [DispId(1610743863)]
  XlAxisType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743863)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743863)]
    [param: In]
    set;
  }

  [DispId(1610743865)]
  XlTimeUnit BaseUnit
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743865)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743865)]
    [param: In]
    set;
  }

  [DispId(1610743867)]
  bool BaseUnitIsAuto
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743867)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743867)]
    [param: In]
    set;
  }

  [DispId(1610743869)]
  XlTimeUnit MajorUnitScale
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743869)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743869)]
    [param: In]
    set;
  }

  [DispId(1610743871)]
  XlTimeUnit MinorUnitScale
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743871)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743871)]
    [param: In]
    set;
  }

  [DispId(1610743873)]
  XlCategoryType CategoryType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743873)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743873)]
    [param: In]
    set;
  }

  [DispId(1610743875)]
  double Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743875)]
    get;
  }

  [DispId(1610743876)]
  double Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743876)]
    get;
  }

  [DispId(1610743877)]
  double Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743877)]
    get;
  }

  [DispId(1610743878)]
  double Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743878)]
    get;
  }

  [DispId(1610743879)]
  XlDisplayUnit DisplayUnit
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743879)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743879)]
    [param: In]
    set;
  }

  [DispId(1610743881)]
  double DisplayUnitCustom
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743881)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743881)]
    [param: In]
    set;
  }

  [DispId(1610743883)]
  bool HasDisplayUnitLabel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743883)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743883)]
    [param: In]
    set;
  }

  [DispId(1610743885)]
  IMsoDisplayUnitLabel DisplayUnitLabel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743885)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743886)]
  IMsoBorder Border
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743886)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743887)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743887)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610743888)]
  IMsoChartFormat Format
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743888)]
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

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }
}