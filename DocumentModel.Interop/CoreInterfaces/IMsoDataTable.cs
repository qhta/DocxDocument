
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDataTable` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDataTable
{
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.showlegendkey?view=office-pia
  /// </remarks>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderHorizontal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasborderhorizontal?view=office-pia
  /// </remarks>
  public bool HasBorderHorizontal { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderVertical` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasbordervertical?view=office-pia
  /// </remarks>
  public bool HasBorderVertical { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderOutline` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasborderoutline?view=office-pia
  /// </remarks>
  public bool HasBorderOutline { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.autoscalefont?view=office-pia
  /// </remarks>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
