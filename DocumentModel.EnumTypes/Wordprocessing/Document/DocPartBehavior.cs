namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocPartBehaviorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocPartBehaviorValues))]
public enum DocPartBehavior
{
  /// <summary>
  ///   Insert Content At Specified Location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartBehaviorValues.Content))]
  Content,
  /// <summary>
  ///   Ensure Entry Is In New Paragraph.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartBehaviorValues.Paragraph))]
  Paragraph,
  /// <summary>
  ///   Ensure Entry Is On New Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartBehaviorValues.Page))]
  Page
}