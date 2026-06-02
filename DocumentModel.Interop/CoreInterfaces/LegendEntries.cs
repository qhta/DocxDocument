using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of legend entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia"/>
public partial interface ILegendEntries: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets a legend entry by index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.item?view=office-pia"/>
  public LegendEntry this[object Index] { get; }


  #region methods

/// <summary>
  /// Returns an enumerator that iterates through the legend entries.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();

  #endregion methods
}

