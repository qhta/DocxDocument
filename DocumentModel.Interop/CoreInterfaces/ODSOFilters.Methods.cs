
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ODSOFilters` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ODSOFilters
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.item?view=office-pia
  /// </remarks>
  public object Item(int Index);
  /// <summary>
  /// Invokes `Add`.
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
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.delete?view=office-pia
  /// </remarks>
  public void Delete(int Index, bool DeferUpdate);
}
