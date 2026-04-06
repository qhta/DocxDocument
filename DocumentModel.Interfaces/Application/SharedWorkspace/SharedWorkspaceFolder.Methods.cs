using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a folder in a shared workspace.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia"/>
public partial interface ISharedWorkspaceFolder: IModelObject
{
  /// <summary>
  /// Deletes the shared workspace folder.
  /// </summary>
  /// <param name="DeleteEventIfFolderContainsFiles">Whether to delete even if the folder contains files.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.delete?view=office-pia"/>
  public void Delete(object DeleteEventIfFolderContainsFiles);
}

