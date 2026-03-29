namespace DocumentModel;

/// <summary>
/// Defines the ColorIndex enumeration.
/// Used in types such as Border, ChartBorder, ChartFont.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ColorIndex
{
  /// <summary>Automatic color</summary>
  [OpenXmlEnumValue("Auto")]
  Auto = 0,
  /// <summary>Black</summary>
  [OpenXmlEnumValue("Black")]
  Black = 1,
  /// <summary>Blue</summary>
  [OpenXmlEnumValue("Blue")]
  Blue = 2,
  /// <summary>Turquoise (Cyan)</summary>
  [OpenXmlEnumValue("Turquoise")]
  Turquoise = 3,
  /// <summary>Bright Green</summary>
  [OpenXmlEnumValue("BrightGreen")]
  BrightGreen = 4,
  /// <summary>Pink</summary>
  [OpenXmlEnumValue("Pink")]
  Pink = 5,
  /// <summary>Red</summary>
  [OpenXmlEnumValue("Red")]
  Red = 6,
  /// <summary>Yellow</summary>
  [OpenXmlEnumValue("Yellow")]
  Yellow = 7,
  /// <summary>White</summary>
  [OpenXmlEnumValue("White")]
  White = 8,
  /// <summary>Dark Blue</summary>
  [OpenXmlEnumValue("DarkBlue")]
  DarkBlue = 9,
  /// <summary>Teal</summary>
  [OpenXmlEnumValue("Teal")]
  Teal = 10,
  /// <summary>Green</summary>
  [OpenXmlEnumValue("Green")]
  Green = 11,
  /// <summary>Violet</summary>
  [OpenXmlEnumValue("Violet")]
  Violet = 12,
  /// <summary>Dark Red</summary>
  [OpenXmlEnumValue("DarkRed")]
  DarkRed = 13,
  /// <summary>Dark Yellow</summary>
  [OpenXmlEnumValue("DarkYellow")]
  DarkYellow = 14,
  /// <summary>Gray 50%</summary>
  [OpenXmlEnumValue("Gray50")]
  Gray50 = 15,
  /// <summary>Gray 25%</summary>
  [OpenXmlEnumValue("Gray25")]
  Gray25 = 16,
  /// <summary>
  /// Color defined by document author.
  /// </summary>
  ByAuthor = -1
}
