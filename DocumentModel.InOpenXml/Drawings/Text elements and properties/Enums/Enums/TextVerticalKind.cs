namespace DocumentModel.Drawings;
/// <summary>
///   Vertical Text Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextVerticalValues))]
public enum TextVerticalKind
{
  /// <summary>
  ///   Vertical Text Type Enum ( Horizontal ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical Text Type Enum ( Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Vertical Text Type Enum ( Vertical 270 ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.Vertical270))]
  Vertical270,
  /// <summary>
  ///   Vertical Text Type Enum ( WordArt Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.WordArtVertical))]
  WordArtVertical,
  /// <summary>
  ///   Vertical Text Type Enum ( East Asian Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.EastAsianVetical))]
  EastAsianVetical,
  /// <summary>
  ///   Vertical Text Type Enum ( Mongolian Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.MongolianVertical))]
  MongolianVertical,
  /// <summary>
  ///   Vertical WordArt Right to Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalValues.WordArtLeftToRight))]
  WordArtLeftToRight
}