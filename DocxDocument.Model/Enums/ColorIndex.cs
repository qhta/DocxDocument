namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum ColorIndex
{
  ByAuthor = -1, // 0xFFFFFFFF
  Auto = 0,
  Black = 1,
  Blue = 2,
  Turquoise = 3,
  BrightGreen = 4,
  Pink = 5,
  Red = 6,
  Yellow = 7,
  White = 8,
  DarkBlue = 9,
  Teal = 10, // 0x0000000A
  Green = 11, // 0x0000000B
  Violet = 12, // 0x0000000C
  DarkRed = 13, // 0x0000000D
  DarkYellow = 14, // 0x0000000E
  Gray50 = 15, // 0x0000000F
  Gray25 = 16, // 0x00000010
}