using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0306-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface CommandBarControls: _IMsoDispObj, IEnumerable
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809344)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControl Add
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Id,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Parameter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Temporary);

  [DispId(1610809345)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    get;
  }

  [DispId(0)]
  CommandBarControl this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(1024)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [DispId(1610809348)]
  CommandBar Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}