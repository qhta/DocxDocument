using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00024424-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface FormatConditions: IEnumerable
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

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(170)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(181)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Add
  ([In] XlFormatConditionType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Operator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Formula1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Formula2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object String,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextOperator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DateOperator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ScopeType);

  [IndexerName("_Default")]
  [DispId(0)]
  object this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  void Delete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2616)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddColorScale([In] int ColorScaleType);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2618)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddDatabar();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2619)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddIconSetCondition();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2620)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddTop10();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2621)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddAboveAverage();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2622)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AddUniqueValues();
}