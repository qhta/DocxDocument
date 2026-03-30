using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia"/>
public partial interface FullSeriesCollection: IModelObject
{
  /// <summary>
  /// Returns an enumerator for the full series collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();
}

