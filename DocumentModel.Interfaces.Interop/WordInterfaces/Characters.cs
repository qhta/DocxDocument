namespace DocumentModel.Interop;

/// <summary>
/// A collection of characters in a selection, range, or document.
/// </summary>
public interface Characters : InteropObject, InteropCollection<Range>
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
