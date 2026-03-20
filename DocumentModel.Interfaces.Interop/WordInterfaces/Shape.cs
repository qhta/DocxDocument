namespace DocumentModel.Interop;

/// <summary>
/// Represents an object in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or picture.
/// </summary>
public partial interface Shape : InteropObject
{
  /// <summary>
  /// The adjustments.
  /// </summary>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// The auto shape type.
  /// </summary>
  //public Core.MsoAutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// The callout.
  /// </summary>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// The connection site count.
  /// </summary>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// The connector.
  /// </summary>
  //public Core.MsoTriState Connector { get; }

  /// <summary>
  /// The connector format.
  /// </summary>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public FillFormat Fill { get; }

  /// <summary>
  /// The group items.
  /// </summary>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The horizontal flip.
  /// </summary>
  //public Core.MsoTriState HorizontalFlip { get; }

  /// <summary>
  /// The left.
  /// </summary>
  public float Left { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  public LineFormat Line { get; }

  /// <summary>
  /// The lock aspect ratio.
  /// </summary>
  //public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The nodes.
  /// </summary>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// The rotation.
  /// </summary>
  public float Rotation { get; set; }

  /// <summary>
  /// The picture format.
  /// </summary>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// The text effect.
  /// </summary>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// The text frame.
  /// </summary>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// The three d.
  /// </summary>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// The top.
  /// </summary>
  public float Top { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoShapeType Type { get; }

  /// <summary>
  /// The vertical flip.
  /// </summary>
  //public Core.MsoTriState VerticalFlip { get; }

  /// <summary>
  /// The vertices.
  /// </summary>
  public object Vertices { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  //public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The zorder position.
  /// </summary>
  public int ZOrderPosition { get; }

  /// <summary>
  /// The hyperlink.
  /// </summary>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// The relative horizontal position.
  /// </summary>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// The relative vertical position.
  /// </summary>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// The lock anchor.
  /// </summary>
  public int LockAnchor { get; set; }

  /// <summary>
  /// The wrap format.
  /// </summary>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The anchor.
  /// </summary>
  public Range Anchor { get; }

  /// <summary>
  /// The link format.
  /// </summary>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The alternative text.
  /// </summary>
  public string AlternativeText { get; set; }

  /// <summary>
  /// The script.
  /// </summary>
  //public Core.Script Script { get; }

  /// <summary>
  /// The has diagram.
  /// </summary>
  //public Core.MsoTriState HasDiagram { get; }

  /// <summary>
  /// The diagram.
  /// </summary>
  //public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// The has diagram node.
  /// </summary>
  //public Core.MsoTriState HasDiagramNode { get; }

  /// <summary>
  /// The diagram node.
  /// </summary>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// The child.
  /// </summary>
  //public Core.MsoTriState Child { get; }

  /// <summary>
  /// The parent group.
  /// </summary>
  public Shape ParentGroup { get; }

  /// <summary>
  /// The canvas items.
  /// </summary>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// The id.
  /// </summary>
  public int ID { get; }

  /// <summary>
  /// Sets the RTF.
  /// </summary>
  public string RTF { set; }

  /// <summary>
  /// The layout in cell.
  /// </summary>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// The has chart.
  /// </summary>
  //public Core.MsoTriState HasChart { get; }

  /// <summary>
  /// The chart.
  /// </summary>
  public Chart Chart { get; }

  /// <summary>
  /// The left relative.
  /// </summary>
  public float LeftRelative { get; set; }

  /// <summary>
  /// The top relative.
  /// </summary>
  public float TopRelative { get; set; }

  /// <summary>
  /// The width relative.
  /// </summary>
  public float WidthRelative { get; set; }

  /// <summary>
  /// The height relative.
  /// </summary>
  public float HeightRelative { get; set; }

  /// <summary>
  /// The relative horizontal size.
  /// </summary>
  public WdRelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// The relative vertical size.
  /// </summary>
  public WdRelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// The soft edge.
  /// </summary>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// The glow.
  /// </summary>
  public GlowFormat Glow { get; }

  /// <summary>
  /// The reflection.
  /// </summary>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// The text frame2.
  /// </summary>
  //public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// The has smart art.
  /// </summary>
  //public Core.MsoTriState HasSmartArt { get; }

  /// <summary>
  /// The smart art.
  /// </summary>
  //public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// The shape style.
  /// </summary>
  //public Core.MsoShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// The background style.
  /// </summary>
  //public Core.MsoBackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  public string Title { get; set; }

  /// <summary>
  /// The anchor id.
  /// </summary>
  public int AnchorID { get; }

  /// <summary>
  /// The edit id.
  /// </summary>
  public int EditID { get; }
}
