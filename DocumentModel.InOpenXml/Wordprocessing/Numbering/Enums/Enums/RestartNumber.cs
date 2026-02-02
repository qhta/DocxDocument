namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.RestartNumberValues))]
public enum RestartNumber
{
  /// <summary>
  ///   Continue Numbering From Previous ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RestartNumberValues.Continuous))]
  Continuous,
  /// <summary>
  ///   Restart Numbering For Each ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RestartNumberValues.EachSection))]
  EachSection,
  /// <summary>
  ///   Restart Numbering On Each Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RestartNumberValues.EachPage))]
  EachPage
}