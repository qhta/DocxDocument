
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents series lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines?view=office-pia
/// </remarks>
public partial interface IMsoSeriesLines
{
  /// <summary>
  /// Selects the series lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the series lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
