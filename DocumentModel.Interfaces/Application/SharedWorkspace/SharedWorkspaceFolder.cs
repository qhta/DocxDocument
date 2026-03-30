using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a folder in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia"/>
public partial interface SharedWorkspaceFolder: IModelObject
{
  /// <summary>
  /// Gets the `FolderName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.foldername?view=office-pia"/>
  public string FolderName { get; }
}

