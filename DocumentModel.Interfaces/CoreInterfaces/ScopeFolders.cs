using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a collection of searchable folders.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolders?view=office-pia"/>
public partial interface ScopeFolders: InteropCollection<ScopeFolder>
{
}

