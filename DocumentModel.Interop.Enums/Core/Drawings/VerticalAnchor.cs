namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the vertical alignment of text in a text frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoverticalanchor?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoVerticalAnchor")]
public enum VerticalAnchor
{
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
  [InteropEnumValue("msoVerticalAnchorMixed")]
  Mixed = -2,
  /// <summary>
  /// Aligns text to top of text frame.
  /// </summary>
  [InteropEnumValue("msoAnchorTop")]
  Top = 1,
  /// <summary>
  /// Anchors bottom of text string to current position, regardless of text resizing. When you resize text without
  /// baseline anchoring, text centers itself on previous position.
  /// </summary>
  [InteropEnumValue("msoAnchorTopBaseline")]
  TopBaseline = 2,
  /// <summary>
  /// Centers text vertically.
  /// </summary>
  [InteropEnumValue("msoAnchorMiddle")]
  Middle = 3,
  /// <summary>
  /// Aligns text to bottom of text frame.
  /// </summary>
  [InteropEnumValue("msoAnchorBottom")]
  Bottom = 4,
  /// <summary>
  /// Anchors bottom of text string to current position, regardless of text resizing. When you resize text without
  /// baseline anchoring, text centers itself on previous position.
  /// </summary>
  [InteropEnumValue("msoAnchorBottomBaseLine")]
  BottomBaseLine = 5
}
