using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a file in a shared workspace.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile?view=office-pia
/// </remarks>
public partial interface SharedWorkspaceFile
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
