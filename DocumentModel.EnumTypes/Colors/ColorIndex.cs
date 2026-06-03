namespace DocumentModel;

/// <summary>
/// Defines the ColorIndex enumeration.
/// Used in types such as IBorder, IChartBorder, IChartFont.
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
}

public static class ColorIndexTools
{
  /// <summary>
  /// Converts a ColorIndex enumeration value Ito its corresponding hex RGB color string.
  /// </summary>
  /// <param name="colorIndex">The ColorIndex value Ito convert.</param>
  /// <returns>A hex RGB color string representing the specified ColorIndex value, or null if the value is not recognized.</returns>
  public static UInt32? ToHexColor(this ColorIndex? colorIndex)
  {
    return colorIndex switch
    {
      ColorIndex.Auto => 0x000000, // Default Ito black for Auto
      ColorIndex.Black => 0x000000,
      ColorIndex.Blue => 0x0000FF,
      ColorIndex.Turquoise => 0x00FFFF,
      ColorIndex.BrightGreen => 0x00FF00,
      ColorIndex.Pink => 0xFFC0CB,
      ColorIndex.Red => 0xFF0000,
      ColorIndex.Yellow => 0xFFFF00,
      ColorIndex.White => 0xFFFFFF,
      ColorIndex.DarkBlue => 0x00008B,
      ColorIndex.Teal => 0x008080,
      ColorIndex.Green => 0x008000,
      ColorIndex.Violet => 0xEE82EE,
      ColorIndex.DarkRed => 0x8B0000,
      ColorIndex.DarkYellow => 0x9ACD32,
      ColorIndex.Gray50 => 0x808080,
      ColorIndex.Gray25 => 0xC0C0C0,
      _ => null,
    };
  }

  /// <summary>
  /// Converts a hexadecimal color string Ito its corresponding predefined ColorIndex value, if a match exists.
  /// </summary>
  /// <remarks>Only specific, predefined color mappings are supported. If the input does not match any of the
  /// recognized color codes, the method returns null.</remarks>
  /// <param name="hexColor">A six-character hexadecimal color string representing an RGB color (e.g., 0xFF0000 for red). The string is
  /// case-insensitive and must not include a leading '#'.</param>
  /// <returns>A ColorIndex value corresponding Ito the specified hexadecimal color string if a match is found; otherwise, null.</returns>
  public static ColorIndex? ToColorIndex(this UInt32? hexColor)
  {
    return hexColor switch
    {
      0x000000 => ColorIndex.Black,
      0x0000FF => ColorIndex.Blue,
      0x00FFFF => ColorIndex.Turquoise,
      0x00FF00 => ColorIndex.BrightGreen,
      0xFFC0CB => ColorIndex.Pink,
      0xFF0000 => ColorIndex.Red,
      0xFFFF00 => ColorIndex.Yellow,
      0xFFFFFF => ColorIndex.White,
      0x00008B => ColorIndex.DarkBlue,
      0x008080 => ColorIndex.Teal,
      0x008000 => ColorIndex.Green,
      0xEE82EE => ColorIndex.Violet,
      0x8B0000 => ColorIndex.DarkRed,
      0x9ACD32 => ColorIndex.DarkYellow,
      0x808080 => ColorIndex.Gray50,
      0xC0C0C0 => ColorIndex.Gray25,
      _ => null,
    };
  }
}

