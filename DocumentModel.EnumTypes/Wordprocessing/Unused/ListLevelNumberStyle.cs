namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ListLevelNumberStyle enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ListLevelNumberStyle
{
  /// <summary>Standard numbering</summary>
  [OpenXmlEnumValue("Standard")]
  Standard = 0,
  /// <summary>Legal numbering (1.1.1.)</summary>
  [OpenXmlEnumValue("Legal")]
  Legal = 1,
  /// <summary>Simplified legal numbering (1.1.a)</summary>
  [OpenXmlEnumValue("SimplifiedLegal")]
  SimplifiedLegal = 2
}
