namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.LineNumberRestartValues))]
public enum LineNumberRestart
{
  /// <summary>
  ///   Restart Line Numbering on Each Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineNumberRestartValues.NewPage))]
  NewPage,
  /// <summary>
  ///   Restart Line Numbering for Each ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineNumberRestartValues.NewSection))]
  NewSection,
  /// <summary>
  ///   Continue Line Numbering From Previous ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineNumberRestartValues.Continuous))]
  Continuous
}