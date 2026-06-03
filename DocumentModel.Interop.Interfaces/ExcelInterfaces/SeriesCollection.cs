using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("0002086C-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[DefaultMember("_Default")]
public interface SeriesCollection: IEnumerable
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

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(181)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series Add
  ([In] [MarshalAs(UnmanagedType.Struct)] object Source, [In] XlRowCol Rowcol = (XlRowCol)(-4105),
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SeriesLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(227)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Extend
  ([In] [MarshalAs(UnmanagedType.Struct)] object Source,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Rowcol,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(170)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(211)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Paste
  ([In] XlRowCol Rowcol = (XlRowCol)(-4105), [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SeriesLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLabels,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NewSeries);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1117)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series NewSeries();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series _Default([In] [MarshalAs(UnmanagedType.Struct)] object Index);
}