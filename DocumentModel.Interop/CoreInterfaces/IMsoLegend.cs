
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart legend.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend?view=office-pia
/// </remarks>
public partial interface IMsoLegend
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.position?view=office-pia
  /// </remarks>
  public XlLegendPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.shadow?view=office-pia
  /// </remarks>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.height?view=office-pia
  /// </remarks>
  public double Height { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.left?view=office-pia
  /// </remarks>
  public double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.top?view=office-pia
  /// </remarks>
  public double Top { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.width?view=office-pia
  /// </remarks>
  public double Width { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.autoscalefont?view=office-pia
  /// </remarks>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.includeinlayout?view=office-pia
  /// </remarks>
  public bool IncludeInLayout { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
