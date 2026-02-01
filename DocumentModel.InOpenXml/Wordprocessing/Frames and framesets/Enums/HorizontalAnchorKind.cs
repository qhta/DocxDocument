namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HorizontalAnchorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.HorizontalAnchorValues))]
public enum HorizontalAnchorKind
{
  /// <summary>
  ///   Relative to Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Text))]
  Text,
  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative to Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.HorizontalAnchorValues.Page))]
  Page
}