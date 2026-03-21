namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a shape range, which is a set of shapes on a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange?view=word-pia"/>
public partial interface ShapeRange : InteropObject, InteropCollection<Shape>
{
  /// <summary>
  /// The adjustments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// The auto shape type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// The callout.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// The connection site count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// The connector.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connector?view=word-pia"/>
  public Core.MsoTriState Connector { get; }

  /// <summary>
  /// The connector format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// The group items.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The horizontal flip.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.horizontalflip?view=word-pia"/>
  public Core.MsoTriState HorizontalFlip { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// The lock aspect ratio.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockaspectratio?view=word-pia"/>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The nodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// The rotation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// The picture format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// The text effect.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// The text frame.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// The three d.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.type?view=word-pia"/>
  public Core.MsoShapeType Type { get; }

  /// <summary>
  /// The vertical flip.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.verticalflip?view=word-pia"/>
  public Core.MsoTriState VerticalFlip { get; }

  /// <summary>
  /// The vertices.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The zorder position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// The hyperlink.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// The relative horizontal position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalposition?view=word-pia"/>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// The relative vertical position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalposition?view=word-pia"/>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// The lock anchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// The wrap format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// The anchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// The alternative text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// The has diagram.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagram?view=word-pia"/>
  public Core.MsoTriState HasDiagram { get; }

  /// <summary>
  /// The diagram.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagram?view=word-pia"/>
  public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// The has diagram node.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagramnode?view=word-pia"/>
  public Core.MsoTriState HasDiagramNode { get; }

  /// <summary>
  /// The diagram node.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// The child.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.child?view=word-pia"/>
  public Core.MsoTriState Child { get; }

  /// <summary>
  /// The parent group.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// The canvas items.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Sets the RTF.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// The layout in cell.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// The left relative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// The top relative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// The width relative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// The height relative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// The relative horizontal size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalsize?view=word-pia"/>
  public WdRelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// The relative vertical size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalsize?view=word-pia"/>
  public WdRelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// The soft edge.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// The glow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// The reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// The text frame2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// The shape style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shapestyle?view=word-pia"/>
  public Core.MsoShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// The background style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.backgroundstyle?view=word-pia"/>
  public Core.MsoBackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.title?view=word-pia"/>
  public string Title { get; set; }
}
