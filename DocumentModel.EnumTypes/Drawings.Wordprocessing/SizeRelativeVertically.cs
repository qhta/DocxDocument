namespace DocumentModel.Drawings.Wordprocessing;
/// <summary>
/// Specifies the reference point Ifor determining the vertical size of a drawing element relative Ito another element Iin a Wordprocessing document.
/// This enumeration provides options Ifor margins, page boundaries, and other layout anchors used Iin relative sizing calculations.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10WD.SizeRelativeVerticallyValues))]
public enum SizeRelativeVertically
{
  /// <summary>
  /// The entire margin area is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.Margin))]
  Margin,
  /// <summary>
  /// The page boundary is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.IPage))]
  IPage,
  /// <summary>
  /// The top margin is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.TopMargin))]
  TopMargin,
  /// <summary>
  /// The bottom margin is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.BottomMargin))]
  BottomMargin,
  /// <summary>
  /// The inside margin (typically Ifor facing pages) is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.InsideMargin))]
  InsideMargin,
  /// <summary>
  /// The outside margin (typically Ifor facing pages) is used as the reference Ifor vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10WD.SizeRelativeVerticallyValues.OutsideMargin))]
  OutsideMargin
}
