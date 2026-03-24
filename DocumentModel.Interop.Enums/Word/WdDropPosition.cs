namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a dropped capital letter.
/// </summary>
public enum WdDropPosition
{
  /// <summary>
  /// No dropped capital letter.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Dropped capital letter begins at the left margin.
  /// </summary>
  Normal = unchecked((int)1),
  /// <summary>
  /// Dropped capital letter ends at the left margin.
  /// </summary>
  Margin = unchecked((int)2)
}
