using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ShapeRange` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ShapeRange: InteropDictionary<string, Shape>
{
  /// <summary>
  /// Gets or sets the `Adjustments` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.adjustments?view=office-pia
  /// </remarks>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.autoshapetype?view=office-pia
  /// </remarks>
  public MsoAutoShapeType AutoShapeType { get; set; }
  /// <summary>
  /// Gets or sets the `BlackWhiteMode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.blackwhitemode?view=office-pia
  /// </remarks>
  public MsoBlackWhiteMode BlackWhiteMode { get; set; }
  /// <summary>
  /// Gets the `Callout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.callout?view=office-pia
  /// </remarks>
  public CalloutFormat Callout { get; }
  /// <summary>
  /// Gets the `ConnectionSiteCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectionsitecount?view=office-pia
  /// </remarks>
  public int ConnectionSiteCount { get; }
  /// <summary>
  /// Gets the `Connector` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connector?view=office-pia
  /// </remarks>
  public MsoTriState Connector { get; }
  /// <summary>
  /// Gets the `ConnectorFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectorformat?view=office-pia
  /// </remarks>
  public ConnectorFormat ConnectorFormat { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.fill?view=office-pia
  /// </remarks>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `GroupItems` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.groupitems?view=office-pia
  /// </remarks>
  public GroupShapes GroupItems { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.height?view=office-pia
  /// </remarks>
  public float Height { get; set; }
  /// <summary>
  /// Gets the `HorizontalFlip` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.horizontalflip?view=office-pia
  /// </remarks>
  public MsoTriState HorizontalFlip { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.left?view=office-pia
  /// </remarks>
  public float Left { get; set; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.line?view=office-pia
  /// </remarks>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets or sets the `LockAspectRatio` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.lockaspectratio?view=office-pia
  /// </remarks>
  public MsoTriState LockAspectRatio { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.nodes?view=office-pia
  /// </remarks>
  public ShapeNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rotation?view=office-pia
  /// </remarks>
  public float Rotation { get; set; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pictureformat?view=office-pia
  /// </remarks>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shadow?view=office-pia
  /// </remarks>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `TextEffect` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.texteffect?view=office-pia
  /// </remarks>
  public TextEffectFormat TextEffect { get; }
  /// <summary>
  /// Gets the `TextFrame` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.textframe?view=office-pia
  /// </remarks>
  public TextFrame TextFrame { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.threed?view=office-pia
  /// </remarks>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.top?view=office-pia
  /// </remarks>
  public float Top { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.type?view=office-pia
  /// </remarks>
  public MsoShapeType Type { get; }
  /// <summary>
  /// Gets the `VerticalFlip` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.verticalflip?view=office-pia
  /// </remarks>
  public MsoTriState VerticalFlip { get; }
  /// <summary>
  /// Gets the `Vertices` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.vertices?view=office-pia
  /// </remarks>
  public object Vertices { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.width?view=office-pia
  /// </remarks>
  public float Width { get; set; }
  /// <summary>
  /// Gets the `ZOrderPosition` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.zorderposition?view=office-pia
  /// </remarks>
  public int ZOrderPosition { get; }
  /// <summary>
  /// Gets the `Script` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.script?view=office-pia
  /// </remarks>
  public Script Script { get; }
  /// <summary>
  /// Gets or sets the `AlternativeText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.alternativetext?view=office-pia
  /// </remarks>
  public string AlternativeText { get; set; }
  /// <summary>
  /// Gets the `HasDiagram` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagram?view=office-pia
  /// </remarks>
  public MsoTriState HasDiagram { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagram?view=office-pia
  /// </remarks>
  public IMsoDiagram Diagram { get; }
  /// <summary>
  /// Gets the `HasDiagramNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagramnode?view=office-pia
  /// </remarks>
  public MsoTriState HasDiagramNode { get; }
  /// <summary>
  /// Gets the `DiagramNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagramnode?view=office-pia
  /// </remarks>
  public DiagramNode DiagramNode { get; }
  /// <summary>
  /// Gets the `Child` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.child?view=office-pia
  /// </remarks>
  public MsoTriState Child { get; }
  /// <summary>
  /// Gets the `ParentGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.parentgroup?view=office-pia
  /// </remarks>
  public Shape ParentGroup { get; }
  /// <summary>
  /// Gets the `CanvasItems` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvasitems?view=office-pia
  /// </remarks>
  public CanvasShapes CanvasItems { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.id?view=office-pia
  /// </remarks>
  public int Id { get; }
  public string RTF { set; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.textframe2?view=office-pia
  /// </remarks>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `HasChart` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.haschart?view=office-pia
  /// </remarks>
  public MsoTriState HasChart { get; }
  /// <summary>
  /// Gets the `Chart` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.chart?view=office-pia
  /// </remarks>
  public IMsoChart Chart { get; }
  /// <summary>
  /// Gets or sets the `ShapeStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shapestyle?view=office-pia
  /// </remarks>
  public MsoShapeStyleIndex ShapeStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BackgroundStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.backgroundstyle?view=office-pia
  /// </remarks>
  public MsoBackgroundStyleIndex BackgroundStyle { get; set; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.softedge?view=office-pia
  /// </remarks>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.glow?view=office-pia
  /// </remarks>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.reflection?view=office-pia
  /// </remarks>
  public ReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.title?view=office-pia
  /// </remarks>
  public string Title { get; set; }
}
