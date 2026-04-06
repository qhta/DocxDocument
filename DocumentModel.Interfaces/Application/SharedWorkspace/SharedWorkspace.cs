using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a shared workspace linked to the current document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia"/>
public partial interface ISharedWorkspace: IModelObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Members` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.members?view=office-pia"/>
  public ISharedWorkspaceMembers Members { get; }
  /// <summary>
  /// Gets the `Tasks` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.tasks?view=office-pia"/>
  public ISharedWorkspaceTasks Tasks { get; }
  /// <summary>
  /// Gets the `Files` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.files?view=office-pia"/>
  public ISharedWorkspaceFiles Files { get; }
  /// <summary>
  /// Gets the `Folders` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.folders?view=office-pia"/>
  public ISharedWorkspaceFolders Folders { get; }
  /// <summary>
  /// Gets the `Links` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.links?view=office-pia"/>
  public ISharedWorkspaceLinks Links { get; }
  /// <summary>
  /// Gets the `URL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.url?view=office-pia"/>
  public string URL { get; }
  /// <summary>
  /// Gets the `Connected` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.connected?view=office-pia"/>
  public bool Connected { get; }
  /// <summary>
  /// Gets the `LastRefreshed` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.lastrefreshed?view=office-pia"/>
  public object LastRefreshed { get; }
  /// <summary>
  /// Gets or sets the `SourceURL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.sourceurl?view=office-pia"/>
  public string SourceURL { get; set; }
}

