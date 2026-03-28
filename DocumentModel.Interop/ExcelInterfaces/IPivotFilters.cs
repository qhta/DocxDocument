using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024484-0001-0000-C000-000000000046")]
public interface IPivotFilters: IEnumerable
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [IndexerName("_Default")]
  [DispId(0)]
  PivotFilter this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [DispId(170)]
  PivotFilter Item
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotFilter Add
  ([In] XlPivotFilterType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataField,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Value1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Value2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Order,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MemberPropertyField);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotFilter Add2
  ([In] XlPivotFilterType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataField,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Value1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Value2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Order,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MemberPropertyField,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WholeDayFilter);
}