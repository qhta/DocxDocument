using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Points` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Points
{
  /// <summary>
  /// Invokes `GetEnumerator`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
