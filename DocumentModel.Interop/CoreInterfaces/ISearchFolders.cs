using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of folders included in a file search.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia"/>
public interface ISearchFolders: IInteropCollection<IScopeFolder>
{


  #region methods

/// <summary>
  /// Removes a folder from the search folders collection.
  /// </summary>
  /// <param name="Index">The index of the folder to remove.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders.remove?view=office-pia"/>
  public void Remove(int Index);

  #endregion methods
}

