using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024413-0001-0000-C000-000000000046")]
public interface IAppEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewWorkbook([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetSelectionChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeDoubleClick
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeRightClick
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetActivate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetDeactivate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetCalculate([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookOpen([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookActivate([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookDeactivate([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeClose([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeSave
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] bool SaveAsUI, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforePrint([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookNewSheet
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinInstall([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinUninstall([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetFollowHyperlink
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableCloseConnection
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableOpenConnection
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookSync([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] bool IsRefresh, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map,
    [In] [MarshalAs(UnmanagedType.BStr)] string Url, [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookRowsetComplete
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.BStr)] string Description,
    [In] [MarshalAs(UnmanagedType.BStr)] string Sheet, [In] bool Success);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterCalculate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableAfterValueChange
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable,
    [In] [MarshalAs(UnmanagedType.Interface)] Range TargetRange);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableBeforeAllocateChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableBeforeCommitChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableBeforeDiscardChanges
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh,
    [In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowOpen([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowBeforeEdit
    ([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowBeforeClose
  ([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw, [In] XlProtectedViewCloseReason Reason,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowResize([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowActivate([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectedViewWindowDeactivate([In] [MarshalAs(UnmanagedType.Interface)] ProtectedViewWindow Pvw);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterSave([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] bool Success);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookNewChart
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetLensGalleryRenderComplete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookModelChange
  ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb,
    [In] [MarshalAs(UnmanagedType.Interface)] ModelChanges Changes);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeRemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterRemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteWorkbookNewSheet
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteWorkbookNewChart
    ([In] [MarshalAs(UnmanagedType.Interface)] Workbook Wb, [In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}