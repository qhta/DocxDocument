namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum ThemeColorIndex
{
  NotThemeColor = -1, // 0xFFFFFFFF
  MainDark1 = 0,
  MainLight1 = 1,
  MainDark2 = 2,
  MainLight2 = 3,
  Accent1 = 4,
  Accent2 = 5,
  Accent3 = 6,
  Accent4 = 7,
  Accent5 = 8,
  Accent6 = 9,
  Hyperlink = 10, // 0x0000000A
  HyperlinkFollowed = 11, // 0x0000000B
  Background1 = 12, // 0x0000000C
  Text1 = 13, // 0x0000000D
  Background2 = 14, // 0x0000000E
  Text2 = 15, // 0x0000000F
}