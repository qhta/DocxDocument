using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C1709-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface IMsoChart
{
  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  bool HasTitle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    [param: In]
    set;
  }

  [DispId(1610743811)]
  IMsoChartTitle ChartTitle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743811)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743812)]
  int DepthPercent
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
  int Elevation
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
  int GapDepth
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [param: In]
    set;
  }

  [DispId(1610743818)]
  int HeightPercent
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
  int Perspective
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    [param: In]
    set;
  }

  [DispId(1610743822)]
  object RightAngleAxes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743822)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743822)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743824)]
  object Rotation
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
  XlDisplayBlanksAs DisplayBlanksAs
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
  bool ProtectData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    [TypeLibFunc(1)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1)]
    [DispId(1610743828)]
    [param: In]
    set;
  }

  [DispId(1610743830)]
  bool ProtectFormatting
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1)]
    [DispId(1610743830)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743830)]
    [TypeLibFunc(1)]
    [param: In]
    set;
  }

  [DispId(1610743832)]
  bool ProtectGoalSeek
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1)]
    [DispId(1610743832)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743832)]
    [TypeLibFunc(1)]
    [param: In]
    set;
  }

  [DispId(1610743834)]
  bool ProtectSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743834)]
    [TypeLibFunc(1)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1)]
    [DispId(1610743834)]
    [param: In]
    set;
  }

  [DispId(1610743836)]
  bool ProtectChartObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743836)]
    [TypeLibFunc(1)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743836)]
    [TypeLibFunc(1)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1)]
  [DispId(1610743838)]
  void UnProtect([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1)]
  [DispId(1610743839)]
  void Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly);

  [DispId(8)]
  object ChartGroups
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(2)]
    [DispId(8)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(68)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object SeriesCollection([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(151)]
  [TypeLibFunc(1088)]
  void _ApplyDataLabels
  ([In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IMsoLegendKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasLeaderLines);

  [DispId(109)]
  int SubType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(109)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(109)]
    [TypeLibFunc(64)]
    [param: In]
    set;
  }

  [DispId(108)]
  int Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(108)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(108)]
    [param: In]
    set;
  }

  [DispId(79)]
  IMsoCorners Corners
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(79)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1922)]
  void ApplyDataLabels
  ([In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IMsoLegendKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasLeaderLines,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowSeriesName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowCategoryName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowValue,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowPercentage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowBubbleSize,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Separator);

  [DispId(1400)]
  XlChartType ChartType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1400)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1400)]
    [param: In]
    set;
  }

  [DispId(1396)]
  bool HasDataTable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1396)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1396)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1401)]
  void ApplyCustomType([In] XlChartType ChartType, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TypeName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1409)]
  void GetChartElement
    ([In] int x, [In] int y, [In] [Out] ref int ElementID, [In] [Out] ref int Arg1, [In] [Out] ref int Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1413)]
  void SetSourceData
  ([In] [MarshalAs(UnmanagedType.BStr)] string Source,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PlotBy);

  [DispId(202)]
  XlRowCol PlotBy
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(202)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(202)]
    [param: In]
    set;
  }

  [DispId(53)]
  bool HasLegend
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(53)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(53)]
    [param: In]
    set;
  }

  [DispId(84)]
  IMsoLegend Legend
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(84)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743861)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Axes
    ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary);

  [DispId(1610743862)]
  object HasAxis
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743862)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743862)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1610743864)]
  IMsoWalls Walls
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743864)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743865)]
  IMsoFloor Floor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743865)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743866)]
  IMsoPlotArea PlotArea
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743866)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(92)]
  bool PlotVisibleOnly
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(92)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(92)]
    [param: In]
    set;
  }

  [DispId(1610743869)]
  IMsoChartArea ChartArea
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743869)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743870)]
  void AutoFormat([In] int rGallery, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varFormat);

  [DispId(1610743871)]
  bool AutoScaling
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743871)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743871)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1)]
  [DispId(1610743873)]
  void SetBackgroundPicture([In] [MarshalAs(UnmanagedType.BStr)] string bstr);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(11)]
  [DispId(1610743874)]
  void ChartWizard
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varSource,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varGallery,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varPlotBy,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varCategoryLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varSeriesLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varHasLegend,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varTitle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varCategoryTitle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varValueTitle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varExtraTitle);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743875)]
  [LCIDConversion(3)]
  void CopyPicture([In] int Appearance = 1, [In] int Format = -4147, [In] int Size = 2);

  [DispId(1610743876)]
  IMsoDataTable DataTable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743876)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743877)]
  [TypeLibFunc(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object varName, [In] int LocaleID, out int ObjType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1025)]
  [DispId(1610743878)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object varName, [In] int LocaleID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743879)]
  [LCIDConversion(1)]
  [TypeLibFunc(1)]
  void Paste([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varType);

  [DispId(1610743880)]
  XlBarShape BarShape
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743880)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743880)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743882)]
  bool Export
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstr,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varFilterName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varInteractive);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743883)]
  void SetDefaultChart([In] [MarshalAs(UnmanagedType.Struct)] object varName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743884)]
  void ApplyChartTemplate([In] [MarshalAs(UnmanagedType.BStr)] string bstrFileName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743885)]
  void SaveChartTemplate([In] [MarshalAs(UnmanagedType.BStr)] string bstrFileName);

  [DispId(2377)]
  IMsoWalls SideWall
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2377)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2378)]
  IMsoWalls BackWall
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2378)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2465)]
  object ChartStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2465)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2465)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2466)]
  void ClearToMatchStyle();

  [DispId(1814)]
  object PivotLayout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1814)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1815)]
  bool HasPivotFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1815)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1815)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743894)]
  void RefreshPivotTable();

  [DispId(1610743895)]
  bool ShowDataLabelsOverMaximum
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743895)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743895)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2468)]
  void ApplyLayout([In] int Layout, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChartType);

  [DispId(1610743898)]
  object Selection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743898)]
    [TypeLibFunc(1)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743899)]
  void Refresh();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743900)]
  void SetElement([In] MsoChartElementType RHS);

  [DispId(1610743901)]
  IMsoChartData ChartData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743901)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743902)]
  IMsoChartFormat Format
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743902)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743903)]
  Shapes Shapes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743903)]
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

  [DispId(17)]
  IMsoChartGroup Area3DGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(17)]
    [TypeLibFunc(64)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(9)]
  [TypeLibFunc(64)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AreaGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(18)]
  IMsoChartGroup Bar3DGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(18)]
    [TypeLibFunc(64)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(10)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object BarGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(19)]
  IMsoChartGroup Column3DGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(19)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  [LCIDConversion(1)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ColumnGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(20)]
  IMsoChartGroup Line3DGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(20)]
    [TypeLibFunc(64)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  [TypeLibFunc(64)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object LineGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(21)]
  IMsoChartGroup Pie3DGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(21)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(13)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object PieGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  [LCIDConversion(1)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DoughnutGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  [LCIDConversion(1)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object RadarGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(22)]
  IMsoChartGroup SurfaceGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(22)]
    [LCIDConversion(0)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(16)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object XYGroups([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Copy();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(235)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [DispId(1610743923)]
  bool ShowReportFilterFieldButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743923)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743923)]
    [param: In]
    set;
  }

  [DispId(1610743925)]
  bool ShowLegendFieldButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743925)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743925)]
    [param: In]
    set;
  }

  [DispId(1610743927)]
  bool ShowAxisFieldButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743927)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743927)]
    [param: In]
    set;
  }

  [DispId(1610743929)]
  bool ShowValueFieldButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743929)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743929)]
    [param: In]
    set;
  }

  [DispId(1610743931)]
  bool ShowAllFieldButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743931)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743931)]
    [param: In]
    set;
  }

  [DispId(1610743933)]
  bool ProtectChartSheetFormatting
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743933)]
    [TypeLibFunc(1)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(236)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object FullSeriesCollection([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(237)]
  XlCategoryLabelLevel CategoryLabelLevel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(237)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(237)]
    [param: In]
    set;
  }

  [DispId(238)]
  XlSeriesNameLevel SeriesNameLevel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(238)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(238)]
    [param: In]
    set;
  }

  [DispId(239)]
  bool HasHiddenContent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(239)]
    [TypeLibFunc(64)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(240)]
  [TypeLibFunc(64)]
  void DeleteHiddenContent();

  [DispId(2467)]
  object ChartColor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2467)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2467)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2469)]
  void ClearToMatchColorStyle();
}