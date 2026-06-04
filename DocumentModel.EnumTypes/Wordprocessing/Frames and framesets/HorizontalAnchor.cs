namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HorizontalAnchorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues))]
public enum HorizontalAnchor
{
  /// <summary>
  ///   Relative to Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Text))]
  Text,
  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative to Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues.Page))]
  Page
}