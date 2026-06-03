using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000208B8-0000-0000-C000-000000000046")]
[DefaultMember("_Default")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface Names: IEnumerable
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
  Name Add
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersTo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Visible,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MacroType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShortcutKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Category,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NameLocal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersToLocal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CategoryLocal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersToR1C1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersToR1C1Local);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(170)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name Item
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IndexLocal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersTo);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name _Default
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IndexLocal,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RefersTo);

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();
}