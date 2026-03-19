using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C037A-0000-0000-C000-000000000046")]
public interface SharedWorkspaceTasks: _IMsoDispObj, IEnumerable
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

  [DispId(0)]
  SharedWorkspaceTask this[[In] int Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SharedWorkspaceTask Add
  ([In] [MarshalAs(UnmanagedType.BStr)] string Title, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Status,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Priority,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Assignee,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DueDate);

  [DispId(3)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(4)]
  bool ItemCountExceeded
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1024)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();
}