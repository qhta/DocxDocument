namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an object in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or picture.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape?view=word-pia"/>
public partial interface Shape : InteropObject
{
  /// <summary>
  /// The adjustments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// The auto shape type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// The callout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// The connection site count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// The connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connector?view=word-pia"/>
  public Core.MsoTriState Connector { get; }

  /// <summary>
  /// The connector format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// The group items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The horizontal flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.horizontalflip?view=word-pia"/>
  public Core.MsoTriState HorizontalFlip { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// The lock aspect ratio.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockaspectratio?view=word-pia"/>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// The rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// The picture format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// The text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// The text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// The three d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.type?view=word-pia"/>
  public Core.MsoShapeType Type { get; }

  /// <summary>
  /// The vertical flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.verticalflip?view=word-pia"/>
  public Core.MsoTriState VerticalFlip { get; }

  /// <summary>
  /// The vertices.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The zorder position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// The hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// The relative horizontal position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalposition?view=word-pia"/>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// The relative vertical position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalposition?view=word-pia"/>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// The lock anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// The wrap format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// The link format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The alternative text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// The script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.script?view=word-pia"/>
  public Core.Script Script { get; }

  /// <summary>
  /// The has diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagram?view=word-pia"/>
  public Core.MsoTriState HasDiagram { get; }

  /// <summary>
  /// The diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagram?view=word-pia"/>
  public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// The has diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagramnode?view=word-pia"/>
  public Core.MsoTriState HasDiagramNode { get; }

  /// <summary>
  /// The diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// The child.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.child?view=word-pia"/>
  public Core.MsoTriState Child { get; }

  /// <summary>
  /// The parent group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// The canvas items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Sets the RTF.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// The layout in cell.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// The has chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.haschart?view=word-pia"/>
  public Core.MsoTriState HasChart { get; }

  /// <summary>
  /// The chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.chart?view=word-pia"/>
  public Chart Chart { get; }

  /// <summary>
  /// The left relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// The top relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// The width relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// The height relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// The relative horizontal size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalsize?view=word-pia"/>
  public WdRelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// The relative vertical size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalsize?view=word-pia"/>
  public WdRelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// The soft edge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// The glow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// The reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// The text frame2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// The has smart art.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hassmartart?view=word-pia"/>
  public Core.MsoTriState HasSmartArt { get; }

  /// <summary>
  /// The smart art.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.smartart?view=word-pia"/>
  public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// The shape style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shapestyle?view=word-pia"/>
  public Core.MsoShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// The background style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.backgroundstyle?view=word-pia"/>
  public Core.MsoBackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// The anchor id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchorid?view=word-pia"/>
  public int AnchorID { get; }

  /// <summary>
  /// The edit id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.editid?view=word-pia"/>
  public int EditID { get; }
}
