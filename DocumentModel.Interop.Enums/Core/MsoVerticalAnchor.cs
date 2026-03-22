namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the vertical alignment of text in a text frame.
/// </summary>
public enum MsoVerticalAnchor
{
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Aligns text to top of text frame.
  /// </summary>
  Top = 1,
  /// <summary>
  /// Anchors bottom of text string to current position, regardless of text resizing. When you resize text without
  /// baseline anchoring, text centers itself on previous position.
  /// </summary>
  TopBaseline = 2,
  /// <summary>
  /// Centers text vertically.
  /// </summary>
  Middle = 3,
  /// <summary>
  /// Aligns text to bottom of text frame. msoAnchorBottomBaseLine5 Anchors bottom of text string to current
  /// position, regardless of text resizing. When you resize text without baseline anchoring, text centers itself on
  /// previous position.
  /// </summary>
  Bottom = 4,
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
  BottomBaseLine = 5
}
