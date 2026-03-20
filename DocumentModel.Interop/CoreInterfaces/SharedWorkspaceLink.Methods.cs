using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceLink` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceLink
{
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.save?view=office-pia
  /// </remarks>
  public void Save();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
