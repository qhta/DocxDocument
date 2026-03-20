
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart element formatting.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat?view=office-pia
/// </remarks>
public partial interface IMsoChartFormat
{
  /// <summary>
  /// Gets or sets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.fill?view=office-pia
  /// </remarks>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.glow?view=office-pia
  /// </remarks>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.line?view=office-pia
  /// </remarks>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets the `PictureFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.pictureformat?view=office-pia
  /// </remarks>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.shadow?view=office-pia
  /// </remarks>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `SoftEdge` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.softedge?view=office-pia
  /// </remarks>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.textframe2?view=office-pia
  /// </remarks>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.threed?view=office-pia
  /// </remarks>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the `Adjustments` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.adjustments?view=office-pia
  /// </remarks>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the `AutoShapeType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartformat.autoshapetype?view=office-pia
  /// </remarks>
  public MsoAutoShapeType AutoShapeType { get; set; }
}
