using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia"/>
public partial interface ISharedWorkspaceLinks: IModelCollection<ISharedWorkspaceLink>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

