namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single initial-capital AutoCorrect exception.
/// </summary>
public partial interface TwoInitialCapsException : InteropObject
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
