
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia"/>
public partial interface ODSOFilters: InteropObject
{
  /// <summary>
  /// Returns a filter from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The requested filter object.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.item?view=office-pia"/>
  public object Item(int Index);
  /// <summary>
  /// Adds a filter to the collection.
  /// </summary>
  /// <param name="Column">The `Column` parameter.</param>
  /// <param name="Comparison">The `Comparison` parameter.</param>
  /// <param name="Conjunction">The `Conjunction` parameter.</param>
  /// <param name="bstrCompareTo">The `bstrCompareTo` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.add?view=office-pia"/>
  public void Add
  (string Column, FilterComparison Comparison, FilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate);
  /// <summary>
  /// Deletes a filter from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.delete?view=office-pia"/>
  public void Delete(int Index, bool DeferUpdate);
}

