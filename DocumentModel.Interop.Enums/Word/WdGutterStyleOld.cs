namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the gutter style should conform to left-to-right text flow or right-to-left text flow.
/// </summary>
public enum WdGutterStyleOld
{
  /// <summary>
  /// Bidirectional gutter should be used to conform to right-to-left text flow.
  /// </summary>
  Bidi = unchecked((int)2),
  /// <summary>
  /// Specifies whether the gutter style should conform to left-to-right text flow or right-to-left text flow.
  /// </summary>
  Latin = unchecked((int)-10)
}
