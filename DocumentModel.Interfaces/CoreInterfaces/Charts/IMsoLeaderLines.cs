
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia"/>
public partial interface LeaderLines: InteropObject
{
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.border?view=office-pia"/>
  public Border Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.format?view=office-pia"/>
  public ChartFormat Format { get; }
}

