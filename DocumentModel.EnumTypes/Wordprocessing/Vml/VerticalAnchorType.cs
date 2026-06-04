namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Vertical Anchor Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues))]
public enum VerticalAnchorType
{
  /// <summary>
  ///   Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Margin))]
  Margin = 1,

  /// <summary>
  ///   Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Page))]
  Page,
  /// <summary>
  ///   Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Text))]
  Text
}