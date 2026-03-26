namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the reference point for determining the horizontal size of a drawing element relative to another element in a Wordprocessing document.
/// This enumeration provides options for margins, page boundaries, and other layout anchors used in relative sizing calculations.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10WD.SizeRelativeHorizontallyValues))]
public enum RelativeHorizontalSize
{
  /// <summary>
  /// The entire margin area is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.Margin))]
  Margin,
  /// <summary>
  /// The page boundary is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.Page))]
  Page,
  /// <summary>
  /// The left margin is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.LeftMargin))]
  LeftMargin,
  /// <summary>
  /// The right margin is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.RightMargin))]
  RightMargin,
  /// <summary>
  /// The inside margin (typically for facing pages) is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.InsideMargin))]
  InsideMargin,
  /// <summary>
  /// The outside margin (typically for facing pages) is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.OutsideMargin))]
  OutsideMargin
}