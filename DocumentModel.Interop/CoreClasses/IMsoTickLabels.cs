
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents tick labels on a chart axis.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels?view=office-pia"/>
public partial class IMsoTickLabels
{
  /// <summary>
  /// Gets or sets the `Font` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.font?view=office-pia"/>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformat?view=office-pia"/>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlinked?view=office-pia"/>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlocal?view=office-pia"/>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.orientation?view=office-pia"/>
  public TickLabelOrientation Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.readingorder?view=office-pia"/>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Depth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.depth?view=office-pia"/>
  public int Depth { get; }
  /// <summary>
  /// Gets or sets the `Offset` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.offset?view=office-pia"/>
  public int Offset { get; set; }
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.alignment?view=office-pia"/>
  public int Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `MultiLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.multilevel?view=office-pia"/>
  public bool MultiLevel { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.format?view=office-pia"/>
  public MsoChartFormat Format { get; }
}

