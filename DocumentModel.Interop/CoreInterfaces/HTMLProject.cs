using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[DefaultMember("State")]
[Guid("000C0356-0000-0000-C000-000000000046")]
public interface HTMLProject: _IMsoDispObj
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
  MsoHTMLProjectState State
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void RefreshProject([In] bool Refresh = true);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void RefreshDocument([In] bool Refresh = true);

  [DispId(3)]
  HTMLProjectItems HTMLProjectItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(4)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  void Open([In] MsoHTMLProjectOpen OpenKind = (MsoHTMLProjectOpen)0);
}