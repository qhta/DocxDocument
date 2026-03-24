namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies alignment for the content in selected rows.
/// </summary>
public enum WdRowAlignment
{
  /// <summary>
  /// Left aligned. default.
  /// </summary>
  Left = unchecked((int)0),
  /// <summary>
  /// Centered.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Right aligned.
  /// </summary>
  Right = unchecked((int)2)
}
