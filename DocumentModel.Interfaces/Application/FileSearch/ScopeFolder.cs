using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a searchable folder.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia"/>
public partial interface IScopeFolder: IModelObject
{
  /// <summary>
  /// Gets the folder name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the folder path.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.path?view=office-pia"/>
  public string Path { get; }
  /// <summary>
  /// Gets the collection of subfolders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.scopefolders?view=office-pia"/>
  public IScopeFolders ScopeFolders { get; }
}

