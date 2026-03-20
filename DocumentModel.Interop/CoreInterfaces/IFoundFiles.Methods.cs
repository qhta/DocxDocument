using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IFoundFiles` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IFoundFiles
{
  /// <summary>
  /// Invokes `GetEnumerator`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
