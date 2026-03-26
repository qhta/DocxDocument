namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Vertical Anchor Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.VerticalAnchorValues))]
public enum VerticalAnchorType
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Margin))]
  Margin = 1,

  /// <summary>
  ///   Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Page))]
  Page,
  /// <summary>
  ///   Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Text))]
  Text
}