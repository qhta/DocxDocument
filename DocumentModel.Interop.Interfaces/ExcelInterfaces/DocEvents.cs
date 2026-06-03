using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("00024411-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface DocEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1543)]
  void SelectionChange([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1537)]
  void BeforeDoubleClick([In] [MarshalAs(UnmanagedType.Interface)] Range Target, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1534)]
  void BeforeRightClick([In] [MarshalAs(UnmanagedType.Interface)] Range Target, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(304)]
  void Activate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1530)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(279)]
  void Calculate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1545)]
  void Change([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1470)]
  void FollowHyperlink([In] [MarshalAs(UnmanagedType.Interface)] Hyperlink Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2156)]
  void PivotTableUpdate([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2886)]
  void PivotTableAfterValueChange
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable,
    [In] [MarshalAs(UnmanagedType.Interface)] Range TargetRange);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2889)]
  void PivotTableBeforeAllocateChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2892)]
  void PivotTableBeforeCommitChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd, [In] [Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2893)]
  void PivotTableBeforeDiscardChanges
  ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable TargetPivotTable, [In] int ValueChangeStart,
    [In] int ValueChangeEnd);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2894)]
  void PivotTableChangeSync([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3072)]
  void LensGalleryRenderComplete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3073)]
  void TableUpdate([In] [MarshalAs(UnmanagedType.Interface)] TableObject Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3074)]
  void BeforeDelete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3338)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteChange([In] [MarshalAs(UnmanagedType.Interface)] Range Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3339)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemoteBeforeDelete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3340)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RemotePivotTableUpdate([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3341)]
  void RemotePivotTableChangeSync([In] [MarshalAs(UnmanagedType.Interface)] PivotTable Target);
}