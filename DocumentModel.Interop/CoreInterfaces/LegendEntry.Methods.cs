
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry?view=office-pia
/// </remarks>
public partial interface LegendEntry
{
  /// <summary>
  /// Deletes the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.select?view=office-pia
  /// </remarks>
  public object Select();
}
