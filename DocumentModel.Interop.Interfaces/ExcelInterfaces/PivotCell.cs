using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00024458-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface PivotCell
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

  [DispId(2189)]
  XlPivotCellType PivotCellType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2189)]
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

  [DispId(2091)]
  PivotField DataField
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2091)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

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

  [DispId(2190)]
  PivotItemList RowItems
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2190)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2191)]
  PivotItemList ColumnItems
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2191)]
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

  [DispId(2295)]
  string Dummy18
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2295)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(2193)]
  XlConsolidationFunction CustomSubtotalFunction
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2193)]
    get;
  }

  [DispId(2673)]
  PivotLine PivotRowLine
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2673)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2674)]
  PivotLine PivotColumnLine
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2674)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2928)]
  void AllocateChange();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2929)]
  void DiscardChange();

  [DispId(2930)]
  object DataSourceValue
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2930)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(2931)]
  XlCellChangedState CellChanged
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2931)]
    get;
  }

  [DispId(2123)]
  string MDX
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2123)]
    [return: MarshalAs(UnmanagedType.BStr)]
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
}