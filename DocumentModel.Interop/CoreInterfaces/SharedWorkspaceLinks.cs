using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia"/>
public partial interface ISharedWorkspaceLinks: InteropCollection<SharedWorkspaceLink>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

