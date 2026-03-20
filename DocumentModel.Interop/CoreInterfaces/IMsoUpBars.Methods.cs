
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoUpBars` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoUpBars
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
