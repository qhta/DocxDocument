using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a searchable folder.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia
/// </remarks>
public partial interface ScopeFolder: InteropObject
{
  /// <summary>
  /// Gets the folder name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the folder path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.path?view=office-pia
  /// </remarks>
  public string Path { get; }
  /// <summary>
  /// Gets the collection of subfolders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.scopefolders?view=office-pia
  /// </remarks>
  public ScopeFolders ScopeFolders { get; }
}
