using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files returned by a search.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia
/// </remarks>
public partial interface IFoundFiles
{
  /// <summary>
  /// Returns an enumerator that iterates through the found files.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
