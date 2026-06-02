namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an object in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or
/// picture.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape?view=word-pia"/>
public partial interface IShape : IInteropObject
{
  /// <summary>
  /// Returns a Adjustments object that contains adjustment values for all the adjustments in the specified Shape
  /// object that represents an AutoShape or WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// Returns or sets the shape type for the specified Shape object, which must represent an AutoShape other than a
  /// line or freeform drawing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.autoshapetype?view=word-pia"/>
  public Core.AutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// Returns a CalloutFormat object that contains callout formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connector?view=word-pia"/>
  public Core.TriState Connector { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// Returns a FillFormat object that contains fill formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// Returns a GroupShapes object that represents the individual shapes in the specified group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// Returns or sets the height of the specified shape in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Indicates that a shape has been flipped horizontally.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.horizontalflip?view=word-pia"/>
  public Core.TriState HorizontalFlip { get; }

  /// <summary>
  /// Returns or sets a Single that represents the horizontal position, measured in points, of the specified shape
  /// or shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// Returns a LineFormat object that contains line formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// Determines if you can change the height and width of the shape independently of one another when you resize it
  /// or if it retains its original proportions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockaspectratio?view=word-pia"/>
  public Core.TriState LockAspectRatio { get; set; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns a ShapeNodes collection that represents the geometric description of the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// Returns or sets the number of degrees the specified shape is rotated around the z-axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// Returns a PictureFormat object that contains picture formatting properties for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// Returns a ShadowFormat object that represents the shadow formatting for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// Returns a TextEffectFormat object that contains text-effect formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// Returns a TextFrame object that contains the text for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// Returns a ThreeDFormat object that contains formatting properties of the three-dimensional effect for the
  /// specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Returns or sets the vertical position of the specified shape in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// Returns the shape type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.type?view=word-pia"/>
  public Core.ShapeType Type { get; }

  /// <summary>
  /// Determines if the specified shape is flipped around the vertical axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.verticalflip?view=word-pia"/>
  public Core.TriState VerticalFlip { get; }

  /// <summary>
  /// Returns the coordinates of the specified freeform drawing's vertices (and control points for Bézier curves) as
  /// a series of coordinate pairs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// Determines if the specified object, or the formatting applied to it, is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.visible?view=word-pia"/>
  public Core.TriState Visible { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns the position of the specified shape in the z-order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// Returns a Hyperlink object that represents the hyperlink associated with the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// Specifies to what the horizontal position of a shape is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalposition?view=word-pia"/>
  public RelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Specifies to what the vertical position of a shape is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalposition?view=word-pia"/>
  public RelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Determines if the specified Shape object's anchor is locked to the anchoring range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// Returns a WrapFormat object that contains the properties for wrapping text around the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// Returns a OLEFormat object that represents the OLE characteristics (other than linking) for the specified
  /// shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// Returns a Range object that represents the anchoring range for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// Returns a LinkFormat object that represents the link options of the specified shape that's linked to a file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// Returns or sets the alternative text associated with a shape in a Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// Returns a Script object, which represents a block of script or code on the specified Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.script?view=word-pia"/>
  public Core.Script Script { get; }

  /// <summary>
  /// Determines if a shape is a diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagram?view=word-pia"/>
  public Core.TriState HasDiagram { get; }

  /// <summary>
  /// Returns a Diagram object to which a diagram node belongs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagram?view=word-pia"/>
  public Core.IMsoDiagram Diagram { get; }

  /// <summary>
  /// Determines if a shape is a diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hasdiagramnode?view=word-pia"/>
  public Core.TriState HasDiagramNode { get; }

  /// <summary>
  /// Returns a DiagramNode object that represents a node in a diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// Determines if the shape is a child shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.child?view=word-pia"/>
  public Core.TriState Child { get; }

  /// <summary>
  /// Returns a Shape object that represents the common parent shape of a child shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// Returns a CanvasShapes object that represents a collection of shapes in a drawing canvas.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// Returns the type for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// Returns an Integer that represents whether a shape in a table is displayed inside the table or outside of the
  /// table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// True if the specified shape has a chart. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.haschart?view=word-pia"/>
  public Core.TriState HasChart { get; }

  /// <summary>
  /// Returns a Chart object that represents a chart within the collection of shapes in a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.chart?view=word-pia"/>
  public Chart Chart { get; }

  /// <summary>
  /// Returns or sets a Single that represents the relative left position of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the relative top position of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the relative width of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the percentage of the relative height of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// Returns or sets a RelativeHorizontalSize constant that represents the object to which a range of shapes is
  /// relative. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativehorizontalsize?view=word-pia"/>
  public RelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// Returns or sets a RelativeVerticalSize constant that represents the relative vertical size of a shape.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.relativeverticalsize?view=word-pia"/>
  public RelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// Returns a SoftEdgeFormat object that represents the soft edge formatting for a shape. Read- only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// Returns a GlowFormat object that represents the glow formatting for a shape. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// Returns a ReflectionFormat object that represents the reflection formatting for a shape. Read- only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// Returns a TextFrame2 object that contains the text for the specified shape. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }

  /// <summary>
  /// Gets True if there is a SmartArt diagram present on the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.hassmartart?view=word-pia"/>
  public Core.TriState HasSmartArt { get; }

  /// <summary>
  /// Gets a SmartArt object that provides a way to work with the SmartArt associated with the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.smartart?view=word-pia"/>
  public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// Gets or sets the shape style for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.shapestyle?view=word-pia"/>
  public Core.ShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// Gets or sets the background style of the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.backgroundstyle?view=word-pia"/>
  public Core.BackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// Gets or sets a string that contains a title for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// Returns a Range object that represents the anchoring range for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.anchorid?view=word-pia"/>
  public int AnchorID { get; }

  /// <summary>
  /// Returns a DiagramNode object that represents a node in a diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.editid?view=word-pia"/>
  public int EditID { get; }


  #region methods

/// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.apply?view=word-pia"/>
  public void Apply();

  #endregion methods
}
