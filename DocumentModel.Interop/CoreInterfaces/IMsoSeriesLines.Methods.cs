
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoSeriesLines` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoSeriesLines
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoserieslines.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
