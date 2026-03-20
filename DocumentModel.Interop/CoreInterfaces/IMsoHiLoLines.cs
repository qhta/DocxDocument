
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents high-low lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia
/// </remarks>
public partial interface IMsoHiLoLines
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
