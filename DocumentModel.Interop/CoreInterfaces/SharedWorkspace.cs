using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspace` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspace: InteropObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets the `Members` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.members?view=office-pia
  /// </remarks>
  public SharedWorkspaceMembers Members { get; }
  /// <summary>
  /// Gets the `Tasks` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.tasks?view=office-pia
  /// </remarks>
  public SharedWorkspaceTasks Tasks { get; }
  /// <summary>
  /// Gets the `Files` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.files?view=office-pia
  /// </remarks>
  public SharedWorkspaceFiles Files { get; }
  /// <summary>
  /// Gets the `Folders` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.folders?view=office-pia
  /// </remarks>
  public SharedWorkspaceFolders Folders { get; }
  /// <summary>
  /// Gets the `Links` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.links?view=office-pia
  /// </remarks>
  public SharedWorkspaceLinks Links { get; }
  /// <summary>
  /// Gets the `URL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.url?view=office-pia
  /// </remarks>
  public string URL { get; }
  /// <summary>
  /// Gets the `Connected` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.connected?view=office-pia
  /// </remarks>
  public bool Connected { get; }
  /// <summary>
  /// Gets the `LastRefreshed` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.lastrefreshed?view=office-pia
  /// </remarks>
  public object LastRefreshed { get; }
  /// <summary>
  /// Gets or sets the `SourceURL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.sourceurl?view=office-pia
  /// </remarks>
  public string SourceURL { get; set; }
}
