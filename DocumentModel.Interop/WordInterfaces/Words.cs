namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of words in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words?view=word-pia"/>
public interface Words : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The first.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.first?view=word-pia"/>
  public Range First { get; }
  /// <summary>
  /// The last.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.last?view=word-pia"/>
  public Range Last { get; }
}
