using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SearchFolders` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SearchFolders
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="ScopeFolder">The `ScopeFolder` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders.add?view=office-pia
  /// </remarks>
  public void Add(ScopeFolder ScopeFolder);
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders.remove?view=office-pia
  /// </remarks>
  public void Remove(int Index);
}
