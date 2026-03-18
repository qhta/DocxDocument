namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TrailingCharacter enumeration.
/// Used in types such as ListLevel.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum TrailingCharacter
{
  /// <summary>Tab character</summary>
  [OpenXmlEnumValue("Tab")]
  Tab = 0,
  /// <summary>Space character</summary>
  [OpenXmlEnumValue("Space")]
  Space = 1,
  /// <summary>No trailing character</summary>
  [OpenXmlEnumValue("Nothing")]
  Nothing = 2
}
