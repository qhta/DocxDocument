using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of legend entries.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia"/>
public partial class LegendEntries: InteropCollection<LegendEntry>
{



  #region methods

/// <summary>
  /// Returns an enumerator that iterates through the legend entries.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator() { throw new NotImplementedException(); }

  #endregion methods
}

