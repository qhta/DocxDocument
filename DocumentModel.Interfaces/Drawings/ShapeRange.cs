using DocumentModel.Drawings.Diagrams;
using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Drawings;

using Range = System.Range;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a shape range, which is a set of shapes on a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange?view=word-pia"/>
public partial interface ShapeRange : IModelCollection<Shape>
{
  /// <summary>
  /// Returns a Adjustments object that contains adjustment values for all the adjustments in the specified
  /// ShapeRange object that represents an AutoShape or WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }

  /// <summary>
  /// Returns or sets the shape type for the specified ShapeRange object, which must represent an AutoShape other
  /// than a line or freeform drawing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.autoshapetype?view=word-pia"/>
  public Drw.AutoShapeType AutoShapeType { get; set; }

  /// <summary>
  /// Returns a CalloutFormat object that contains callout formatting properties for the specified ShapeRange object
  /// that represents callouts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.callout?view=word-pia"/>
  public CalloutFormat Callout { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectionsitecount?view=word-pia"/>
  public int ConnectionSiteCount { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connector?view=word-pia"/>
  public TriState Connector { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.connectorformat?view=word-pia"/>
  public ConnectorFormat ConnectorFormat { get; }

  /// <summary>
  /// Returns a FillFormat object that contains fill formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// Returns a GroupShapes object that represents the individual shapes in the specified ShapeRange object that
  /// represents grouped shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// Returns or sets the height of the specified object in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Indicates that a shape has been flipped horizontally.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.horizontalflip?view=word-pia"/>
  public TriState HorizontalFlip { get; }

  /// <summary>
  /// Returns or sets a Single that represents the horizontal position, measured in points, of the specified shape
  /// range. Can also be any valid ShapePosition constant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// Returns a LineFormat object that contains line formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// MsoTrue if the specified shape retains its original proportions when you resize it. MsoFalse if you can change
  /// the height and width of the shape independently of one another when you resize it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockaspectratio?view=word-pia"/>
  public TriState LockAspectRatio { get; set; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns a ShapeNodes collection that represents the geometric description of the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.nodes?view=word-pia"/>
  public ShapeNodes Nodes { get; }

  /// <summary>
  /// Returns or sets the number of degrees the specified shape is rotated around the z-axis. A positive value
  /// indicates clockwise rotation; a negative value indicates counterclockwise rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rotation?view=word-pia"/>
  public float Rotation { get; set; }

  /// <summary>
  /// Returns a PictureFormat object that contains picture formatting properties for the specified ShapeRange object
  /// that represents a picture or OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }

  /// <summary>
  /// Returns a ShadowFormat object that represents the shadow formatting for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// Returns a TextEffectFormat object that contains text-effect formatting properties for the specified ShapeRange
  /// object that represents WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; }

  /// <summary>
  /// Returns a TextFrame object that contains the text for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe?view=word-pia"/>
  public TextFrame TextFrame { get; }

  /// <summary>
  /// Returns a ThreeDFormat object that contains 3-D – effect formatting properties for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Returns or sets the vertical position of the specified shape range in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// Returns the shape type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.type?view=word-pia"/>
  public Drw.ShapeType Type { get; }

  /// <summary>
  /// True if the specified shape is flipped around the vertical axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.verticalflip?view=word-pia"/>
  public TriState VerticalFlip { get; }

  /// <summary>
  /// Returns the coordinates of the specified freeform drawing's vertices (and control points for Bézier curves) as
  /// a series of coordinate pairs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.vertices?view=word-pia"/>
  public object Vertices { get; }

  /// <summary>
  /// True if the specified object, or the formatting applied to it, is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.visible?view=word-pia"/>
  public TriState Visible { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns the position of the specified shape in the z-order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.zorderposition?view=word-pia"/>
  public int ZOrderPosition { get; }

  /// <summary>
  /// Returns a ShapePosition object that represents the hyperlink associated with the specified ShapeRange
  /// object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// Specifies to what the horizontal position of a shape range is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalposition?view=word-pia"/>
  public RelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Specifies to what the vertical position of a shape range is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalposition?view=word-pia"/>
  public RelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// True if the specified ShapeRange object's anchor is locked to the anchoring range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.lockanchor?view=word-pia"/>
  public int LockAnchor { get; set; }

  /// <summary>
  /// Returns a WrapFormat object that contains the properties for wrapping text around the specified shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.wrapformat?view=word-pia"/>
  public WrapFormat WrapFormat { get; }

  /// <summary>
  /// Returns a Range object that represents the anchoring range for the specified shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.anchor?view=word-pia"/>
  public Range Anchor { get; }

  /// <summary>
  /// Returns or sets the alternative text associated with a shape in a Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// MsoTrue if a shape is a diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagram?view=word-pia"/>
  public TriState HasDiagram { get; }

  /// <summary>
  /// Returns a Diagram object to which a diagram node belongs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagram?view=word-pia"/>
  public Diagram Diagram { get; }

  /// <summary>
  /// MsoTrue if a shape is a diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.hasdiagramnode?view=word-pia"/>
  public TriState HasDiagramNode { get; }

  /// <summary>
  /// Returns a DiagramNode object that represents a node in a diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.diagramnode?view=word-pia"/>
  public DiagramNode DiagramNode { get; }

  /// <summary>
  /// True if all shapes in a shape range are child shapes of the same parent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.child?view=word-pia"/>
  public TriState Child { get; }

  /// <summary>
  /// Returns a Shape object that represents the common parent shape of a range of child shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.parentgroup?view=word-pia"/>
  public Shape ParentGroup { get; }

  /// <summary>
  /// Returns a CanvasShapes object that represents a collection of shapes in a drawing canvas.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.canvasitems?view=word-pia"/>
  public CanvasShapes CanvasItems { get; }

  /// <summary>
  /// Returns the type for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.id?view=word-pia"/>
  public int ID { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.rtf?view=word-pia"/>
  public string RTF { set; }

  /// <summary>
  /// Returns an Integer that represents whether a shape in a table is displayed inside the table or outside of the
  /// table. True indicates that a specified picture is displayed within the table. False indicates that a specified
  /// picture is displayed outside of the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.layoutincell?view=word-pia"/>
  public int LayoutInCell { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the relative left position of a range of shapes. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.leftrelative?view=word-pia"/>
  public float LeftRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the relative top position of a range of shapes. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.toprelative?view=word-pia"/>
  public float TopRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the relative width of a range of shapes. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.widthrelative?view=word-pia"/>
  public float WidthRelative { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the percentage of the target shape to which the range of shapes is
  /// sized. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.heightrelative?view=word-pia"/>
  public float HeightRelative { get; set; }

  /// <summary>
  /// Returns or sets a RelativeHorizontalSize constant that represents the object to which a range of shapes is
  /// relative. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativehorizontalsize?view=word-pia"/>
  public RelativeHorizontalSize RelativeHorizontalSize { get; set; }

  /// <summary>
  /// Returns or sets a RelativeVerticalSize constant that represents the object to which a range of shapes is
  /// relative. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.relativeverticalsize?view=word-pia"/>
  public RelativeVerticalSize RelativeVerticalSize { get; set; }

  /// <summary>
  /// Returns a SoftEdgeFormat object that represents the soft edge formatting for a range of shapes. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// Returns a GlowFormat object that represents the glow formatting for a range of shapes. Read- only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// Returns a ReflectionFormat object that represents the reflection formatting for a range of shapes. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// Returns a TextFrame2 object that contains the text for the specified range of shapes. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.textframe2?view=word-pia"/>
  public Drw.TextFrame TextFrame2 { get; }

  /// <summary>
  /// Gets or sets the shape style for the shapes in the specified shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.shapestyle?view=word-pia"/>
  public Drw.ShapeStyleIndex ShapeStyle { get; set; }

  /// <summary>
  /// Gets or sets the background style of the shapes in the specified shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.backgroundstyle?view=word-pia"/>
  public Drw.BackgroundStyleIndex BackgroundStyle { get; set; }

  /// <summary>
  /// Gets or sets a string that contains a title for the shapes in the specified shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.title?view=word-pia"/>
  public string Title { get; set; }
}
