namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Range objects that represent all the sentences in a selection, range, or document. There is no
/// Sentence object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences?view=word-pia"/>
public interface ISentences : IModelCollection<IRange>
{
  /// <summary>
  /// Returns a Range object that represents the first sentence, word, or character in a document, selection or
  /// range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences.first?view=word-pia"/>
  public IRange First { get; }
  /// <summary>
  /// Returns a Range object that represents the last character, word, or sentence in a document, selection, or
  /// range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sentences.last?view=word-pia"/>
  public IRange Last { get; }
}
