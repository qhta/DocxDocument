using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024411-0001-0000-C000-000000000046")]
public interface IDocEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectionChange([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeDoubleClick([In] [MarshalAs(UnmanagedType.Interface)] Range Target, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeRightClick([In] [MarshalAs(UnmanagedType.Interface)] Range Target, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Calculate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Change([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FollowHyperlink([In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableUpdate([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableAfterValueChange
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable,
    [In] [MarshalAs(UnmanagedType.Interface)] Range TargetRange);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableBeforeAllocateChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableBeforeCommitChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableBeforeDiscardChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableChangeSync([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LensGalleryRenderComplete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TableUpdate([In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeDelete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteBeforeDelete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemotePivotTableUpdate([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemotePivotTableChangeSync([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}