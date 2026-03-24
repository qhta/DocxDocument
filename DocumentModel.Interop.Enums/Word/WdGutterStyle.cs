namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the gutter appears in the document.
/// </summary>
public enum WdGutterStyle
{
  /// <summary>
  /// On the left side.
  /// </summary>
  Left = unchecked((int)0),
  /// <summary>
  /// At the top.
  /// </summary>
  Top = unchecked((int)1),
  /// <summary>
  /// On the right side.
  /// </summary>
  Right = unchecked((int)2)
}
