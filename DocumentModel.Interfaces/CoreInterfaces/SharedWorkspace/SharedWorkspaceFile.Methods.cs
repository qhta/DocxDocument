using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a file in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile?view=office-pia"/>
public partial interface SharedWorkspaceFile: InteropObject
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.delete?view=office-pia"/>
  public void Delete();
}

