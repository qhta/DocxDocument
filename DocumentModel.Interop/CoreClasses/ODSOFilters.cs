
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia"/>
public partial class ODSOFilters: InteropCollection<object>
{



  #region methods

/// <summary>
  /// Adds a filter to the collection.
  /// </summary>
  /// <param name="Column">The `Column` parameter.</param>
  /// <param name="Comparison">The `Comparison` parameter.</param>
  /// <param name="Conjunction">The `Conjunction` parameter.</param>
  /// <param name="bstrCompareTo">The `bstrCompareTo` parameter.</param>
  /// <param name="DeferUpdate">The `DeferUpdate` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.add?view=office-pia"/>
  public void Add
  (string Column, FilterComparison Comparison, FilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes a filter from the collection.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <param name="deferUpdate">The `DeferUpdate` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.delete?view=office-pia"/>
  public void Delete(int index, bool deferUpdate) { throw new NotImplementedException(); }

  #endregion methods
}

