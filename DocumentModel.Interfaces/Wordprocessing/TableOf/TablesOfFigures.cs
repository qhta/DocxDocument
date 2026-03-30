namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of TableOfFigures objects that represent the tables of figures in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures?view=word-pia"/>
public partial interface TablesOfFigures : IModelCollection<TableOfFigures>
{
  /// <summary>
  /// Returns or sets the formatting for the tables of figures in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures.format?view=word-pia"/>
  public TofFormat Format { get; set; }
}
