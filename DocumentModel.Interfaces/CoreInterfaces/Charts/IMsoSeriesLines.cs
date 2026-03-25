
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents series lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines?view=office-pia"/>
public partial interface IMsoSeriesLines: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }
}

