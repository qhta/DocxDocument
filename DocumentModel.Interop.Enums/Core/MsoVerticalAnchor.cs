namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the vertical alignment of text in a text frame.
/// </summary>
public enum MsoVerticalAnchor
{
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
  msoVerticalAnchorMixed = -2,
  /// <summary>
  /// Aligns text to top of text frame.
  /// </summary>
  msoAnchorTop = 1,
  /// <summary>
  /// Anchors bottom of text string to current position, regardless of text resizing. When you resize text without
  /// baseline anchoring, text centers itself on previous position.
  /// </summary>
  msoAnchorTopBaseline = 2,
  /// <summary>
  /// Centers text vertically.
  /// </summary>
  msoAnchorMiddle = 3,
  /// <summary>
  /// Aligns text to bottom of text frame. msoAnchorBottomBaseLine5 Anchors bottom of text string to current
  /// position, regardless of text resizing. When you resize text without baseline anchoring, text centers itself on
  /// previous position.
  /// </summary>
  msoAnchorBottom = 4,
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
  msoAnchorBottomBaseLine = 5
}
