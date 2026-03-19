using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C1730-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface IMsoChartFormat
{
  [DispId(1610743808)]
  FillFormat Fill
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743809)]
  GlowFormat Glow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743810)]
  LineFormat Line
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743810)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743811)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743811)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743812)]
  PictureFormat PictureFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743812)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743813)]
  ShadowFormat Shadow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743813)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743814)]
  SoftEdgeFormat SoftEdge
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743814)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743815)]
  TextFrame2 TextFrame2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743815)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743816)]
  ThreeDFormat ThreeD
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(148)]
  object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(149)]
  int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(200)]
  Adjustments Adjustments
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(200)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(201)]
  MsoAutoShapeType AutoShapeType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(201)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(201)]
    [param: In]
    set;
  }
}