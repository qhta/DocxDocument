using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ShapeRange: InteropDictionary<string, Shape>
{
  public Adjustments Adjustments { get; }
  public MsoAutoShapeType AutoShapeType { get; set; }
  public MsoBlackWhiteMode BlackWhiteMode { get; set; }
  public CalloutFormat Callout { get; }
  public int ConnectionSiteCount { get; }
  public MsoTriState Connector { get; }
  public ConnectorFormat ConnectorFormat { get; }
  public FillFormat Fill { get; }
  public GroupShapes GroupItems { get; }
  public float Height { get; set; }
  public MsoTriState HorizontalFlip { get; }
  public float Left { get; set; }
  public LineFormat Line { get; }
  public MsoTriState LockAspectRatio { get; set; }
  public string Name { get; set; }
  public ShapeNodes Nodes { get; }
  public float Rotation { get; set; }
  public PictureFormat PictureFormat { get; }
  public ShadowFormat Shadow { get; }
  public TextEffectFormat TextEffect { get; }
  public TextFrame TextFrame { get; }
  public ThreeDFormat ThreeD { get; }
  public float Top { get; set; }
  public MsoShapeType Type { get; }
  public MsoTriState VerticalFlip { get; }
  public object Vertices { get; }
  public MsoTriState Visible { get; set; }
  public float Width { get; set; }
  public int ZOrderPosition { get; }
  public Script Script { get; }
  public string AlternativeText { get; set; }
  public MsoTriState HasDiagram { get; }
  public IMsoDiagram Diagram { get; }
  public MsoTriState HasDiagramNode { get; }
  public DiagramNode DiagramNode { get; }
  public MsoTriState Child { get; }
  public Shape ParentGroup { get; }
  public CanvasShapes CanvasItems { get; }
  public int Id { get; }
  public string RTF { set; }
  public TextFrame2 TextFrame2 { get; }
  public MsoTriState HasChart { get; }
  public IMsoChart Chart { get; }
  public MsoShapeStyleIndex ShapeStyle { get; set; }
  public MsoBackgroundStyleIndex BackgroundStyle { get; set; }
  public SoftEdgeFormat SoftEdge { get; }
  public GlowFormat Glow { get; }
  public ReflectionFormat Reflection { get; }
  public string Title { get; set; }
}
