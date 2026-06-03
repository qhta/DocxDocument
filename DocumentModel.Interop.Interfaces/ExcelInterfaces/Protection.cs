using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00024467-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface Protection
{
  [DispId(2032)]
  bool AllowFormattingCells
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2032)]
    get;
  }

  [DispId(2033)]
  bool AllowFormattingColumns
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2033)]
    get;
  }

  [DispId(2034)]
  bool AllowFormattingRows
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2034)]
    get;
  }

  [DispId(2035)]
  bool AllowInsertingColumns
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2035)]
    get;
  }

  [DispId(2036)]
  bool AllowInsertingRows
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2036)]
    get;
  }

  [DispId(2037)]
  bool AllowInsertingHyperlinks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2037)]
    get;
  }

  [DispId(2038)]
  bool AllowDeletingColumns
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2038)]
    get;
  }

  [DispId(2039)]
  bool AllowDeletingRows
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2039)]
    get;
  }

  [DispId(2040)]
  bool AllowSorting
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2040)]
    get;
  }

  [DispId(2041)]
  bool AllowFiltering
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2041)]
    get;
  }

  [DispId(2042)]
  bool AllowUsingPivotTables
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2042)]
    get;
  }

  [DispId(2236)]
  AllowEditRanges AllowEditRanges
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2236)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}