
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart grid lines.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines?view=office-pia
/// </remarks>
public partial interface GridLines
{
  /// <summary>
  /// Selects the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
