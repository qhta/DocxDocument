namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ListLevelAlignment enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ListLevelAlignment
{
  /// <summary>Left-aligned</summary>
  [OpenXmlEnumValue("Left")]
  Left = 0,
  /// <summary>Center-aligned</summary>
  [OpenXmlEnumValue("Center")]
  Center = 1,
  /// <summary>Right-aligned</summary>
  [OpenXmlEnumValue("Right")]
  Right = 2
}
