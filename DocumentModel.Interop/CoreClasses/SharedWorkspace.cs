using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a shared workspace linked to the current document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia"/>
public partial class SharedWorkspace: InteropObject
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
  public SharedWorkspaceMembers Members { get; }
  /// <summary>
  /// Gets the `Tasks` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.tasks?view=office-pia"/>
  public SharedWorkspaceTasks Tasks { get; }
  /// <summary>
  /// Gets the `Files` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.files?view=office-pia"/>
  public SharedWorkspaceFiles Files { get; }
  /// <summary>
  /// Gets the `Folders` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.folders?view=office-pia"/>
  public SharedWorkspaceFolders Folders { get; }
  /// <summary>
  /// Gets the `Links` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.links?view=office-pia"/>
  public SharedWorkspaceLinks Links { get; }
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


  #region methods

/// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.refresh?view=office-pia"/>
  public void Refresh() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CreateNew`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.createnew?view=office-pia"/>
  public void CreateNew(object URL, object Name) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RemoveDocument`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.removedocument?view=office-pia"/>
  public void RemoveDocument() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Disconnect`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.disconnect?view=office-pia"/>
  public void Disconnect() { throw new NotImplementedException(); }

  #endregion methods
}

