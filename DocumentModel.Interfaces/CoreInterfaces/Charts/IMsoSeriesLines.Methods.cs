
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents series lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines?view=office-pia"/>
public partial interface IMsoSeriesLines: InteropObject
{
  /// <summary>
  /// Selects the series lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the series lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.delete?view=office-pia"/>
  public object Delete();
}

