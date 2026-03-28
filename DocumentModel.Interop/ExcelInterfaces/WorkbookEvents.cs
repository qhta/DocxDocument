using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00024412-0000-0000-C000-000000000046")]
public interface WorkbookEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1923)]
  void Open();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(304)]
  void Activate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1530)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1546)]
  void BeforeClose([In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1547)]
  void BeforeSave([In] bool SaveAsUI, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1549)]
  void BeforePrint([In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1550)]
  void NewSheet([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1552)]
  void AddinInstall();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1553)]
  void AddinUninstall();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1554)]
  void WindowResize([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1556)]
  void WindowActivate([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1557)]
  void WindowDeactivate([In] [MarshalAs(UnmanagedType.Interface)] Window Wn);

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
  [DispId(1854)]
  void SheetFollowHyperlink
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2157)]
  void SheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2158)]
  void PivotTableCloseConnection([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2159)]
  void PivotTableOpenConnection([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2266)]
  void Sync([In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2283)]
  void BeforeXmlImport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] bool IsRefresh, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2285)]
  void AfterXmlImport
    ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2287)]
  void BeforeXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2288)]
  void AfterXmlExport
  ([In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map, [In] [MarshalAs(UnmanagedType.BStr)] string Url,
    [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2610)]
  void RowsetComplete
  ([In] [MarshalAs(UnmanagedType.BStr)] string Description, [In] [MarshalAs(UnmanagedType.BStr)] string Sheet,
    [In] bool Success);

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
  [DispId(2899)]
  void SheetPivotTableChangeSync
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2900)]
  void AfterSave([In] bool Success);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2901)]
  void NewChart([In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3075)]
  void SheetLensGalleryRenderComplete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3076)]
  void SheetTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3077)]
  void ModelChange([In] [MarshalAs(UnmanagedType.Interface)] ModelChanges Changes);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3079)]
  void SheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3342)]
  void BeforeRemoteChange();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3343)]
  void AfterRemoteChange();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3344)]
  void RemoteSheetChange
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3345)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteNewSheet([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3346)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteNewChart([In] [MarshalAs(UnmanagedType.Interface)] Chart Ch);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3347)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetBeforeDelete([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3348)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteSheetPivotTableUpdate
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3349)]
  void RemoteSheetPivotTableChangeSync
    ([In] [MarshalAs(UnmanagedType.IDispatch)] object Sh, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}