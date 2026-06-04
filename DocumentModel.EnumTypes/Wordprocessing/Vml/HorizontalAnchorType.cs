namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Horizontal Anchor Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues))]
public enum HorizontalAnchorType
{
  /// <summary>
  ///   Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Page))]
  Page,
  /// <summary>
  ///   Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Text))]
  Text
}