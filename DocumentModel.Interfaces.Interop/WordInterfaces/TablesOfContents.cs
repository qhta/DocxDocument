namespace DocumentModel.Interop;

/// <summary>
/// A collection of TableOfContents objects that represent the tables of contents in a document.
/// </summary>
public partial interface TablesOfContents : InteropObject, InteropCollection<TableOfContents>
{
  /// <summary>
  /// The format.
  /// </summary>
  public WdTocFormat Format { get; set; }
}
