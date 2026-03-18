namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType enumeration.
/// Used in types such as ColorType, PropertySet, ColorType(T).
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ColorType
{
  /// <summary>Auto color</summary>
  [OpenXmlEnumValue("Auto")]
  Auto,
  /// <summary>Black</summary>
  [OpenXmlEnumValue("Black")]
  Black,
  /// <summary>Blue</summary>
  [OpenXmlEnumValue("Blue")]
  Blue,
  /// <summary>Bright green</summary>
  [OpenXmlEnumValue("BrightGreen")]
  BrightGreen,
  /// <summary>Dark blue</summary>
  [OpenXmlEnumValue("DarkBlue")]
  DarkBlue,
  /// <summary>Dark red</summary>
  [OpenXmlEnumValue("DarkRed")]
  DarkRed,
  /// <summary>Dark yellow</summary>
  [OpenXmlEnumValue("DarkYellow")]
  DarkYellow,
  /// <summary>Gray 25%</summary>
  [OpenXmlEnumValue("Gray25")]
  Gray25,
  /// <summary>Gray 50%</summary>
  [OpenXmlEnumValue("Gray50")]
  Gray50,
  /// <summary>Green</summary>
  [OpenXmlEnumValue("Green")]
  Green,
  /// <summary>Pink</summary>
  [OpenXmlEnumValue("Pink")]
  Pink,
  /// <summary>Red</summary>
  [OpenXmlEnumValue("Red")]
  Red,
  /// <summary>Teal</summary>
  [OpenXmlEnumValue("Teal")]
  Teal,
  /// <summary>Turquoise</summary>
  [OpenXmlEnumValue("Turquoise")]
  Turquoise,
  /// <summary>Violet</summary>
  [OpenXmlEnumValue("Violet")]
  Violet,
  /// <summary>White</summary>
  [OpenXmlEnumValue("White")]
  White,
  /// <summary>Yellow</summary>
  [OpenXmlEnumValue("Yellow")]
  Yellow,
  /// <summary>No highlight</summary>
  [OpenXmlEnumValue("None")]
  None
}
