using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Script` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Script
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
