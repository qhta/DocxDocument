
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDownBars` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDownBars
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
