using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000244B2-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface ChartFormat
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

  [DispId(1663)]
  FillFormat Fill
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1663)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2663)]
  GlowFormat Glow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2663)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(817)]
  LineFormat Line
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(817)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1631)]
  PictureFormat PictureFormat
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1631)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(103)]
  ShadowFormat Shadow
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2662)]
  SoftEdgeFormat SoftEdge
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2662)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2659)]
  TextFrame2 TextFrame2
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2659)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1703)]
  ThreeDFormat ThreeD
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1703)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1691)]
  Adjustments Adjustments
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1691)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1693)]
  MsoAutoShapeType AutoShapeType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1693)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1693)]
    [param: In]
    set;
  }
}