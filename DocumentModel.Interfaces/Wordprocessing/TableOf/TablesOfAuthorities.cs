namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of TableOfAuthorities objects (TOA fields) that represents the tables of authorities in a
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities?view=word-pia"/>
public partial interface TablesOfAuthorities : IModelObject, IModelCollection<TableOfAuthorities>
{
  /// <summary>
  /// Returns or sets the formatting for the tables of authorities in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities.format?view=word-pia"/>
  public ToaFormat Format { get; set; }
}
