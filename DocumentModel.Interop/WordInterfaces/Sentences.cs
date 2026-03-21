namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Range objects that represent all the sentences in a selection, range, or document. There is no Sentence object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences?view=word-pia"/>
public interface Sentences : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The first.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences.first?view=word-pia"/>
  public Range First { get; }
  /// <summary>
  /// The last.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences.last?view=word-pia"/>
  public Range Last { get; }
}
