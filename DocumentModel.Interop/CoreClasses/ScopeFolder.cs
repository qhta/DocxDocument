using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a searchable folder.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder?view=office-pia"/>
public partial class ScopeFolder: InteropObject
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
  public ScopeFolders ScopeFolders { get; }


  #region methods

/// <summary>
  /// Adds this folder to the search folders collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scopefolder.addtosearchfolders?view=office-pia"/>
  public void AddToSearchFolders() { throw new NotImplementedException(); }

  #endregion methods
}

