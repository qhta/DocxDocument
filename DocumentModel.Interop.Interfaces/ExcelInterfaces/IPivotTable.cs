using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00020872-0001-0000-C000-000000000046")]
[DefaultMember("_Default")]
public interface IPivotTable
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AddFields
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RowFields,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ColumnFields,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageFields,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToTable);

  [DispId(713)]
  object ColumnFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(694)]
  bool ColumnGrand
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(702)]
  Range ColumnRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowPages([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageField);

  [DispId(705)]
  Range DataBodyRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(715)]
  object DataFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(704)]
  Range DataLabelRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(0)]
  string _Default
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(695)]
  bool HasAutoFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(711)]
  object HiddenFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(698)]
  string InnerDetail
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(714)]
  object PageFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(703)]
  Range PageRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1482)]
  Range PageRangeCells
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object PivotFields([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(696)]
  DateTime RefreshDate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(697)]
  string RefreshName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool RefreshTable();

  [DispId(712)]
  object RowFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(693)]
  bool RowGrand
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(701)]
  Range RowRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(692)]
  bool SaveData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(686)]
  object SourceData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(699)]
  Range TableRange1
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(700)]
  Range TableRange2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(6)]
  string Value
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(710)]
  object VisibleFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1483)]
  int CacheIndex
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CalculatedFields CalculatedFields();

  [DispId(1485)]
  bool DisplayErrorString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1486)]
  bool DisplayNullString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1487)]
  bool EnableDrilldown
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1488)]
  bool EnableFieldDialog
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1489)]
  bool EnableWizard
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1490)]
  string ErrorString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GetData([In] [MarshalAs(UnmanagedType.BStr)] string Name);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ListFormulas();

  [DispId(1493)]
  bool ManualUpdate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1494)]
  bool MergeLabels
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1495)]
  string NullString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotCache PivotCache();

  [DispId(1497)]
  PivotFormulas PivotFormulas
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableWizard
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SourceType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SourceData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TableDestination,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TableName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RowGrand,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ColumnGrand,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasAutoFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoPage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Reserved,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object BackgroundQuery,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OptimizeCache,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageFieldOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageFieldWrapCount,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Connection);

  [DispId(1498)]
  bool SubtotalHiddenPageItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1429)]
  int PageFieldOrder
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1499)]
  string PageFieldStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1430)]
  int PageFieldWrapCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1500)]
  bool PreserveFormatting
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _PivotSelect
    ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] XlPTSelectionMode Mode = XlPTSelectionMode.xlDataAndLabel);

  [DispId(1502)]
  string PivotSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1503)]
  XlPTSelectionMode SelectionMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1504)]
  string TableStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1505)]
  string Tag
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Update();

  [DispId(1506)]
  string VacatedStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void Format([In] XlPivotFormatType Format);

  [DispId(1838)]
  bool PrintTitles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1839)]
  CubeFields CubeFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1840)]
  string GrandTotalName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1841)]
  bool SmallGrid
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1842)]
  bool RepeatItemsOnEachPrintedPage
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(1843)]
  bool TotalsAnnotation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotSelect
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] XlPTSelectionMode Mode = XlPTSelectionMode.xlDataAndLabel,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UseStandardName);

  [DispId(2089)]
  string PivotSelectionStandard
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GetPivotData
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataField,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Item14);

  [DispId(2120)]
  PivotField DataPivotField
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2121)]
  bool EnableDataValueEditing
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotField AddDataField
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Field,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Caption,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Function);

  [DispId(2123)]
  string MDX
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(2124)]
  bool ViewCalculatedMembers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2125)]
  CalculatedMembers CalculatedMembers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2126)]
  bool DisplayImmediateItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy15
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(2128)]
  bool EnableFieldList
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2129)]
  bool VisualTotals
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2130)]
  bool ShowPageMultipleItemLabel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(392)]
  XlPivotTableVersionList Version
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string CreateCubeFile
  ([In] [MarshalAs(UnmanagedType.BStr)] string File, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Measures,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Levels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Members,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Properties);

  [DispId(2136)]
  bool DisplayEmptyRow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2137)]
  bool DisplayEmptyColumn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2138)]
  bool ShowCellBackgroundFromOLAP
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(2546)]
  PivotAxis PivotColumnAxis
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2547)]
  PivotAxis PivotRowAxis
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2548)]
  bool ShowDrillIndicators
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2549)]
  bool PrintDrillIndicators
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2550)]
  bool DisplayMemberPropertyTooltips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2551)]
  bool DisplayContextTooltips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearTable();

  [DispId(2553)]
  int CompactRowIndent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2554)]
  XlLayoutRowType LayoutRowDefault
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2555)]
  bool DisplayFieldCaptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RowAxisLayout([In] XlLayoutRowType RowLayout);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SubtotalLocation([In] XlSubtototalLocationType Location);

  [DispId(2559)]
  PivotFilters ActiveFilters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2560)]
  bool InGridDropZones
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearAllFilters();

  [DispId(2562)]
  object TableStyle2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(2563)]
  bool ShowTableStyleLastColumn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2564)]
  bool ShowTableStyleRowStripes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2565)]
  bool ShowTableStyleColumnStripes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2566)]
  bool ShowTableStyleRowHeaders
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2567)]
  bool ShowTableStyleColumnHeaders
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertToFormulas([In] bool ConvertFilters);

  [DispId(2570)]
  bool AllowMultipleFilters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2571)]
  string CompactLayoutRowHeader
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2572)]
  string CompactLayoutColumnHeader
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2573)]
  bool FieldListSortAscending
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2574)]
  bool SortUsingCustomLists
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangeConnection([In] [MarshalAs(UnmanagedType.Interface)] WorkbookConnection conn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangePivotCache([In] [MarshalAs(UnmanagedType.Struct)] object PivotCache);

  [DispId(1397)]
  string Location
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2872)]
  bool EnableWriteback
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2873)]
  XlAllocation Allocation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2874)]
  XlAllocationValue AllocationValue
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2875)]
  XlAllocationMethod AllocationMethod
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2876)]
  string AllocationWeightExpression
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AllocateChanges();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CommitChanges();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DiscardChanges();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RefreshDataSourceValues();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RepeatAllLabels([In] XlPivotFieldRepeatLabels Repeat);

  [DispId(2880)]
  PivotTableChangeList ChangeList
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2881)]
  Slicers Slicers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1891)]
  string AlternativeText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(273)]
  string Summary
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2882)]
  bool VisualTotalsForSets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2883)]
  bool ShowValuesRow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2884)]
  bool CalculatedMembersInFilters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotValueCell PivotValueCell
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object rowline,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object columnline);

  [DispId(268)]
  bool Hidden
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(3067)]
  Shape PivotChart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DrillDown
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotItem PivotItem,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PivotLine);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DrillUp
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotItem PivotItem,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PivotLine,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LevelUniqueName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DrillTo
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotItem PivotItem,
    [In] [MarshalAs(UnmanagedType.Interface)] CubeField CubeField,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PivotLine);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy2
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyLayout();

  [DispId(3421)]
  bool AutoRefresh
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }
}