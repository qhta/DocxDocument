namespace DocumentModel.Drawings;
/// <summary>
///   Vertical Text Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextVerticalValues))]
public enum TextVertical
{
  /// <summary>
  ///   Vertical Text Type Enum ( Horizontal ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical Text Type Enum ( Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Vertical Text Type Enum ( Vertical 270 ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.Vertical270))]
  Vertical270,
  /// <summary>
  ///   Vertical Text Type Enum ( WordArt Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.WordArtVertical))]
  WordArtVertical,
  /// <summary>
  ///   Vertical Text Type Enum ( East Asian Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.EastAsianVetical))]
  EastAsianVetical,
  /// <summary>
  ///   Vertical Text Type Enum ( Mongolian Vertical ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.MongolianVertical))]
  MongolianVertical,
  /// <summary>
  ///   Vertical WordArt Right to Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalValues.WordArtLeftToRight))]
  WordArtLeftToRight
}
