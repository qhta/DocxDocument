using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00020846-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface Range: IEnumerable
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
  [DispId(304)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Activate();

  [DispId(1063)]
  object AddIndent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1063)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1063)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(236)]
  string Address
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(236)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(437)]
  string AddressLocal
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(437)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(876)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AdvancedFilter
  ([In] XlFilterAction Action, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CriteriaRange,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CopyToRange,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Unique);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(441)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyNames
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Names,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreRelativeAbsolute,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UseRowColumnNames,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OmitColumn,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OmitRow,
    [In] XlApplyNamesOrder Order = XlApplyNamesOrder.xlRowThenColumn,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AppendLast);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(448)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyOutlineStyles();

  [DispId(568)]
  Areas Areas
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(568)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1185)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string AutoComplete([In] [MarshalAs(UnmanagedType.BStr)] string String);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(449)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFill
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Destination,
    [In] XlAutoFillType Type = XlAutoFillType.xlFillDefault);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(793)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFilter
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Criteria1,
    [In] XlAutoFilterOperator Operator = XlAutoFilterOperator.xlAnd,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Criteria2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object VisibleDropDown);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(237)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFit();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(114)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFormat
  ([In] XlRangeAutoFormat Format = XlRangeAutoFormat.xlRangeAutoFormatClassic1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Number,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Font,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Alignment,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Border,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Pattern,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1036)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoOutline();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1067)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object BorderAround
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LineStyle,
    [In] XlBorderWeight Weight = XlBorderWeight.xlThin,
    [In] XlColorIndex ColorIndex = XlColorIndex.xlColorIndexAutomatic,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Color);

  [DispId(435)]
  Borders Borders
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(435)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(279)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Calculate();

  [DispId(238)]
  Range Cells
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(238)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(603)]
  Characters Characters
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(603)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(505)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CheckSpelling
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomDictionary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreUppercase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AlwaysSuggest,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpellLang);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(111)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Clear();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(113)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearContents();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(112)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearFormats();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(239)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearNotes();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1037)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearOutline();

  [DispId(240)]
  int Column
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(240)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(510)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range ColumnDifferences([In] [MarshalAs(UnmanagedType.Struct)] object Comparison);

  [DispId(241)]
  Range Columns
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(241)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(242)]
  object ColumnWidth
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(242)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(242)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(482)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Consolidate
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Sources,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Function,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TopRow,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LeftColumn,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateLinks);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Copy([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1152)]
  int CopyFromRecordset
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object Data,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MaxRows,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MaxColumns);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(213)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CopyPicture
  ([In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlCopyPictureFormat Format = XlCopyPictureFormat.xlPicture);

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(457)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreateNames
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Bottom,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Right);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(458)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreatePublisher
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Edition,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ContainsPICT,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ContainsBIFF,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ContainsRTF,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ContainsVALU);

  [DispId(501)]
  Range CurrentArray
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(501)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(243)]
  Range CurrentRegion
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(243)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(565)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Cut([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(464)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DataSeries
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Rowcol,
    [In] XlDataSeriesType Type = XlDataSeriesType.xlDataSeriesLinear,
    [In] XlDataSeriesDate Date = XlDataSeriesDate.xlDay, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Step,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Stop,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Trend);

  [IndexerName("_Default")]
  [DispId(0)]
  object this
  [[Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RowIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(0)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Shift);

  [DispId(543)]
  Range Dependents
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(543)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(245)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DialogBox();

  [DispId(545)]
  Range DirectDependents
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(545)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(546)]
  Range DirectPrecedents
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(546)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1131)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object EditionOptions
  ([In] XlEditionType Type, [In] XlEditionOptionsOption Option,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Reference,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlPictureAppearance ChartSize = XlPictureAppearance.xlScreen,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format);

  [DispId(500)]
  Range End
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(500)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(246)]
  Range EntireColumn
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(246)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(247)]
  Range EntireRow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(247)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(248)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillDown();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(249)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillLeft();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(250)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillRight();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(251)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillUp();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(398)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Find
  ([In] [MarshalAs(UnmanagedType.Struct)] object What, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LookIn,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LookAt,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchOrder,
    [In] XlSearchDirection SearchDirection = XlSearchDirection.xlNext,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchByte,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchFormat);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(399)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindNext([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(400)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindPrevious([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [DispId(146)]
  Font Font
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(146)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(261)]
  object Formula
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(261)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(261)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(586)]
  object FormulaArray
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(586)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(586)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1380)]
  XlFormulaLabel FormulaLabel
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1380)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1380)]
    [param: In]
    set;
  }

  [DispId(262)]
  object FormulaHidden
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(262)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(262)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(263)]
  object FormulaLocal
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(263)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(263)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(264)]
  object FormulaR1C1
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(264)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(264)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(265)]
  object FormulaR1C1Local
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(265)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(265)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(571)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FunctionWizard();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(472)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  bool GoalSeek
    ([In] [MarshalAs(UnmanagedType.Struct)] object Goal, [In] [MarshalAs(UnmanagedType.Interface)] Range ChangingCell);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(46)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Group
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Start,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object End,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object By,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Periods);

  [DispId(266)]
  object HasArray
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(266)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(267)]
  object HasFormula
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(267)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(123)]
  object Height
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(123)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(268)]
  object Hidden
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(268)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(268)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(136)]
  object HorizontalAlignment
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(136)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(136)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(201)]
  object IndentLevel
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(201)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(201)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1381)]
  void InsertIndent([In] int InsertAmount);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(252)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Insert
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Shift,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CopyOrigin);

  [DispId(129)]
  Interior Interior
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(129)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(170)]
  object Item
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(170)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(170)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(495)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Justify();

  [DispId(127)]
  object Left
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(127)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1187)]
  int ListHeaderRows
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1187)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(253)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ListNames();

  [DispId(691)]
  XlLocationInTable LocationInTable
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(691)]
    get;
  }

  [DispId(269)]
  object Locked
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(269)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(269)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(564)]
  void Merge([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Across);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1384)]
  void UnMerge();

  [DispId(1385)]
  Range MergeArea
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1385)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(208)]
  object MergeCells
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(208)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(208)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(110)]
  object Name
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1032)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object NavigateArrow
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TowardPrecedent,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ArrowNumber,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LinkNumber);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [DispId(502)]
  Range Next
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(502)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1127)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string NoteText
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Text,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Start,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Length);

  [DispId(193)]
  object NumberFormat
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(193)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(193)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1097)]
  object NumberFormatLocal
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1097)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1097)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(254)]
  Range Offset
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(254)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(134)]
  object Orientation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(134)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(134)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(271)]
  object OutlineLevel
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(271)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(271)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(255)]
  int PageBreak
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(255)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(255)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(477)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Parse
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ParseLine,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1027)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PasteSpecial
  ([In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SkipBlanks,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Transpose);

  [DispId(731)]
  PivotField PivotField
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(731)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(740)]
  PivotItem PivotItem
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(740)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(716)]
  PivotTable PivotTable
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(716)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(544)]
  Range Precedents
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(544)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(504)]
  object PrefixCharacter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(504)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(503)]
  Range Previous
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(503)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(905)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(281)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintPreview([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object EnableChanges);

  [DispId(1386)]
  QueryTable QueryTable
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1386)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(197)]
  Range Range
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(197)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(883)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RemoveSubtotal();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(226)]
  bool Replace
  ([In] [MarshalAs(UnmanagedType.Struct)] object What, [In] [MarshalAs(UnmanagedType.Struct)] object Replacement,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LookAt,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchByte,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReplaceFormat);

  [DispId(256)]
  Range Resize
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(256)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(257)]
  int Row
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(257)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(511)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range RowDifferences([In] [MarshalAs(UnmanagedType.Struct)] object Comparison);

  [DispId(272)]
  object RowHeight
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(272)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(272)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(258)]
  Range Rows
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(258)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(259)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Run
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
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

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(235)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(496)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Show();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(877)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowDependents([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Remove);

  [DispId(585)]
  object ShowDetail
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(585)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(585)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(878)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowErrors();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(879)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowPrecedents([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Remove);

  [DispId(209)]
  object ShrinkToFit
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(209)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(209)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(880)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Sort
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key1, [In] XlSortOrder Order1 = XlSortOrder.xlAscending,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type, [In] XlSortOrder Order2 = XlSortOrder.xlAscending,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key3, [In] XlSortOrder Order3 = XlSortOrder.xlAscending,
    [In] XlYesNoGuess Header = XlYesNoGuess.xlNo, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OrderCustom,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [In] XlSortOrientation Orientation = XlSortOrientation.xlSortRows,
    [In] XlSortMethod SortMethod = XlSortMethod.xlPinYin,
    [In] XlSortDataOption DataOption1 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption2 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption3 = XlSortDataOption.xlSortNormal);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(881)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SortSpecial
  ([In] XlSortMethod SortMethod = XlSortMethod.xlPinYin, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key1,
    [In] XlSortOrder Order1 = XlSortOrder.xlAscending, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key2, [In] XlSortOrder Order2 = XlSortOrder.xlAscending,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key3, [In] XlSortOrder Order3 = XlSortOrder.xlAscending,
    [In] XlYesNoGuess Header = XlYesNoGuess.xlNo, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OrderCustom,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [In] XlSortOrientation Orientation = XlSortOrientation.xlSortRows,
    [In] XlSortDataOption DataOption1 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption2 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption3 = XlSortDataOption.xlSortNormal);

  [DispId(916)]
  SoundNote SoundNote
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(916)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(410)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range SpecialCells([In] XlCellType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Value);

  [DispId(260)]
  object Style
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(260)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(260)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(481)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SubscribeTo
  ([In] [MarshalAs(UnmanagedType.BStr)] string Edition,
    [In] XlSubscribeToFormat Format = XlSubscribeToFormat.xlSubscribeToText);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(882)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Subtotal
  ([In] int GroupBy, [In] XlConsolidationFunction Function, [In] [MarshalAs(UnmanagedType.Struct)] object TotalList,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageBreaks,
    [In] XlSummaryRow SummaryBelowData = XlSummaryRow.xlSummaryBelow);

  [DispId(273)]
  object Summary
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(273)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(497)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Table
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RowInput,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ColumnInput);

  [DispId(138)]
  object Text
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(138)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1040)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object TextToColumns
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination,
    [In] XlTextParsingType DataType = XlTextParsingType.xlDelimited,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConsecutiveDelimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tab,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Semicolon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comma,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Space,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Other,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OtherChar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FieldInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DecimalSeparator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ThousandsSeparator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TrailingMinusNumbers);

  [DispId(126)]
  object Top
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(126)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(244)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Ungroup();

  [DispId(274)]
  object UseStandardHeight
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(274)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(274)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(275)]
  object UseStandardWidth
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(275)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(275)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1387)]
  Validation Validation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1387)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(6)]
  object Value
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1388)]
  object Value2
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1388)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1388)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(137)]
  object VerticalAlignment
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(137)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(137)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(122)]
  object Width
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(348)]
  Worksheet Worksheet
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(348)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(276)]
  object WrapText
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(276)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(276)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1389)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Comment AddComment([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Text);

  [DispId(910)]
  Comment Comment
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(910)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1390)]
  void ClearComments();

  [DispId(1391)]
  Phonetic Phonetic
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1391)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1392)]
  FormatConditions FormatConditions
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1392)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(975)]
  int ReadingOrder
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(975)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(975)]
    [param: In]
    set;
  }

  [DispId(1393)]
  Hyperlinks Hyperlinks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1393)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1811)]
  Phonetics Phonetics
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1811)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1812)]
  void SetPhonetic();

  [DispId(1813)]
  string ID
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1813)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1813)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1772)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName);

  [DispId(2013)]
  PivotCell PivotCell
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2013)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2014)]
  void Dirty();

  [DispId(2015)]
  Errors Errors
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2015)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2016)]
  SmartTags SmartTags
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2016)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2017)]
  void Speak
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakDirection,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakFormulas);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1928)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PasteSpecial
  ([In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SkipBlanks,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Transpose);

  [DispId(2020)]
  bool AllowEdit
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2020)]
    get;
  }

  [DispId(2257)]
  ListObject ListObject
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2257)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2258)]
  XPath XPath
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2258)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2491)]
  Actions ServerActions
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2491)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2492)]
  void RemoveDuplicates
    ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Columns, [In] XlYesNoGuess Header = XlYesNoGuess.xlNo);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2361)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintOutEx
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName);

  [DispId(2123)]
  string MDX
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2123)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(2493)]
  void ExportAsFixedFormat
  ([In] XlFixedFormatType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Quality,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IncludeDocProperties,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OpenAfterPublish,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FixedFormatExtClassPtr);

  [DispId(2499)]
  object CountLarge
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2499)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2364)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CalculateRowMajorOrder();

  [DispId(2853)]
  SparklineGroups SparklineGroups
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2853)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2854)]
  void ClearHyperlinks();

  [DispId(666)]
  DisplayFormat DisplayFormat
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(666)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2771)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object BorderAround2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LineStyle,
    [In] XlBorderWeight Weight = XlBorderWeight.xlThin,
    [In] XlColorIndex ColorIndex = XlColorIndex.xlColorIndexAutomatic,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Color,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ThemeColor);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2855)]
  void AllocateChanges();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2856)]
  void DiscardChanges();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2996)]
  void FlashFill();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3175)]
  void ExportAsFixedFormat2
  ([In] XlFixedFormatType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Quality,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IncludeDocProperties,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OpenAfterPublish,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FixedFormatExtClassPtr,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WorkIdentity);

  [DispId(3326)]
  object HasRichDataType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3326)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3274)]
  void ShowCard();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3280)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommentThreaded AddCommentThreaded([In] [MarshalAs(UnmanagedType.BStr)] string Text);

  [DispId(3281)]
  CommentThreaded CommentThreaded
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3281)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3288)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Sort2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key1, [In] XlSortOrder Order1 = XlSortOrder.xlAscending,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type, [In] XlSortOrder Order2 = XlSortOrder.xlAscending,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Key3, [In] XlSortOrder Order3 = XlSortOrder.xlAscending,
    [In] XlYesNoGuess Header = XlYesNoGuess.xlNo, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OrderCustom,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [In] XlSortOrientation Orientation = XlSortOrientation.xlSortRows,
    [In] XlSortMethod SortMethod = XlSortMethod.xlPinYin,
    [In] XlSortDataOption DataOption1 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption2 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption3 = XlSortDataOption.xlSortNormal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SubField1);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3289)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFilter2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Field,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Criteria1,
    [In] XlAutoFilterOperator Operator = XlAutoFilterOperator.xlAnd,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Criteria2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object VisibleDropDown,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SubField);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3290)]
  void ConvertToLinkedDataType([In] int ServiceID, [In] [MarshalAs(UnmanagedType.BStr)] string LanguageCulture);

  [DispId(3291)]
  object LinkedDataTypeState
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3291)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3293)]
  void SetCellDataTypeFromCell([In] [MarshalAs(UnmanagedType.Interface)] Range SourceCell);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3294)]
  void DataTypeToText();

  [DispId(3295)]
  object HasSpill
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3295)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(3296)]
  Range SpillingToRange
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3296)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3297)]
  Range SpillParent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3297)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3299)]
  void RefreshLinkedDataType([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DomainID);

  [DispId(1580)]
  object Formula2
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1580)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1580)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(3300)]
  object Formula2Local
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3300)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3300)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(3301)]
  object Formula2R1C1
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3301)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3301)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(3302)]
  object Formula2R1C1Local
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3302)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3302)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(3303)]
  object SavedAsArray
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3303)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3305)]
  bool Replace2
  ([In] [MarshalAs(UnmanagedType.Struct)] object What, [In] [MarshalAs(UnmanagedType.Struct)] object Replacement,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LookAt,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchCase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MatchByte,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SearchFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReplaceFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FormulaVersion);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3402)]
  void InsertPictureInCell([In] [MarshalAs(UnmanagedType.BStr)] string PictureURI);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3405)]
  void PastePictureInCell();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3407)]
  void PlacePictureOverCells([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AsReference);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3410)]
  void UpdatePictureInCellAlternativeText([In] [MarshalAs(UnmanagedType.BStr)] string AlternativeText);

  [DispId(3411)]
  CellControl CellControl
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3411)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3413)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearContents2([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RemoveControls);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3415)]
  void ResetContents();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3414)]
  void RemoveControls();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3419)]
  void TogglePythonMarshalMode([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MarshalMode);
}