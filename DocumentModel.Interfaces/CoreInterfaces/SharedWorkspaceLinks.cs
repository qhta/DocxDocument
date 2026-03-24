using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia"/>
public partial interface SharedWorkspaceLinks: InteropCollection<SharedWorkspaceLink>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

