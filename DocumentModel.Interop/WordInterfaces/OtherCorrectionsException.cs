namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoCorrect exception.
/// </summary>
public partial interface OtherCorrectionsException : InteropObject
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
