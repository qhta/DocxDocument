using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C03D2-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface PictureEffects: _IMsoDispObj, IEnumerable
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
  PictureEffect this[[In] int Index]
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
  [DispId(-4)]
  [TypeLibFunc(1024)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PictureEffect Insert([In] MsoPictureEffectType EffectType, [In] int Position = -1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void Delete([In] int Index = -1);
}