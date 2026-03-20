
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia
/// </remarks>
public partial interface IMsoLeaderLines
{
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
