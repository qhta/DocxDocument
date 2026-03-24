namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
public enum WdWrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  Inline = unchecked((int)0),
  /// <summary>
  /// Square.
  /// </summary>
  Square = unchecked((int)1),
  /// <summary>
  /// Tight.
  /// </summary>
  Tight = unchecked((int)2),
  /// <summary>
  /// Behind text.
  /// </summary>
  Behind = unchecked((int)3),
  /// <summary>
  /// In front of text.
  /// </summary>
  Front = unchecked((int)4),
  /// <summary>
  /// Through.
  /// </summary>
  Through = unchecked((int)5),
  /// <summary>
  /// Top and bottom.
  /// </summary>
  TopBottom = unchecked((int)6)
}
