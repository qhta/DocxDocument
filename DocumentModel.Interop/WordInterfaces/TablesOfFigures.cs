namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfFigures objects that represent the tables of figures in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures?view=word-pia"/>
public partial interface TablesOfFigures : InteropObject, InteropCollection<TableOfFigures>
{
  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures.format?view=word-pia"/>
  public WdTofFormat Format { get; set; }
}
