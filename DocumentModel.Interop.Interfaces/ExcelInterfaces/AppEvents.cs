using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("00024413-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
public interface AppEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1565)]
  void NewWorkbook([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1558)]
  void SheetSelectionChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1559)]
  void SheetBeforeDoubleClick
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1560)]
  void SheetBeforeRightClick
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1561)]
  void SheetActivate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1562)]
  void SheetDeactivate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1563)]
  void SheetCalculate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1564)]
  void SheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1567)]
  void WorkbookOpen([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1568)]
  void WorkbookActivate([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1569)]
  void WorkbookDeactivate([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1570)]
  void WorkbookBeforeClose([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1571)]
  void WorkbookBeforeSave
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] bool SaveAsUI, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1572)]
  void WorkbookBeforePrint([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1573)]
  void WorkbookNewSheet
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1574)]
  void WorkbookAddinInstall([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1575)]
  void WorkbookAddinUninstall([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1554)]
  void WindowResize
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1556)]
  void WindowActivate
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1557)]
  void WindowDeactivate
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1854)]
  void SheetFollowHyperlink
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2157)]
  void SheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2160)]
  void WorkbookPivotTableCloseConnection
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2161)]
  void WorkbookPivotTableOpenConnection
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2289)]
  void WorkbookSync([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2290)]
  void WorkbookBeforeXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] bool IsRefresh, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2291)]
  void WorkbookAfterXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2292)]
  void WorkbookBeforeXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2293)]
  void WorkbookAfterXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2611)]
  void WorkbookRowsetComplete
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.BStr)] string Description,
    [In] [MarshalAs(UnmanagedType.BStr)] string Sheet, [In] bool Success);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2612)]
  void AfterCalculate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2895)]
  void SheetPivotTableAfterValueChange
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable,
    [In] [MarshalAs(UnmanagedType.Interface)] Range TargetRange);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2896)]
  void SheetPivotTableBeforeAllocateChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2897)]
  void SheetPivotTableBeforeCommitChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2898)]
  void SheetPivotTableBeforeDiscardChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2903)]
  void ProtectedViewWindowOpen([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2905)]
  void ProtectedViewWindowBeforeEdit
    ([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2906)]
  void ProtectedViewWindowBeforeClose
  ([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw, [In] XlProtectedViewCloseReason Reason,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2908)]
  void ProtectedViewWindowResize([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2909)]
  void ProtectedViewWindowActivate([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2910)]
  void ProtectedViewWindowDeactivate([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2911)]
  void WorkbookAfterSave([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] bool Success);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2912)]
  void WorkbookNewChart
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3075)]
  void SheetLensGalleryRenderComplete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3076)]
  void SheetTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3080)]
  void WorkbookModelChange
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] ModelChanges Changes);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3079)]
  void SheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3350)]
  void WorkbookBeforeRemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3351)]
  void WorkbookAfterRemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3344)]
  void RemoteSheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3352)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteWorkbookNewSheet
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3353)]
  void RemoteWorkbookNewChart
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3347)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3348)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}