using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C170A-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
public interface SeriesCollection: IEnumerable
{
  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries Add
  ([In] [MarshalAs(UnmanagedType.Struct)] object Source, [In] XlRowCol Rowcol = XlRowCol.xlColumns,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SeriesLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Extend
  ([In] [MarshalAs(UnmanagedType.Struct)] object Source,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Rowcol,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1024)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Paste
  ([In] XlRowCol Rowcol = XlRowCol.xlColumns, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SeriesLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NewSeries);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries NewSeries();

  [DispId(148)]
  object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(149)]
  int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [IndexerName("_Default")]
  [DispId(0)]
  IMsoSeries this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1024)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}