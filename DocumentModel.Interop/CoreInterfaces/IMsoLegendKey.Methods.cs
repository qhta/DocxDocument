
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoLegendKey` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoLegendKey
{
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.select?view=office-pia
  /// </remarks>
  public object Select();
}
