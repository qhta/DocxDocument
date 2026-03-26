namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents all chart categories in the document, whether visible (unfiltered) or not.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory?view=word-pia"/>
public interface ChartCategory : InteropObject
{
  /// <summary>
  /// Gets the name of the chart category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart category is filtered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory.isfiltered?view=word-pia"/>
  public bool IsFiltered { get; set; }

}
