namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the vertical alignment of text in a text frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoverticalanchor?view=office-pia` for Office interop details.
/// </remarks>
public enum VerticalAnchor
{
  /// <summary>
  /// Specifies the vertical alignment of text in a text frame.
  /// </summary>
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
  /// Aligns text to bottom of text frame.
  /// </summary>
  Bottom = 4,
  /// <summary>
  /// Anchors bottom of text string to current position, regardless of text resizing. When you resize text without
  /// baseline anchoring, text centers itself on previous position.
  /// </summary>
  BottomBaseLine = 5
}
