using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024412-0001-0000-C000-000000000046")]
public interface IWorkbookEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeClose([In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeSave([In] bool SaveAsUI, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforePrint([In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewSheet([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinInstall();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinUninstall();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

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
  void SheetFollowHyperlink
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableCloseConnection([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableOpenConnection([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sync([In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] bool IsRefresh, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlImport
    ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RowsetComplete
  ([In] [MarshalAs(UnmanagedType.BStr)] string Description, [In] [MarshalAs(UnmanagedType.BStr)] string Sheet,
    [In] bool Success);

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
  void SheetPivotTableChangeSync
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterSave([In] bool Success);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewChart([In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetLensGalleryRenderComplete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ModelChange([In] [MarshalAs(UnmanagedType.Interface)] ModelChanges Changes);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeRemoteChange();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterRemoteChange();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteNewSheet([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteNewChart([In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetPivotTableChangeSync
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}