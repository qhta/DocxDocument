
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia
/// </remarks>
public partial interface ODSOFilters
{
  /// <summary>
  /// Returns a filter from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The requested filter object.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.item?view=office-pia
  /// </remarks>
  public object Item(int Index);
  /// <summary>
  /// Adds a filter to the collection.
  /// </summary>
  /// <param name="Column">The `Column` parameter.</param>
  /// <param name="Comparison">The `Comparison` parameter.</param>
  /// <param name="Conjunction">The `Conjunction` parameter.</param>
  /// <param name="bstrCompareTo">The `bstrCompareTo` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.add?view=office-pia
  /// </remarks>
  public void Add
  (string Column, MsoFilterComparison Comparison, MsoFilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate);
  /// <summary>
  /// Deletes a filter from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.delete?view=office-pia
  /// </remarks>
  public void Delete(int Index, bool DeferUpdate);
}
