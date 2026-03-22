namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the document text should wrap on both sides of the specified shape, on either the left or
/// right side only, or on the side of the shape that is farthest from the page margin.
/// </summary>
public enum WdWrapSideType
{
  /// <summary>
  /// Both sides of the specified shape.
  /// </summary>
  wdWrapBoth = unchecked((int)0),
  /// <summary>
  /// Left side of shape only.
  /// </summary>
  wdWrapLeft = unchecked((int)1),
  /// <summary>
  /// Right side of shape only.
  /// </summary>
  wdWrapRight = unchecked((int)2),
  /// <summary>
  /// Side of the shape that is farthest from the page margin.
  /// </summary>
  wdWrapLargest = unchecked((int)3)
}
