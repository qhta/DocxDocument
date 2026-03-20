
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoAxis` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoAxis
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.select?view=office-pia
  /// </remarks>
  public object Select();
}
