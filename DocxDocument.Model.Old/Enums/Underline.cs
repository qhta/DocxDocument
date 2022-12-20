namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum Underline
{
  None = 0,
  Single = 1,
  Words = 2,
  Double = 3,
  Dotted = 4,
  Thick = 6,
  Dash = 7,
  DotDash = 9,
  DotDotDash = 10, // 0x0000000A
  Wavy = 11, // 0x0000000B
  DottedHeavy = 20, // 0x00000014
  DashHeavy = 23, // 0x00000017
  DotDashHeavy = 25, // 0x00000019
  DotDotDashHeavy = 26, // 0x0000001A
  WavyHeavy = 27, // 0x0000001B
  DashLong = 39, // 0x00000027
  WavyDouble = 43, // 0x0000002B
  DashLongHeavy = 55, // 0x00000037
}