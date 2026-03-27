using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a searchable folder.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia"/>
public partial interface ScopeFolder: InteropObject
{
  /// <summary>
  /// Adds this folder to the search folders collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.addtosearchfolders?view=office-pia"/>
  public void AddToSearchFolders();
}

