using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of folders included in a file search.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia
/// </remarks>
public partial interface SearchFolders: InteropCollection<ScopeFolder>
{
  /// <summary>
  /// Removes a folder from the search folders collection.
  /// </summary>
  /// <param name="Index">The index of the folder to remove.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders.remove?view=office-pia
  /// </remarks>
  public void Remove(int Index);
}
