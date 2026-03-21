namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfAuthorities objects (TOA fields) that represents the tables of authorities in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities?view=word-pia"/>
public partial interface TablesOfAuthorities : InteropObject, InteropCollection<TableOfAuthorities>
{
  /// <summary>
  /// Returns or sets the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities.format?view=word-pia"/>
  public WdToaFormat Format { get; set; }
}
