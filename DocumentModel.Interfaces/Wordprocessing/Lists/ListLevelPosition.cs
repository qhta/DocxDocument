namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ListLevelPosition enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ListLevelPosition
{
  /// <summary>Position relative to left margin</summary>
  [OpenXmlEnumValue("Left")]
  Left = 0,
  /// <summary>Position centered</summary>
  [OpenXmlEnumValue("Center")]
  Center = 1,
  /// <summary>Position relative to right margin</summary>
  [OpenXmlEnumValue("Right")]
  Right = 2
}
