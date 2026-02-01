namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Vertical Anchor Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.VerticalAnchorValues))]
public enum VerticalAnchorKind
{
  /// <summary>
  ///   Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Margin))]
  Margin,
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