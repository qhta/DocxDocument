namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all chart categories in the document, whether visible (unfiltered) or not.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory?view=word-pia"/>
public interface ChartCategory : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The is filtered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcategory.isfiltered?view=word-pia"/>
  public bool IsFiltered { get; set; }

}
