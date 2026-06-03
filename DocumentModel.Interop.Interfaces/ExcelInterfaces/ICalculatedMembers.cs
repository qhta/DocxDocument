using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("00024454-0001-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
public interface ICalculatedMembers: IEnumerable
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

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(170)]
  CalculatedMember Item
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [IndexerName("_Default")]
  [DispId(0)]
  CalculatedMember this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CalculatedMember Add
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Formula,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SolveOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CalculatedMember Add2
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object Formula,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SolveOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Dynamic,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayFolder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HierarchizeDistinct);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CalculatedMember AddCalculatedMember
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object Formula,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SolveOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayFolder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MeasureGroup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ParentHierarchy,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ParentMember,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NumberFormat);
}