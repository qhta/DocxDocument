using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of all chart points in a series.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia
/// </remarks>
public partial interface Points
{
  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  /// <returns>An enumerator for the points collection.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
