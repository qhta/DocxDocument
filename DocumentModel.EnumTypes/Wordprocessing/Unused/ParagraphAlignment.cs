namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphAlignment enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ParagraphAlignment
{
  /// <summary>Left-aligned</summary>
  [OpenXmlEnumValue("Left")]
  Left = 0,
  /// <summary>Center-aligned</summary>
  [OpenXmlEnumValue("Center")]
  Center = 1,
  /// <summary>Right-aligned</summary>
  [OpenXmlEnumValue("Right")]
  Right = 2,
  /// <summary>Fully justified</summary>
  [OpenXmlEnumValue("Justify")]
  Justify = 3,
  /// <summary>Distributed (similar to justify but with different character spacing)</summary>
  [OpenXmlEnumValue("Distribute")]
  Distribute = 4,
  /// <summary>Thai distributed</summary>
  [OpenXmlEnumValue("ThaiDistribute")]
  ThaiDistribute = 5
}
