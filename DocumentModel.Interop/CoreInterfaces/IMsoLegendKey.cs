
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a legend key in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia
/// </remarks>
public partial interface IMsoLegendKey
{
  /// <summary>
  /// Gets or sets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.invertifnegative?view=office-pia
  /// </remarks>
  public bool InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolor?view=office-pia
  /// </remarks>
  public int MarkerBackgroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolorindex?view=office-pia
  /// </remarks>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolor?view=office-pia
  /// </remarks>
  public int MarkerForegroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolorindex?view=office-pia
  /// </remarks>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markersize?view=office-pia
  /// </remarks>
  public int MarkerSize { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerstyle?view=office-pia
  /// </remarks>
  public XlMarkerStyle MarkerStyle { get; set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.picturetype?view=office-pia
  /// </remarks>
  public int PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit?view=office-pia
  /// </remarks>
  public double PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.smooth?view=office-pia
  /// </remarks>
  public bool Smooth { get; set; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.left?view=office-pia
  /// </remarks>
  public double Left { get; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.top?view=office-pia
  /// </remarks>
  public double Top { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.width?view=office-pia
  /// </remarks>
  public double Width { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.height?view=office-pia
  /// </remarks>
  public double Height { get; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.shadow?view=office-pia
  /// </remarks>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit2?view=office-pia
  /// </remarks>
  public double PictureUnit2 { get; set; }
}
