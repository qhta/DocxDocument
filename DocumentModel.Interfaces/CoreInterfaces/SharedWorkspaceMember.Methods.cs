using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SharedWorkspaceMember` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceMember
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.delete?view=office-pia"/>
  public void Delete();
}

