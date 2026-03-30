using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of files in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia"/>
public partial interface ISharedWorkspaceFiles: IModelCollection<ISharedWorkspaceFile>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

