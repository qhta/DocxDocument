namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LevelSuffixValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues))]
public enum LevelSuffix
{
  /// <summary>
  ///   Tab Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues.Tab))]
  Tab,
  /// <summary>
  ///   Space Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues.Space))]
  Space,
  /// <summary>
  ///   Nothing Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues.Nothing))]
  Nothing
}