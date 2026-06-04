namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the horizontal alignment of text in a text frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohorizontalanchor?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoHorizontalAnchor")]
public enum HorizontalAnchor
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoHorizontalAnchorMixed")]
  HorizontalAnchorMixed = -2,
  /// <summary>
  /// No alignment.
  /// </summary>
  [InteropEnumValue("msoAnchorNone")]
  AnchorNone = 1,
  /// <summary>
  /// Text is centered horizontally.
  /// </summary>
  [InteropEnumValue("msoAnchorCenter")]
  AnchorCenter = 2
}
