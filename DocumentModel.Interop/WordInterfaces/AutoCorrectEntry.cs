namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoCorrect entry.
/// </summary>
public partial interface AutoCorrectEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The rich text.
  /// </summary>
  public bool RichText { get; }
}
