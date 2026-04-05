
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart element formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat?view=office-pia"/>
public partial interface IChartFormat: IModelObject
{
  /// <summary>
  /// Gets or sets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.fill?view=office-pia"/>
  public IFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.glow?view=office-pia"/>
  public IGlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.line?view=office-pia"/>
  public ILineFormat Line { get; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.pictureformat?view=office-pia"/>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.shadow?view=office-pia"/>
  public IShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.softedge?view=office-pia"/>
  public ISoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.textframe2?view=office-pia"/>
  public Drawings.ITextFrame TextFrame2 { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.threed?view=office-pia"/>
  public IThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the `Adjustments` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.adjustments?view=office-pia"/>
  public IAdjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.autoshapetype?view=office-pia"/>
  public AutoShapeType AutoShapeType { get; set; }
}

