namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalAnchorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.VerticalAnchorValues))]
public enum VerticalAnchor
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Relative To Vertical Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Text))]
  Text = 1,

  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative To Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.VerticalAnchorValues.Page))]
  Page
}