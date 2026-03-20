using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia
/// </remarks>
public partial interface FullSeriesCollection
{
  /// <summary>
  /// Returns an enumerator for the full series collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
