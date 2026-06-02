using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of folders included in a file search.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia"/>
public partial interface ISearchFolders: InteropCollection<ScopeFolder>
{
}

