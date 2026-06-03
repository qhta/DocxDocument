using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[Guid("000244FB-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface DefaultPivotTableLayoutOptions
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

  [DispId(2560)]
  bool InGridDropZones
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2560)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2560)]
    [param: In]
    set;
  }

  [DispId(2555)]
  bool DisplayFieldCaptions
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2555)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2555)]
    [param: In]
    set;
  }

  [DispId(2573)]
  bool FieldListSortAscending
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2573)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2573)]
    [param: In]
    set;
  }

  [DispId(2124)]
  bool ViewCalculatedMembers
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2124)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2124)]
    [param: In]
    set;
  }

  [DispId(2551)]
  bool DisplayContextTooltips
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2551)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2551)]
    [param: In]
    set;
  }

  [DispId(2548)]
  bool ShowDrillIndicators
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2548)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2548)]
    [param: In]
    set;
  }

  [DispId(2137)]
  bool DisplayEmptyColumn
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2137)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2137)]
    [param: In]
    set;
  }

  [DispId(2136)]
  bool DisplayEmptyRow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2136)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2136)]
    [param: In]
    set;
  }

  [DispId(2550)]
  bool DisplayMemberPropertyTooltips
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2550)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2550)]
    [param: In]
    set;
  }

  [DispId(2883)]
  bool ShowValuesRow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2883)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2883)]
    [param: In]
    set;
  }

  [DispId(1486)]
  bool DisplayNullString
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1486)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1486)]
    [param: In]
    set;
  }

  [DispId(1495)]
  string NullString
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1495)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1495)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1485)]
  bool DisplayErrorString
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1485)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1485)]
    [param: In]
    set;
  }

  [DispId(1490)]
  string ErrorString
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1490)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1490)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(695)]
  bool HasAutoFormat
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(695)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(695)]
    [param: In]
    set;
  }

  [DispId(1429)]
  bool PageFieldOrder
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1429)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1429)]
    [param: In]
    set;
  }

  [DispId(1494)]
  bool MergeLabels
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1494)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1494)]
    [param: In]
    set;
  }

  [DispId(1500)]
  bool PreserveFormatting
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1500)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1500)]
    [param: In]
    set;
  }

  [DispId(1430)]
  int PageFieldWrapCount
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1430)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1430)]
    [param: In]
    set;
  }

  [DispId(2553)]
  int CompactRowIndent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2553)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2553)]
    [param: In]
    set;
  }

  [DispId(2549)]
  bool PrintDrillIndicators
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2549)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2549)]
    [param: In]
    set;
  }

  [DispId(1842)]
  bool RepeatItemsOnEachPrintedPage
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1842)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1842)]
    [param: In]
    set;
  }

  [DispId(1838)]
  bool PrintTitles
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1838)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1838)]
    [param: In]
    set;
  }

  [DispId(2570)]
  bool AllowMultipleFilters
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2570)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2570)]
    [param: In]
    set;
  }

  [DispId(2884)]
  bool CalculatedMembersInFilters
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2884)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2884)]
    [param: In]
    set;
  }

  [DispId(2882)]
  bool VisualTotalsForSets
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2882)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2882)]
    [param: In]
    set;
  }

  [DispId(2129)]
  bool VisualTotals
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2129)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2129)]
    [param: In]
    set;
  }

  [DispId(1843)]
  bool TotalsAnnotation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1843)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1843)]
    [param: In]
    set;
  }

  [DispId(693)]
  bool RowGrand
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(693)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(693)]
    [param: In]
    set;
  }

  [DispId(694)]
  bool ColumnGrand
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(694)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(694)]
    [param: In]
    set;
  }

  [DispId(1498)]
  bool SubtotalHiddenPageItems
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1498)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1498)]
    [param: In]
    set;
  }

  [DispId(2574)]
  bool SortUsingCustomLists
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2574)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2574)]
    [param: In]
    set;
  }

  [DispId(692)]
  bool SaveData
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(692)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(692)]
    [param: In]
    set;
  }

  [DispId(1487)]
  bool EnableDrilldown
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1487)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1487)]
    [param: In]
    set;
  }

  [DispId(1479)]
  bool RefreshOnFileOpen
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1479)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1479)]
    [param: In]
    set;
  }

  [DispId(3270)]
  int xlMissingItemsNone
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3270)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3270)]
    [param: In]
    set;
  }

  [DispId(733)]
  bool Subtotals
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(733)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(733)]
    [param: In]
    set;
  }

  [DispId(2558)]
  bool SubtotalLocation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2558)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2558)]
    [param: In]
    set;
  }

  [DispId(1845)]
  bool LayoutBlankLine
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1845)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1845)]
    [param: In]
    set;
  }

  [DispId(2556)]
  XlLayoutRowType RowAxisLayout
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2556)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2556)]
    [param: In]
    set;
  }

  [DispId(2879)]
  XlPivotFieldRepeatLabels RepeatAllLabels
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2879)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2879)]
    [param: In]
    set;
  }

  [DispId(2126)]
  bool DisplayImmediateItems
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2126)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2126)]
    [param: In]
    set;
  }

  [DispId(2872)]
  bool EnableWriteback
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2872)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2872)]
    [param: In]
    set;
  }
}