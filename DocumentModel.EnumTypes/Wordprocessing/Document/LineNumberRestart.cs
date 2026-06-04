namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues))]
public enum LineNumberRestart
{
  /// <summary>
  ///   Restart Line Numbering on Each Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues.NewPage))]
  NewPage,
  /// <summary>
  ///   Restart Line Numbering for Each ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues.NewSection))]
  NewSection,
  /// <summary>
  ///   Continue Line Numbering From Previous ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues.Continuous))]
  Continuous
}