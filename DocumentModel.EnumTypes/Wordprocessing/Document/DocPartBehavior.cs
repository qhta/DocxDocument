namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocPartBehaviorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues))]
public enum DocPartBehavior
{
  /// <summary>
  ///   Insert Content At Specified Location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues.Content))]
  Content,
  /// <summary>
  ///   Ensure Entry Is In New Paragraph.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues.Paragraph))]
  Paragraph,
  /// <summary>
  ///   Ensure Entry Is On New Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues.Page))]
  Page
}