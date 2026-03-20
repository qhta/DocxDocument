using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ScopeFolder` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ScopeFolder
{
  /// <summary>
  /// Invokes `AddToSearchFolders`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.addtosearchfolders?view=office-pia
  /// </remarks>
  public void AddToSearchFolders();
}
