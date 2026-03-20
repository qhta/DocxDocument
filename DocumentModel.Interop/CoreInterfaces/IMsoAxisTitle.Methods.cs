
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoAxisTitle` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoAxisTitle
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.delete?view=office-pia
  /// </remarks>
  public new object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.select?view=office-pia
  /// </remarks>
  public new object Select();
}
