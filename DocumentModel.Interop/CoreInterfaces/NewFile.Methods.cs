
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `NewFile` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile?view=office-pia` for Office interop details.
/// </remarks>
public partial interface NewFile
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="Section">The `Section` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Action">The `Action` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.add?view=office-pia
  /// </remarks>
  public bool Add(string FileName, object Section, object DisplayName, object Action);
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="Section">The `Section` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Action">The `Action` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.remove?view=office-pia
  /// </remarks>
  public bool Remove(string FileName, object Section, object DisplayName, object Action);
}
