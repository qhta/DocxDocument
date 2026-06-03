using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of available search scopes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscopes?view=office-pia"/>
public interface ISearchScopes: IInteropCollection<ISearchScope>
{
}

