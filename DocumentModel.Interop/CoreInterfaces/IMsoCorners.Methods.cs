
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoCorners` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoCorners
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.select?view=office-pia
  /// </remarks>
  public object Select();
}
