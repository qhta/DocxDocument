namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a shape range, which is a set of shapes on a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange?view=word-pia"/>
public partial interface ShapeRange : InteropObject, InteropCollection<Shape>
{
  /// <summary>
  /// Returns the adjustments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// Returns or sets the auto shape type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// Returns the callout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// Returns the connection site count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// Returns whether connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connector?view=word-pia"/>
  public Core.MsoTriState Connector { get; }

  /// <summary>
  /// Returns the connector format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// Returns the group items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// Returns or sets the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns whether horizontal flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.horizontalflip?view=word-pia"/>
  public Core.MsoTriState HorizontalFlip { get; }

  /// <summary>
  /// Returns or sets the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// Returns the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// Returns or sets whether lock aspect ratio.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockaspectratio?view=word-pia"/>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// Returns or sets the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns the nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// Returns or sets the rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// Returns the picture format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// Returns the shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// Returns the text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// Returns the text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// Returns the three d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Returns or sets the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.type?view=word-pia"/>
  public Core.MsoShapeType Type { get; }

  /// <summary>
  /// Returns whether vertical flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.verticalflip?view=word-pia"/>
  public Core.MsoTriState VerticalFlip { get; }

  /// <summary>
  /// Returns the vertices.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// Returns or sets whether visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns the z order position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// Returns the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// Returns or sets the relative horizontal position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalposition?view=word-pia"/>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Returns or sets the relative vertical position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalposition?view=word-pia"/>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Returns or sets the lock anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// Returns the wrap format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// Returns the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// Returns or sets the alternative text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// Returns whether diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagram?view=word-pia"/>
  public Core.MsoTriState HasDiagram { get; }

  /// <summary>
  /// Returns the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagram?view=word-pia"/>
  public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// Returns whether diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagramnode?view=word-pia"/>
  public Core.MsoTriState HasDiagramNode { get; }

  /// <summary>
  /// Returns the diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// Returns whether child.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.child?view=word-pia"/>
  public Core.MsoTriState Child { get; }

  /// <summary>
  /// Returns the parent group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// Returns the canvas items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// Returns the i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Sets the RTF.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// Returns or sets the layout in cell.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// Returns or sets the left relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// Returns or sets the top relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// Returns or sets the width relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// Returns or sets the height relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// Returns or sets the relative horizontal size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalsize?view=word-pia"/>
  public WdRelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// Returns or sets the relative vertical size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalsize?view=word-pia"/>
  public WdRelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// Returns the soft edge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// Returns the glow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// Returns the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// Returns the text frame2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// Returns or sets the shape style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shapestyle?view=word-pia"/>
  public Core.MsoShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// Returns or sets the background style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.backgroundstyle?view=word-pia"/>
  public Core.MsoBackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// Returns or sets the title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.title?view=word-pia"/>
  public string Title { get; set; }
}
