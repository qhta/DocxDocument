namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of words in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words?view=word-pia"/>
public interface Words : IModelCollection<IRange>
{
  /// <summary>
  /// Returns a Range object that represents the first word in a document, selection or range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.first?view=word-pia"/>
  public IRange First { get; }
  /// <summary>
  /// Returns a Range object that represents the last word in a document, selection, or range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.words.last?view=word-pia"/>
  public IRange Last { get; }
}
