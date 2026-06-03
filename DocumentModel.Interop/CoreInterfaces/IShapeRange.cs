using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange?view=office-pia"/>
public interface IShapeRange: IInteropCollection<IShape>
{
  /// <summary>
  /// Gets or sets the `Adjustments` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.adjustments?view=office-pia"/>
  public IAdjustments IAdjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.autoshapetype?view=office-pia"/>
  public AutoShapeType AutoShapeType { get; set; }
  /// <summary>
  /// Gets or sets the `BlackWhiteMode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.blackwhitemode?view=office-pia"/>
  public BlackWhiteMode BlackWhiteMode { get; set; }
  /// <summary>
  /// Gets the `Callout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.callout?view=office-pia"/>
  public ICalloutFormat Callout { get; }
  /// <summary>
  /// Gets the `ConnectionSiteCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectionsitecount?view=office-pia"/>
  public int ConnectionSiteCount { get; }
  /// <summary>
  /// Gets the `Connector` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connector?view=office-pia"/>
  public TriState Connector { get; }
  /// <summary>
  /// Gets the `ConnectorFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.connectorformat?view=office-pia"/>
  public IConnectorFormat IConnectorFormat { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.fill?view=office-pia"/>
  public IFillFormat Fill { get; }
  /// <summary>
  /// Gets the `GroupItems` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.groupitems?view=office-pia"/>
  public IGroupShapes GroupItems { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.height?view=office-pia"/>
  public float Height { get; set; }
  /// <summary>
  /// Gets the `HorizontalFlip` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.horizontalflip?view=office-pia"/>
  public TriState HorizontalFlip { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.left?view=office-pia"/>
  public float Left { get; set; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.line?view=office-pia"/>
  public ILineFormat Line { get; }
  /// <summary>
  /// Gets or sets the `LockAspectRatio` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.lockaspectratio?view=office-pia"/>
  public TriState LockAspectRatio { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.nodes?view=office-pia"/>
  public IShapeNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rotation?view=office-pia"/>
  public float Rotation { get; set; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pictureformat?view=office-pia"/>
  public IPictureFormat IPictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shadow?view=office-pia"/>
  public IShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `TextEffect` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.texteffect?view=office-pia"/>
  public ITextEffectFormat TextEffect { get; }
  /// <summary>
  /// Gets the `TextFrame` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.textframe?view=office-pia"/>
  public ITextFrame ITextFrame { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.threed?view=office-pia"/>
  public IThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.top?view=office-pia"/>
  public float Top { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.type?view=office-pia"/>
  public ShapeType Type { get; }
  /// <summary>
  /// Gets the `VerticalFlip` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.verticalflip?view=office-pia"/>
  public TriState VerticalFlip { get; }
  /// <summary>
  /// Gets the `Vertices` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.vertices?view=office-pia"/>
  public object Vertices { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.visible?view=office-pia"/>
  public TriState Visible { get; set; }
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
  public IScript Script { get; }
  /// <summary>
  /// Gets or sets the `AlternativeText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.alternativetext?view=office-pia"/>
  public string AlternativeText { get; set; }
  /// <summary>
  /// Gets the `HasDiagram` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagram?view=office-pia"/>
  public TriState HasDiagram { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagram?view=office-pia"/>
  public IMsoDiagram Diagram { get; }
  /// <summary>
  /// Gets the `HasDiagramNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.hasdiagramnode?view=office-pia"/>
  public TriState HasDiagramNode { get; }
  /// <summary>
  /// Gets the `DiagramNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.diagramnode?view=office-pia"/>
  public IDiagramNode IDiagramNode { get; }
  /// <summary>
  /// Gets the `Child` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.child?view=office-pia"/>
  public TriState Child { get; }
  /// <summary>
  /// Gets the `ParentGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.parentgroup?view=office-pia"/>
  public IShape ParentGroup { get; }
  /// <summary>
  /// Gets the `CanvasItems` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvasitems?view=office-pia"/>
  public ICanvasShapes CanvasItems { get; }
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
  public ITextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `HasChart` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.haschart?view=office-pia"/>
  public TriState HasChart { get; }
  /// <summary>
  /// Gets the `Chart` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.chart?view=office-pia"/>
  public IMsoChart Chart { get; }
  /// <summary>
  /// Gets or sets the `ShapeStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.shapestyle?view=office-pia"/>
  public ShapeStyleIndex ShapeStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BackgroundStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.backgroundstyle?view=office-pia"/>
  public BackgroundStyleIndex BackgroundStyle { get; set; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.softedge?view=office-pia"/>
  public ISoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.glow?view=office-pia"/>
  public IGlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.reflection?view=office-pia"/>
  public IReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.title?view=office-pia"/>
  public string Title { get; set; }


  #region methods

/// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.item?view=office-pia"/>
  public IShape Item(object index);
  /// <summary>
  /// Invokes `Align`.
  /// </summary>
  /// <param name="alignCmd">The `AlignCmd` parameter.</param>
  /// <param name="relativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.align?view=office-pia"/>
  public void Align(AlignCmd alignCmd, TriState relativeTo);
  /// <summary>
  /// Invokes `Apply`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.apply?view=office-pia"/>
  public void Apply();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `Distribute`.
  /// </summary>
  /// <param name="distributeCmd">The `DistributeCmd` parameter.</param>
  /// <param name="relativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.distribute?view=office-pia"/>
  public void Distribute(DistributeCmd distributeCmd, TriState relativeTo);
  /// <summary>
  /// Invokes `Duplicate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.duplicate?view=office-pia"/>
  public IShapeRange Duplicate();
  /// <summary>
  /// Invokes `Flip`.
  /// </summary>
  /// <param name="flipCmd">The `FlipCmd` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.flip?view=office-pia"/>
  public void Flip(FlipCmd flipCmd);
  /// <summary>
  /// Invokes `IncrementLeft`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementleft?view=office-pia"/>
  public void IncrementLeft(float increment);
  /// <summary>
  /// Invokes `IncrementRotation`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementrotation?view=office-pia"/>
  public void IncrementRotation(float increment);
  /// <summary>
  /// Invokes `IncrementTop`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementtop?view=office-pia"/>
  public void IncrementTop(float increment);
  /// <summary>
  /// Invokes `Group`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.group?view=office-pia"/>
  public IShape Group();
  /// <summary>
  /// Invokes `PickUp`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pickup?view=office-pia"/>
  public void PickUp();
  /// <summary>
  /// Invokes `Regroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.regroup?view=office-pia"/>
  public IShape Regroup();
  /// <summary>
  /// Invokes `RerouteConnections`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rerouteconnections?view=office-pia"/>
  public void RerouteConnections();
  /// <summary>
  /// Invokes `ScaleHeight`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scaleheight?view=office-pia"/>
  public void ScaleHeight
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale);
  /// <summary>
  /// Invokes `ScaleWidth`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scalewidth?view=office-pia"/>
  public void ScaleWidth
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="replace">The `Replace` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.select?view=office-pia"/>
  public void Select(object replace);
  /// <summary>
  /// Invokes `SetShapesDefaultProperties`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.setshapesdefaultproperties?view=office-pia"/>
  public void SetShapesDefaultProperties();
  /// <summary>
  /// Invokes `Ungroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.ungroup?view=office-pia"/>
  public IShapeRange Ungroup();
  /// <summary>
  /// Invokes `ZOrder`.
  /// </summary>
  /// <param name="zOrderCmd">The `ZOrderCmd` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.zorder?view=office-pia"/>
  public void ZOrder(ZOrderCmd zOrderCmd);
  /// <summary>
  /// Invokes `CanvasCropLeft`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropleft?view=office-pia"/>
  public void CanvasCropLeft(float increment);
  /// <summary>
  /// Invokes `CanvasCropTop`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascroptop?view=office-pia"/>
  public void CanvasCropTop(float increment);
  /// <summary>
  /// Invokes `CanvasCropRight`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropright?view=office-pia"/>
  public void CanvasCropRight(float increment);
  /// <summary>
  /// Invokes `CanvasCropBottom`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropbottom?view=office-pia"/>
  public void CanvasCropBottom(float increment);
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.cut?view=office-pia"/>
  public void Cut();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.copy?view=office-pia"/>
  public void Copy();
  /// <summary>
  /// Invokes `MergeShapes`.
  /// </summary>
  /// <param name="mergeCmd">The `MergeCmd` parameter.</param>
  /// <param name="primaryShape">The `PrimaryShape` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.mergeshapes?view=office-pia"/>
  public void MergeShapes(MergeCmd mergeCmd, IShape primaryShape);

  #endregion methods
}

