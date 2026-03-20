
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents drop lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines?view=office-pia
/// </remarks>
public partial interface IMsoDropLines
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
