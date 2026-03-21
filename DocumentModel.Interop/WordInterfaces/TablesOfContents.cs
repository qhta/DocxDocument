namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfContents objects that represent the tables of contents in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents?view=word-pia"/>
public partial interface TablesOfContents : InteropObject, InteropCollection<TableOfContents>
{
  /// <summary>
  /// Returns or sets the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents.format?view=word-pia"/>
  public WdTocFormat Format { get; set; }
}
