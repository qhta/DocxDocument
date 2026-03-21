namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an object in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or picture.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape?view=word-pia"/>
public partial interface Shape : InteropObject
{
  /// <summary>
  /// Returns the adjustments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// Returns or sets the auto shape type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// Returns the callout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// Returns the connection site count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// Returns whether connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connector?view=word-pia"/>
  public Core.MsoTriState Connector { get; }

  /// <summary>
  /// Returns the connector format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// Returns the group items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// Returns or sets the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns whether horizontal flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.horizontalflip?view=word-pia"/>
  public Core.MsoTriState HorizontalFlip { get; }

  /// <summary>
  /// Returns or sets the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// Returns the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// Returns or sets whether lock aspect ratio.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockaspectratio?view=word-pia"/>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// Returns or sets the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns the nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// Returns or sets the rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// Returns the picture format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// Returns the shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// Returns the text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// Returns the text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// Returns the three d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Returns or sets the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.type?view=word-pia"/>
  public Core.MsoShapeType Type { get; }

  /// <summary>
  /// Returns whether vertical flip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.verticalflip?view=word-pia"/>
  public Core.MsoTriState VerticalFlip { get; }

  /// <summary>
  /// Returns the vertices.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// Returns or sets whether visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns the z order position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// Returns the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// Returns or sets the relative horizontal position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalposition?view=word-pia"/>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Returns or sets the relative vertical position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalposition?view=word-pia"/>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Returns or sets the lock anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// Returns the wrap format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// Returns the o l e format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// Returns the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// Returns the link format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// Returns or sets the alternative text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// Returns the script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.script?view=word-pia"/>
  public Core.Script Script { get; }

  /// <summary>
  /// Returns whether diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagram?view=word-pia"/>
  public Core.MsoTriState HasDiagram { get; }

  /// <summary>
  /// Returns the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagram?view=word-pia"/>
  public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// Returns whether diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagramnode?view=word-pia"/>
  public Core.MsoTriState HasDiagramNode { get; }

  /// <summary>
  /// Returns the diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// Returns whether child.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.child?view=word-pia"/>
  public Core.MsoTriState Child { get; }

  /// <summary>
  /// Returns the parent group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// Returns the canvas items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// Returns the i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Sets the RTF.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// Returns or sets the layout in cell.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// Returns whether chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.haschart?view=word-pia"/>
  public Core.MsoTriState HasChart { get; }

  /// <summary>
  /// Returns the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.chart?view=word-pia"/>
  public Chart Chart { get; }

  /// <summary>
  /// Returns or sets the left relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// Returns or sets the top relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// Returns or sets the width relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// Returns or sets the height relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// Returns or sets the relative horizontal size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalsize?view=word-pia"/>
  public WdRelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// Returns or sets the relative vertical size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalsize?view=word-pia"/>
  public WdRelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// Returns the soft edge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// Returns the glow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// Returns the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// Returns the text frame2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// Returns whether smart art.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hassmartart?view=word-pia"/>
  public Core.MsoTriState HasSmartArt { get; }

  /// <summary>
  /// Returns the smart art.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.smartart?view=word-pia"/>
  public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// Returns or sets the shape style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shapestyle?view=word-pia"/>
  public Core.MsoShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// Returns or sets the background style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.backgroundstyle?view=word-pia"/>
  public Core.MsoBackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// Returns or sets the title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// Returns the anchor i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchorid?view=word-pia"/>
  public int AnchorID { get; }

  /// <summary>
  /// Returns the edit i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.editid?view=word-pia"/>
  public int EditID { get; }
}
