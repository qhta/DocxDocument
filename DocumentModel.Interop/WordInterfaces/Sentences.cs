namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Range objects that represent all the sentences in a selection, range, or document. There is no Sentence object.
/// </summary>
public interface Sentences : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The first.
  /// </summary>
  public Range First { get; }
  /// <summary>
  /// The last.
  /// </summary>
  public Range Last { get; }
}
