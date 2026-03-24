using System.Collections;
using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange?view=office-pia"/>
public partial interface ShapeRange: InteropCollection<Shape>
{
  /// <summary>
  /// Gets or sets the `Adjustments` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.adjustments?view=office-pia"/>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.autoshapetype?view=office-pia"/>
  public MsoAutoShapeType AutoShapeType { get; set; }
  /// <summary>
  /// Gets or sets the `BlackWhiteMode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.blackwhitemode?view=office-pia"/>
  public MsoBlackWhiteMode BlackWhiteMode { get; set; }
  /// <summary>
  /// Gets the `Callout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.callout?view=office-pia"/>
  public CalloutFormat Callout { get; }
  /// <summary>
  /// Gets the `ConnectionSiteCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectionsitecount?view=office-pia"/>
  public int ConnectionSiteCount { get; }
  /// <summary>
  /// Gets the `Connector` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connector?view=office-pia"/>
  public MsoTriState Connector { get; }
  /// <summary>
  /// Gets the `ConnectorFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectorformat?view=office-pia"/>
  public ConnectorFormat ConnectorFormat { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.fill?view=office-pia"/>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `GroupItems` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.groupitems?view=office-pia"/>
  public GroupShapes GroupItems { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.height?view=office-pia"/>
  public float Height { get; set; }
  /// <summary>
  /// Gets the `HorizontalFlip` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.horizontalflip?view=office-pia"/>
  public MsoTriState HorizontalFlip { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.left?view=office-pia"/>
  public float Left { get; set; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.line?view=office-pia"/>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets or sets the `LockAspectRatio` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.lockaspectratio?view=office-pia"/>
  public MsoTriState LockAspectRatio { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.nodes?view=office-pia"/>
  public ShapeNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rotation?view=office-pia"/>
  public float Rotation { get; set; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pictureformat?view=office-pia"/>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shadow?view=office-pia"/>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `TextEffect` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.texteffect?view=office-pia"/>
  public TextEffectFormat TextEffect { get; }
  /// <summary>
  /// Gets the `TextFrame` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.textframe?view=office-pia"/>
  public TextFrame TextFrame { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.threed?view=office-pia"/>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.top?view=office-pia"/>
  public float Top { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.type?view=office-pia"/>
  public MsoShapeType Type { get; }
  /// <summary>
  /// Gets the `VerticalFlip` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.verticalflip?view=office-pia"/>
  public MsoTriState VerticalFlip { get; }
  /// <summary>
  /// Gets the `Vertices` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.vertices?view=office-pia"/>
  public object Vertices { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.visible?view=office-pia"/>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.width?view=office-pia"/>
  public float Width { get; set; }
  /// <summary>
  /// Gets the `ZOrderPosition` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.zorderposition?view=office-pia"/>
  public int ZOrderPosition { get; }
  /// <summary>
  /// Gets the `Script` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.script?view=office-pia"/>
  public Script Script { get; }
  /// <summary>
  /// Gets or sets the `AlternativeText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.alternativetext?view=office-pia"/>
  public string AlternativeText { get; set; }
  /// <summary>
  /// Gets the `HasDiagram` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagram?view=office-pia"/>
  public MsoTriState HasDiagram { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagram?view=office-pia"/>
  public IMsoDiagram Diagram { get; }
  /// <summary>
  /// Gets the `HasDiagramNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagramnode?view=office-pia"/>
  public MsoTriState HasDiagramNode { get; }
  /// <summary>
  /// Gets the `DiagramNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagramnode?view=office-pia"/>
  public DiagramNode DiagramNode { get; }
  /// <summary>
  /// Gets the `Child` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.child?view=office-pia"/>
  public MsoTriState Child { get; }
  /// <summary>
  /// Gets the `ParentGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.parentgroup?view=office-pia"/>
  public Shape ParentGroup { get; }
  /// <summary>
  /// Gets the `CanvasItems` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvasitems?view=office-pia"/>
  public CanvasShapes CanvasItems { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.id?view=office-pia"/>
  public int Id { get; }
  /// <summary>
  /// Sets the rich text format (RTF) content for the shape range text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rtf?view=office-pia"/>
  public string RTF { set; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.textframe2?view=office-pia"/>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `HasChart` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.haschart?view=office-pia"/>
  public MsoTriState HasChart { get; }
  /// <summary>
  /// Gets the `Chart` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.chart?view=office-pia"/>
  public IMsoChart Chart { get; }
  /// <summary>
  /// Gets or sets the `ShapeStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shapestyle?view=office-pia"/>
  public MsoShapeStyleIndex ShapeStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BackgroundStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.backgroundstyle?view=office-pia"/>
  public MsoBackgroundStyleIndex BackgroundStyle { get; set; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.softedge?view=office-pia"/>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.glow?view=office-pia"/>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.reflection?view=office-pia"/>
  public ReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.title?view=office-pia"/>
  public string Title { get; set; }
}

