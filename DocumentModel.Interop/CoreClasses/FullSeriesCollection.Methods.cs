using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia"/>
public partial class FullSeriesCollection
{
  /// <summary>
  /// Returns an enumerator for the full series collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator() { throw new NotImplementedException(); }
}

