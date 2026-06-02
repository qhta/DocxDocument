namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of words in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words?view=word-pia"/>
public class Words : InteropCollection<Range>
{
  /// <summary>
  /// Returns a Range object that represents the first word in a document, selection or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.first?view=word-pia"/>
  public Range First { get; set; }
  /// <summary>
  /// Returns a Range object that represents the last word in a document, selection, or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.last?view=word-pia"/>
  public Range Last { get; set; }
}
