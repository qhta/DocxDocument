namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a variable stored as part of a document. Document variables are used to preserve macro settings in between macro sessions.
/// </summary>
public partial interface Variable : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
}
