
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `LegendEntry` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry?view=office-pia` for Office interop details.
/// </remarks>
public partial interface LegendEntry
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.select?view=office-pia
  /// </remarks>
  public object Select();
}
