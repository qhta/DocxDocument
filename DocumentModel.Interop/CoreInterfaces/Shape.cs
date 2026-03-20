
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Shape` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Shape: InteropObject
{
  /// <summary>
  /// Gets or sets the `Adjustments` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.adjustments?view=office-pia
  /// </remarks>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.autoshapetype?view=office-pia
  /// </remarks>
  public MsoAutoShapeType AutoShapeType { get; set; }
  /// <summary>
  /// Gets or sets the `BlackWhiteMode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.blackwhitemode?view=office-pia
  /// </remarks>
  public MsoBlackWhiteMode BlackWhiteMode { get; set; }
  /// <summary>
  /// Gets the `Callout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.callout?view=office-pia
  /// </remarks>
  public CalloutFormat Callout { get; }
  /// <summary>
  /// Gets the `ConnectionSiteCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.connectionsitecount?view=office-pia
  /// </remarks>
  public int ConnectionSiteCount { get; }
  /// <summary>
  /// Gets the `Connector` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.connector?view=office-pia
  /// </remarks>
  public MsoTriState Connector { get; }
  /// <summary>
  /// Gets the `ConnectorFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.connectorformat?view=office-pia
  /// </remarks>
  public ConnectorFormat ConnectorFormat { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.fill?view=office-pia
  /// </remarks>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `GroupItems` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.groupitems?view=office-pia
  /// </remarks>
  public GroupShapes GroupItems { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.height?view=office-pia
  /// </remarks>
  public float Height { get; set; }
  /// <summary>
  /// Gets the `HorizontalFlip` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.horizontalflip?view=office-pia
  /// </remarks>
  public MsoTriState HorizontalFlip { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.left?view=office-pia
  /// </remarks>
  public float Left { get; set; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.line?view=office-pia
  /// </remarks>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets or sets the `LockAspectRatio` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.lockaspectratio?view=office-pia
  /// </remarks>
  public MsoTriState LockAspectRatio { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.nodes?view=office-pia
  /// </remarks>
  public ShapeNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.rotation?view=office-pia
  /// </remarks>
  public float Rotation { get; set; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.pictureformat?view=office-pia
  /// </remarks>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.shadow?view=office-pia
  /// </remarks>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `TextEffect` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.texteffect?view=office-pia
  /// </remarks>
  public TextEffectFormat TextEffect { get; }
  /// <summary>
  /// Gets the `TextFrame` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.textframe?view=office-pia
  /// </remarks>
  public TextFrame TextFrame { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.threed?view=office-pia
  /// </remarks>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.top?view=office-pia
  /// </remarks>
  public float Top { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.type?view=office-pia
  /// </remarks>
  public MsoShapeType Type { get; }
  /// <summary>
  /// Gets the `VerticalFlip` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.verticalflip?view=office-pia
  /// </remarks>
  public MsoTriState VerticalFlip { get; }
  /// <summary>
  /// Gets the `Vertices` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.vertices?view=office-pia
  /// </remarks>
  public object Vertices { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.width?view=office-pia
  /// </remarks>
  public float Width { get; set; }
  /// <summary>
  /// Gets the `ZOrderPosition` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.zorderposition?view=office-pia
  /// </remarks>
  public int ZOrderPosition { get; }
  /// <summary>
  /// Gets the `Script` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.script?view=office-pia
  /// </remarks>
  public Script Script { get; }
  /// <summary>
  /// Gets or sets the `AlternativeText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.alternativetext?view=office-pia
  /// </remarks>
  public string AlternativeText { get; set; }
  /// <summary>
  /// Gets the `HasDiagram` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.hasdiagram?view=office-pia
  /// </remarks>
  public MsoTriState HasDiagram { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.diagram?view=office-pia
  /// </remarks>
  public IMsoDiagram Diagram { get; }
  /// <summary>
  /// Gets the `HasDiagramNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.hasdiagramnode?view=office-pia
  /// </remarks>
  public MsoTriState HasDiagramNode { get; }
  /// <summary>
  /// Gets the `DiagramNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.diagramnode?view=office-pia
  /// </remarks>
  public DiagramNode DiagramNode { get; }
  /// <summary>
  /// Gets the `Child` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.child?view=office-pia
  /// </remarks>
  public MsoTriState Child { get; }
  /// <summary>
  /// Gets the `ParentGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.parentgroup?view=office-pia
  /// </remarks>
  public Shape ParentGroup { get; }
  /// <summary>
  /// Gets the `CanvasItems` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvasitems?view=office-pia
  /// </remarks>
  public CanvasShapes CanvasItems { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.id?view=office-pia
  /// </remarks>
  public int Id { get; }
  public string RTF { set; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.textframe2?view=office-pia
  /// </remarks>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `HasChart` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.haschart?view=office-pia
  /// </remarks>
  public MsoTriState HasChart { get; }
  /// <summary>
  /// Gets the `Chart` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.chart?view=office-pia
  /// </remarks>
  public IMsoChart Chart { get; }
  /// <summary>
  /// Gets or sets the `ShapeStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.shapestyle?view=office-pia
  /// </remarks>
  public MsoShapeStyleIndex ShapeStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BackgroundStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.backgroundstyle?view=office-pia
  /// </remarks>
  public MsoBackgroundStyleIndex BackgroundStyle { get; set; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.softedge?view=office-pia
  /// </remarks>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.glow?view=office-pia
  /// </remarks>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.reflection?view=office-pia
  /// </remarks>
  public ReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets the `HasSmartArt` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.hassmartart?view=office-pia
  /// </remarks>
  public MsoTriState HasSmartArt { get; }
  /// <summary>
  /// Gets the `SmartArt` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.smartart?view=office-pia
  /// </remarks>
  public SmartArt SmartArt { get; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.title?view=office-pia
  /// </remarks>
  public string Title { get; set; }
}
