namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an abbreviation excluded from automatic correction.
/// </summary>
public partial interface FirstLetterException : InteropObject
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
