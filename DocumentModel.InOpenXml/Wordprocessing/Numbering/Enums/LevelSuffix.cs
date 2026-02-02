namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LevelSuffixValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.LevelSuffixValues))]
public enum LevelSuffix
{
  /// <summary>
  ///   Tab Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelSuffixValues.Tab))]
  Tab,
  /// <summary>
  ///   Space Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelSuffixValues.Space))]
  Space,
  /// <summary>
  ///   Nothing Between Numbering and Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelSuffixValues.Nothing))]
  Nothing
}