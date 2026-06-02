namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list format that's been applied to specified paragraphs in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list?view=word-pia"/>
public partial class List : InteropObject
{
  /// <summary>
  /// Returns a range object that represents the portion of a document that's contained in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Returns a list paragraphs collection that represents all paragraphs in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; set; }

  /// <summary>
  /// Returns whether only one list template is used for all paragraphs in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; set; }

  /// <summary>
  /// Returns the style name for the first paragraph in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.stylename?view=word-pia"/>
  public string? StyleName { get; set; }


  #region methods

/// <summary>
  /// Converts list numbers and LISTNUM fields in the list to text.
  /// </summary>
  /// <param name="NumberType">The type of number format to convert.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.convertnumberstotext?view=word-pia"/>
  public void ConvertNumbersToText(NumberType NumberType) { throw new NotImplementedException(); }

  #endregion methods
}
