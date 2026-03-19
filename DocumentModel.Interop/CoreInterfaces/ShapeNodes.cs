using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[DefaultMember("Item")]
[Guid("000C0319-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface ShapeNodes: _IMsoDispObj, IEnumerable
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

  [DispId(1)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
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
  [DispId(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeNode Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(1024)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void Delete([In] int Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  void Insert
  ([In] int Index, [In] MsoSegmentType SegmentType, [In] MsoEditingType EditingType, [In] float X1, [In] float Y1,
    [In] float X2 = 0f, [In] float Y2 = 0f, [In] float X3 = 0f, [In] float Y3 = 0f);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  void SetEditingType([In] int Index, [In] MsoEditingType EditingType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void SetPosition([In] int Index, [In] float X1, [In] float Y1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  void SetSegmentType([In] int Index, [In] MsoSegmentType SegmentType);
}