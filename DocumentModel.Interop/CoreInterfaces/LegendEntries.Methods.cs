using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of legend entries.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia
/// </remarks>
public partial interface LegendEntries
{
  /// <summary>
  /// Returns an enumerator that iterates through the legend entries.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
