using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of available search scopes.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscopes?view=office-pia"/>
public partial interface ISearchScopes: IModelCollection<ISearchScope>
{
}

