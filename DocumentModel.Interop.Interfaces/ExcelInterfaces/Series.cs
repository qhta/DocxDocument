using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[Guid("0002086B-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Series
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(151)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _ApplyDataLabels
  ([In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LegendKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasLeaderLines);

  [DispId(47)]
  XlAxisGroup AxisGroup
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(47)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(47)]
    [param: In]
    set;
  }

  [DispId(128)]
  Border Border
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(128)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(112)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearFormats();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Copy();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(157)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DataLabels([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(152)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ErrorBar
  ([In] XlErrorBarDirection Direction, [In] XlErrorBarInclude Include, [In] XlErrorBarType Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Amount,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MinusValues);

  [DispId(159)]
  ErrorBars ErrorBars
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(159)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(182)]
  int Explosion
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(182)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(182)]
    [param: In]
    set;
  }

  [DispId(261)]
  string Formula
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(261)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(261)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(263)]
  string FormulaLocal
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(263)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(263)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(264)]
  string FormulaR1C1
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(264)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(264)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(265)]
  string FormulaR1C1Local
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(265)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(265)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(78)]
  bool HasDataLabels
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(78)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(78)]
    [param: In]
    set;
  }

  [DispId(160)]
  bool HasErrorBars
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(160)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(160)]
    [param: In]
    set;
  }

  [DispId(129)]
  Interior Interior
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(129)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1663)]
  ChartFillFormat Fill
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1663)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(132)]
  bool InvertIfNegative
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(132)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(132)]
    [param: In]
    set;
  }

  [DispId(73)]
  int MarkerBackgroundColor
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(73)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(73)]
    [param: In]
    set;
  }

  [DispId(74)]
  XlColorIndex MarkerBackgroundColorIndex
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(74)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(74)]
    [param: In]
    set;
  }

  [DispId(75)]
  int MarkerForegroundColor
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(75)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(75)]
    [param: In]
    set;
  }

  [DispId(76)]
  XlColorIndex MarkerForegroundColorIndex
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(76)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(76)]
    [param: In]
    set;
  }

  [DispId(231)]
  int MarkerSize
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(231)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(231)]
    [param: In]
    set;
  }

  [DispId(72)]
  XlMarkerStyle MarkerStyle
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(72)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(72)]
    [param: In]
    set;
  }

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(211)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Paste();

  [DispId(161)]
  XlChartPictureType PictureType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(161)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(161)]
    [param: In]
    set;
  }

  [DispId(162)]
  int PictureUnit
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(162)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(162)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(228)]
  int PlotOrder
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(228)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(228)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(70)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Points([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(235)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select();

  [DispId(163)]
  bool Smooth
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(163)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(163)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(154)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Trendlines([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(108)]
  int Type
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    [param: In]
    set;
  }

  [DispId(1400)]
  XlChartType ChartType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1400)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1400)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1401)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void ApplyCustomType([In] XlChartType ChartType);

  [DispId(164)]
  object Values
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(164)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(164)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1111)]
  object XValues
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1111)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1111)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1664)]
  object BubbleSizes
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1664)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1664)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1403)]
  XlBarShape BarShape
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1403)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1403)]
    [param: In]
    set;
  }

  [DispId(1659)]
  bool ApplyPictToSides
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1659)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1659)]
    [param: In]
    set;
  }

  [DispId(1660)]
  bool ApplyPictToFront
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1660)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1660)]
    [param: In]
    set;
  }

  [DispId(1661)]
  bool ApplyPictToEnd
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1661)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1661)]
    [param: In]
    set;
  }

  [DispId(1665)]
  bool Has3DEffect
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1665)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1665)]
    [param: In]
    set;
  }

  [DispId(103)]
  bool Shadow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    [param: In]
    set;
  }

  [DispId(1394)]
  bool HasLeaderLines
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1394)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1394)]
    [param: In]
    set;
  }

  [DispId(1666)]
  LeaderLines LeaderLines
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1666)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1922)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyDataLabels
  ([In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LegendKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasLeaderLines,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowSeriesName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowCategoryName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowPercentage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowBubbleSize,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Separator);

  [DispId(2649)]
  double PictureUnit2
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2649)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2649)]
    [param: In]
    set;
  }

  [DispId(116)]
  ChartFormat Format
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(116)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2915)]
  int PlotColorIndex
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2915)]
    get;
  }

  [DispId(2916)]
  int InvertColor
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2916)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2916)]
    [param: In]
    set;
  }

  [DispId(2917)]
  int InvertColorIndex
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2917)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2917)]
    [param: In]
    set;
  }

  [DispId(3083)]
  bool IsFiltered
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3083)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3083)]
    [param: In]
    set;
  }

  [DispId(3204)]
  XlParentDataLabelOptions ParentDataLabelOption
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3204)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3204)]
    [param: In]
    set;
  }

  [DispId(3205)]
  bool QuartileCalculationInclusiveMedian
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3205)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3205)]
    [param: In]
    set;
  }

  [DispId(3229)]
  XlValueSortOrder ValueSortOrder
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3229)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3229)]
    [param: In]
    set;
  }

  [DispId(3250)]
  XlGeoProjectionType GeoProjectionType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3250)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3250)]
    [param: In]
    set;
  }

  [DispId(3251)]
  XlGeoMappingLevel GeoMappingLevel
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3251)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3251)]
    [param: In]
    set;
  }

  [DispId(3252)]
  XlRegionLabelOptions RegionLabelOption
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3252)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3252)]
    [param: In]
    set;
  }

  [DispId(3261)]
  XlSeriesColorGradientStyle SeriesColorGradientStyle
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3261)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3261)]
    [param: In]
    set;
  }

  [DispId(3262)]
  ChartSeriesGradientStopData SeriesColorMinGradientStop
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3262)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3263)]
  ChartSeriesGradientStopData SeriesColorMidGradientStop
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3263)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3264)]
  ChartSeriesGradientStopData SeriesColorMaxGradientStop
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3264)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3253)]
  void SetProperty([In] [MarshalAs(UnmanagedType.BStr)] string ID, [In] [MarshalAs(UnmanagedType.Struct)] object Value);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3256)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetProperty([In] [MarshalAs(UnmanagedType.BStr)] string ID);
}