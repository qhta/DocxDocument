
namespace DocumentModel.Interop.Core;

public interface Shape: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void Apply();
  void Delete();
  Shape Duplicate();
  void Flip(MsoFlipCmd FlipCmd);
  void IncrementLeft(float Increment);
  void IncrementRotation(float Increment);
  void IncrementTop(float Increment);
  void PickUp();
  void RerouteConnections();

  void ScaleHeight
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);

  void ScaleWidth
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);

  void Select(object Replace);
  void SetShapesDefaultProperties();
  ShapeRange Ungroup();
  void ZOrder(MsoZOrderCmd ZOrderCmd);
  Adjustments Adjustments { get; }
  MsoAutoShapeType AutoShapeType { get; set; }
  MsoBlackWhiteMode BlackWhiteMode { get; set; }
  CalloutFormat Callout { get; }
  int ConnectionSiteCount { get; }
  MsoTriState Connector { get; }
  ConnectorFormat ConnectorFormat { get; }
  FillFormat Fill { get; }
  GroupShapes GroupItems { get; }
  float Height { get; set; }
  MsoTriState HorizontalFlip { get; }
  float Left { get; set; }
  LineFormat Line { get; }
  MsoTriState LockAspectRatio { get; set; }
  string Name { get; set; }
  ShapeNodes Nodes { get; }
  float Rotation { get; set; }
  PictureFormat PictureFormat { get; }
  ShadowFormat Shadow { get; }
  TextEffectFormat TextEffect { get; }
  TextFrame TextFrame { get; }
  ThreeDFormat ThreeD { get; }
  float Top { get; set; }
  MsoShapeType Type { get; }
  MsoTriState VerticalFlip { get; }
  object Vertices { get; }
  MsoTriState Visible { get; set; }
  float Width { get; set; }
  int ZOrderPosition { get; }
  Script Script { get; }
  string AlternativeText { get; set; }
  MsoTriState HasDiagram { get; }
  IMsoDiagram Diagram { get; }
  MsoTriState HasDiagramNode { get; }
  DiagramNode DiagramNode { get; }
  MsoTriState Child { get; }
  Shape ParentGroup { get; }
  CanvasShapes CanvasItems { get; }
  int Id { get; }
  void CanvasCropLeft(float Increment);
  void CanvasCropTop(float Increment);
  void CanvasCropRight(float Increment);
  void CanvasCropBottom(float Increment);
  string RTF { set; }
  TextFrame2 TextFrame2 { get; }
  void Cut();
  void Copy();
  MsoTriState HasChart { get; }
  IMsoChart Chart { get; }
  MsoShapeStyleIndex ShapeStyle { get; set; }
  MsoBackgroundStyleIndex BackgroundStyle { get; set; }
  SoftEdgeFormat SoftEdge { get; }
  GlowFormat Glow { get; }
  ReflectionFormat Reflection { get; }
  MsoTriState HasSmartArt { get; }
  SmartArt SmartArt { get; }
  void ConvertTextToSmartArt(SmartArtLayout Layout);
  string Title { get; set; }
}