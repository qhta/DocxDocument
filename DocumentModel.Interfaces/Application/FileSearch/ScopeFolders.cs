using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of searchable folders.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolders?view=office-pia"/>
public partial interface IScopeFolders: IModelCollection<IScopeFolder>
{
}

