
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ODSOColumns` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ODSOColumns
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="varIndex">The `varIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.item?view=office-pia
  /// </remarks>
  public object Item(object varIndex);
}
