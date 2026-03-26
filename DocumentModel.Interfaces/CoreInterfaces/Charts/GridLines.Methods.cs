
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart grid lines.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines?view=office-pia"/>
public partial interface GridLines: InteropObject
{
  /// <summary>
  /// Selects the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.delete?view=office-pia"/>
  public object Delete();
}

