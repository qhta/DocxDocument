namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single Hangul or alphabet AutoCorrect exception.
/// </summary>
public partial interface HangulAndAlphabetException : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
}
