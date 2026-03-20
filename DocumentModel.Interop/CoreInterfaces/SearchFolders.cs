using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SearchFolders` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchfolders?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SearchFolders: InteropCollection<ScopeFolder>
{
}
