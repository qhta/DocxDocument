using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a searchable folder.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia
/// </remarks>
public partial interface ScopeFolder
{
  /// <summary>
  /// Adds this folder to the search folders collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.addtosearchfolders?view=office-pia
  /// </remarks>
  public void AddToSearchFolders();
}
