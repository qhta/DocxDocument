
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoTickLabels` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoTickLabels
{
  /// <summary>
  /// Gets or sets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformat?view=office-pia
  /// </remarks>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlinked?view=office-pia
  /// </remarks>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlocal?view=office-pia
  /// </remarks>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.orientation?view=office-pia
  /// </remarks>
  public XlTickLabelOrientation Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.readingorder?view=office-pia
  /// </remarks>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.autoscalefont?view=office-pia
  /// </remarks>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Depth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.depth?view=office-pia
  /// </remarks>
  public int Depth { get; }
  /// <summary>
  /// Gets or sets the `Offset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.offset?view=office-pia
  /// </remarks>
  public int Offset { get; set; }
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.alignment?view=office-pia
  /// </remarks>
  public int Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `MultiLevel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.multilevel?view=office-pia
  /// </remarks>
  public bool MultiLevel { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
