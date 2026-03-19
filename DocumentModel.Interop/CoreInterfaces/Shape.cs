using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C031C-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface Shape: _IMsoDispObj
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void Apply();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape Duplicate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  void Flip([In] MsoFlipCmd FlipCmd);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void IncrementLeft([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  void IncrementRotation([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void IncrementTop([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  void PickUp();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  void RerouteConnections();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(19)]
  void ScaleHeight
  ([In] float Factor, [In] MsoTriState RelativeToOriginalSize,
    [In] MsoScaleFrom fScale = MsoScaleFrom.msoScaleFromTopLeft);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(20)]
  void ScaleWidth
  ([In] float Factor, [In] MsoTriState RelativeToOriginalSize,
    [In] MsoScaleFrom fScale = MsoScaleFrom.msoScaleFromTopLeft);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(21)]
  void Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(22)]
  void SetShapesDefaultProperties();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(23)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeRange Ungroup();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(24)]
  void ZOrder([In] MsoZOrderCmd ZOrderCmd);

  [DispId(100)]
  Adjustments Adjustments
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(100)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(101)]
  MsoAutoShapeType AutoShapeType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    [param: In]
    set;
  }

  [DispId(102)]
  MsoBlackWhiteMode BlackWhiteMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    [param: In]
    set;
  }

  [DispId(103)]
  CalloutFormat Callout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(104)]
  int ConnectionSiteCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(104)]
    get;
  }

  [DispId(105)]
  MsoTriState Connector
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(105)]
    get;
  }

  [DispId(106)]
  ConnectorFormat ConnectorFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(106)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(107)]
  FillFormat Fill
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(107)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(108)]
  GroupShapes GroupItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(109)]
  float Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(109)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(109)]
    [param: In]
    set;
  }

  [DispId(110)]
  MsoTriState HorizontalFlip
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    get;
  }

  [DispId(111)]
  float Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(111)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(111)]
    [param: In]
    set;
  }

  [DispId(112)]
  LineFormat Line
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(112)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(113)]
  MsoTriState LockAspectRatio
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(113)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(113)]
    [param: In]
    set;
  }

  [DispId(115)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(115)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(115)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(116)]
  ShapeNodes Nodes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(116)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(117)]
  float Rotation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(117)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(117)]
    [param: In]
    set;
  }

  [DispId(118)]
  PictureFormat PictureFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(119)]
  ShadowFormat Shadow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(119)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(120)]
  TextEffectFormat TextEffect
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(120)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(121)]
  TextFrame TextFrame
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(121)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(122)]
  ThreeDFormat ThreeD
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(123)]
  float Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(123)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(123)]
    [param: In]
    set;
  }

  [DispId(124)]
  MsoShapeType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(124)]
    get;
  }

  [DispId(125)]
  MsoTriState VerticalFlip
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(125)]
    get;
  }

  [DispId(126)]
  object Vertices
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(126)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(127)]
  MsoTriState Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(127)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(127)]
    [param: In]
    set;
  }

  [DispId(128)]
  float Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(128)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(128)]
    [param: In]
    set;
  }

  [DispId(129)]
  int ZOrderPosition
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(129)]
    get;
  }

  [DispId(130)]
  Script Script
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(130)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(131)]
  string AlternativeText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(131)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(131)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(132)]
  MsoTriState HasDiagram
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(132)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(133)]
  IMsoDiagram Diagram
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(133)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(134)]
  MsoTriState HasDiagramNode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(134)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(135)]
  DiagramNode DiagramNode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(135)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(136)]
  MsoTriState Child
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(136)]
    get;
  }

  [DispId(137)]
  Shape ParentGroup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(137)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(138)]
  CanvasShapes CanvasItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(138)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(139)]
  int Id
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(139)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(140)]
  void CanvasCropLeft([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(141)]
  void CanvasCropTop([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(142)]
  void CanvasCropRight([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(143)]
  [TypeLibFunc(64)]
  void CanvasCropBottom([In] float Increment);

  [DispId(144)]
  string RTF
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(144)]
    [TypeLibFunc(64)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(145)]
  TextFrame2 TextFrame2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(145)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(146)]
  void Cut();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(147)]
  void Copy();

  [DispId(148)]
  MsoTriState HasChart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    get;
  }

  [DispId(149)]
  IMsoChart Chart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(150)]
  MsoShapeStyleIndex ShapeStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [param: In]
    set;
  }

  [DispId(151)]
  MsoBackgroundStyleIndex BackgroundStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(151)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(151)]
    [param: In]
    set;
  }

  [DispId(152)]
  SoftEdgeFormat SoftEdge
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(152)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(153)]
  GlowFormat Glow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(153)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(154)]
  ReflectionFormat Reflection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(154)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(155)]
  MsoTriState HasSmartArt
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(155)]
    get;
  }

  [DispId(156)]
  SmartArt SmartArt
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(156)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(157)]
  void ConvertTextToSmartArt([In] [MarshalAs(UnmanagedType.Interface)] SmartArtLayout Layout);

  [DispId(158)]
  string Title
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(158)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(158)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }
}