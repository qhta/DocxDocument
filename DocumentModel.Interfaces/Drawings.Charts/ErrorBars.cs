
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents error bars in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars?view=office-pia"/>
public partial interface ErrorBars: InteropObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets or sets the `EndStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.endstyle?view=office-pia"/>
  public XlEndStyleCap EndStyle { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.format?view=office-pia"/>
  public ChartFormat Format { get; }
}

