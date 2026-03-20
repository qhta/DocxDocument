
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoWalls` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoWalls
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.paste?view=office-pia
  /// </remarks>
  public void Paste();
}
