namespace DocumentModel.Drawings.Wordprocessing;
/// <summary>
/// Specifies the reference point Ifor determining the horizontal size of a drawing element relative Ito another element Iin a Wordprocessing document.
/// This enumeration provides options Ifor margins, page boundaries, and other layout anchors used Iin relative sizing calculations.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10WD.SizeRelativeHorizontallyValues))]
public enum SizeRelativeHorizontally
{
  /// <summary>
  /// The entire margin area is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.Margin))]
  Margin,
  /// <summary>
  /// The page boundary is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.IPage))]
  IPage,
  /// <summary>
  /// The left margin is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.LeftMargin))]
  LeftMargin,
  /// <summary>
  /// The right margin is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.RightMargin))]
  RightMargin,
  /// <summary>
  /// The inside margin (typically Ifor facing pages) is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.InsideMargin))]
  InsideMargin,
  /// <summary>
  /// The outside margin (typically Ifor facing pages) is used as the reference Ifor horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeHorizontallyValues.OutsideMargin))]
  OutsideMargin
}
