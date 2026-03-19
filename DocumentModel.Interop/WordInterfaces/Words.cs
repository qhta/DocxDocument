namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of words in a selection, range, or document.
/// </summary>
public interface Words : InteropObject, InteropCollection<Range>
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
