namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
public enum WdWrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  wdWrapSquare = unchecked((int)0),
  /// <summary>
  /// Tight. wdWrapThrough2 Through.
  /// </summary>
  wdWrapTight = unchecked((int)1),
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  wdWrapThrough = unchecked((int)2),
  /// <summary>
  /// Behind text. wdWrapTopBottom4 Top and bottom.
  /// </summary>
  wdWrapNone = unchecked((int)3),
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  wdWrapFront = unchecked((int)3),
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  wdWrapTopBottom = unchecked((int)4),
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  wdWrapBehind = unchecked((int)5),
  /// <summary>
  /// In line with text.
  /// </summary>
  wdWrapInline = unchecked((int)7)
}
