namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalAnchorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues))]
public enum VerticalAnchor
{
  /// <summary>
  ///   Relative To Vertical Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Text))]
  Text = 1,

  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative To Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues.Page))]
  Page
}