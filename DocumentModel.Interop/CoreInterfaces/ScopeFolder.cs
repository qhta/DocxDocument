using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ScopeFolder` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ScopeFolder: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Path` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.path?view=office-pia
  /// </remarks>
  public string Path { get; }
  /// <summary>
  /// Gets the `ScopeFolders` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.scopefolders?view=office-pia
  /// </remarks>
  public ScopeFolders ScopeFolders { get; }
}
