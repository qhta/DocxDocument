namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Horizontal Anchor Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.HorizontalAnchorValues))]
public enum HorizontalAnchorType
{
  /// <summary>
  ///   Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Page))]
  Page,
  /// <summary>
  ///   Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Text))]
  Text
}