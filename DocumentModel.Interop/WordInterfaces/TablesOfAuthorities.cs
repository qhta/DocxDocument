namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfAuthorities objects (TOA fields) that represents the tables of authorities in a document.
/// </summary>
public partial interface TablesOfAuthorities : InteropObject, InteropCollection<TableOfAuthorities>
{
  /// <summary>
  /// The format.
  /// </summary>
  public WdToaFormat Format { get; set; }
}
