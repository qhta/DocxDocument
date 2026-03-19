using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C1530-0000-0000-C000-000000000046")]
public interface OfficeDataSourceObject
{
  [DispId(1)]
  string ConnectString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2)]
  string Table
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(3)]
  string DataSource
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(4)]
  object Columns
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(5)]
  int RowCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    get;
  }

  [DispId(6)]
  object Filters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743817)]
  int Move([In] MsoMoveRow MsoMoveRow, [In] int RowNbr = 1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743818)]
  void Open
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrSrc = "",
    [In] [MarshalAs(UnmanagedType.BStr)] string bstrConnect = "",
    [In] [MarshalAs(UnmanagedType.BStr)] string bstrTable = "", [In] int fOpenExclusive = 0, [In] int fNeverPrompt = 1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743819)]
  void SetSortOrder
  ([In] [MarshalAs(UnmanagedType.BStr)] string SortField1, [In] bool SortAscending1 = true,
    [In] [MarshalAs(UnmanagedType.BStr)] string SortField2 = "", [In] bool SortAscending2 = true,
    [In] [MarshalAs(UnmanagedType.BStr)] string SortField3 = "", [In] bool SortAscending3 = true);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743820)]
  void ApplyFilter();
}