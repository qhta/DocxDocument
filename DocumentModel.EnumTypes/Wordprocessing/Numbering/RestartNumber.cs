namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues))]
public enum RestartNumber
{
  /// <summary>
  ///   Continue Numbering From Previous ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues.Continuous))]
  Continuous,
  /// <summary>
  ///   Restart Numbering For Each ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues.EachSection))]
  EachSection,
  /// <summary>
  ///   Restart Numbering On Each Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues.EachPage))]
  EachPage
}