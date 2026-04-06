using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the collection of folders included in a file search.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia"/>
public partial interface ISearchFolders: IModelCollection<IScopeFolder>
{
}

