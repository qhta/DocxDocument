using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C03C0-0000-0000-C000-000000000046")]
public interface GradientStops: _IMsoDispObj, IEnumerable
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
  GradientStop this[[In] int Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void Delete([In] int Index = -1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void Insert
  ([In] [ComAliasName("Microsoft.Office.Core.MsoRGBType")] int RGB, [In] float Position, [In] float Transparency = 0f,
    [In] int Index = -1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  void Insert2
  ([In] [ComAliasName("Microsoft.Office.Core.MsoRGBType")] int RGB, [In] float Position, [In] float Transparency = 0f,
    [In] int Index = -1, [In] float Brightness = 0f);
}