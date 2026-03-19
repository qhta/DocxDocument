using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CD706-0000-0000-C000-000000000046")]
[TypeLibType(256)]
[InterfaceType(1)]
public interface IDocumentInspector
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetInfo([MarshalAs(UnmanagedType.BStr)] out string Name, [MarshalAs(UnmanagedType.BStr)] out string Desc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Inspect
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Doc, out MsoDocInspectorStatus Status,
    [MarshalAs(UnmanagedType.BStr)] out string Result, [MarshalAs(UnmanagedType.BStr)] out string Action);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Fix
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Doc, [In] int hwnd, out MsoDocInspectorStatus Status,
    [MarshalAs(UnmanagedType.BStr)] out string Result);
}