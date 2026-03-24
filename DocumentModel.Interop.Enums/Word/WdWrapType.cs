namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
public enum WdWrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  Square = unchecked((int)0),
  /// <summary>
  /// Tight. wdWrapThrough2 Through.
  /// </summary>
  Tight = unchecked((int)1),
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  Through = unchecked((int)2),
  /// <summary>
  /// Behind text. wdWrapTopBottom4 Top and bottom.
  /// </summary>
  None = unchecked((int)3),
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  Front = unchecked((int)3),
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  TopBottom = unchecked((int)4),
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  Behind = unchecked((int)5),
  /// <summary>
  /// In line with text.
  /// </summary>
  Inline = unchecked((int)7)
}
