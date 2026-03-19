using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C035A-0000-0000-C000-000000000046")]
public interface MsoDebugOptions: _IMsoDispObj
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

  [DispId(4)]
  int FeatureReports
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(4)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(4)]
    [param: In]
    set;
  }

  [DispId(5)]
  bool OutputToDebugger
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    [param: In]
    set;
  }

  [DispId(6)]
  bool OutputToFile
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [param: In]
    set;
  }

  [DispId(7)]
  bool OutputToMessageBox
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(7)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(7)]
    [param: In]
    set;
  }

  [DispId(8)]
  object UnitTestManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(8)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(9)]
  void AddIgnoredAssertTag([In] [MarshalAs(UnmanagedType.BStr)] string bstrTagToIgnore);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void RemoveIgnoredAssertTag([In] [MarshalAs(UnmanagedType.BStr)] string bstrTagToIgnore);
}