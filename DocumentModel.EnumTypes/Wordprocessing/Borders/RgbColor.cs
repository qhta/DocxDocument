namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the 24-bit color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolor?view=office-pia` for Office interop details.
/// </remarks>
public enum RgbColor
{
  /// <summary>
  /// Black color.
  /// </summary>
  Black = 0x000000,
  /// <summary>
  /// Dark red color.
  /// </summary>
  DarkRed = 0x000080,
  /// <summary>
  /// Red color.
  /// </summary>
  Red = 0x0000FF,
  /// <summary>
  /// Dark green color.
  /// </summary>
  DarkGreen = 0x003300,
  /// <summary>
  /// Olive green color.
  /// </summary>
  OliveGreen = 0x003333,
  /// <summary>
  /// Brown color.
  /// </summary>
  Brown = 0x003399,
  /// <summary>
  /// Orange color.
  /// </summary>
  Orange = 0x0066FF,
  /// <summary>
  /// Green color.
  /// </summary>
  Green = 0x008000,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  DarkYellow = 0x008080,
  /// <summary>
  /// Light orange color.
  /// </summary>
  LightOrange = 0x0099FF,
  /// <summary>
  /// Lime color.
  /// </summary>
  Lime = 0x00CC99,
  /// <summary>
  /// Gold color.
  /// </summary>
  Gold = 0x00CCFF,
  /// <summary>
  /// Bright green color.
  /// </summary>
  BrightGreen = 0x00FF00,
  /// <summary>
  /// Yellow color.
  /// </summary>
  Yellow = 0x00FFFF,
  /// <summary>
  /// Shade 95 of gray color.
  /// </summary>
  Gray95 = 0x0C0C0C,
  /// <summary>
  /// Shade 90 of gray color.
  /// </summary>
  Gray90 = 0x191919,
  /// <summary>
  /// Shade 875 of gray color.
  /// </summary>
  Gray875 = 0x202020,
  /// <summary>
  /// Shade 85 of gray color.
  /// </summary>
  Gray85 = 0x262626,
  /// <summary>
  /// Shade 80 of gray color.
  /// </summary>
  Gray80 = 0x333333,
  /// <summary>
  /// Shade 75 of gray color.
  /// </summary>
  Gray75 = 0x404040,
  /// <summary>
  /// Shade 70 of gray color.
  /// </summary>
  Gray70 = 0x4C4C4C,
  /// <summary>
  /// Shade 65 of gray color.
  /// </summary>
  Gray65 = 0x595959,
  /// <summary>
  /// Shade 625 of gray color.
  /// </summary>
  Gray625 = 0x606060,
  /// <summary>
  /// Dark teal color.
  /// </summary>
  DarkTeal = 0x663300,
  /// <summary>
  /// Plum color.
  /// </summary>
  Plum = 0x663399,
  /// <summary>
  /// Shade 60 of gray color.
  /// </summary>
  Gray60 = 0x666666,
  /// <summary>
  /// Sea green color.
  /// </summary>
  SeaGreen = 0x669933,
  /// <summary>
  /// Shade 55 of gray color.
  /// </summary>
  Gray55 = 0x737373,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  DarkBlue = 0x800000,
  /// <summary>
  /// Violet color.
  /// </summary>
  Violet = 0x800080,
  /// <summary>
  /// Teal color.
  /// </summary>
  Teal = 0x808000,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  Gray50 = 0x808080,
  /// <summary>
  /// Shade 45 of gray color.
  /// </summary>
  Gray45 = 0x8C8C8C,
  /// <summary>
  /// Indigo color.
  /// </summary>
  Indigo = 0x993333,
  /// <summary>
  /// Blue-gray color.
  /// </summary>
  BlueGray = 0x996666,
  /// <summary>
  /// Shade 40 of gray color.
  /// </summary>
  Gray40 = 0x999999,
  /// <summary>
  /// Tan color.
  /// </summary>
  Tan = 0x99CCFF,
  /// <summary>
  /// Light yellow color.
  /// </summary>
  LightYellow = 0x99FFFF,
  /// <summary>
  /// Shade 375 of gray color.
  /// </summary>
  Gray375 = 0xA0A0A0,
  /// <summary>
  /// Shade 35 of gray color.
  /// </summary>
  Gray35 = 0xA6A6A6,
  /// <summary>
  /// Shade 30 of gray color.
  /// </summary>
  Gray30 = 0xB3B3B3,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  Gray25 = 0xC0C0C0,
  /// <summary>
  /// Rose color.
  /// </summary>
  Rose = 0xCC99FF,
  /// <summary>
  /// Aqua color.
  /// </summary>
  Aqua = 0xCCCC33,
  /// <summary>
  /// Shade 20 of gray color.
  /// </summary>
  Gray20 = 0xCCCCCC,
  /// <summary>
  /// Light green color.
  /// </summary>
  LightGreen = 0xCCFFCC,
  /// <summary>
  /// Shade 15 of gray color.
  /// </summary>
  Gray15 = 0xD9D9D9,
  /// <summary>
  /// Shade 125 of gray color.
  /// </summary>
  Gray125 = 0xE0E0E0,
  /// <summary>
  /// Shade 10 of gray color.
  /// </summary>
  Gray10 = 0xE6E6E6,
  /// <summary>
  /// Shade 05 of gray color.
  /// </summary>
  Gray05 = 0xF3F3F3,
  /// <summary>
  /// Blue color.
  /// </summary>
  Blue = 0xFF0000,
  /// <summary>
  /// Pink color.
  /// </summary>
  Pink = 0xFF00FF,
  /// <summary>
  /// Light blue color.
  /// </summary>
  LightBlue = 0xFF6633,
  /// <summary>
  /// Lavender color.
  /// </summary>
  Lavender = 0xFF99CC,
  /// <summary>
  /// Sky blue color.
  /// </summary>
  SkyBlue = 0xFFCC00,
  /// <summary>
  /// Pale blue color.
  /// </summary>
  PaleBlue = 0xFFCC99,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  Turquoise = 0xFFFF00,
  /// <summary>
  /// Light turquoise color.
  /// </summary>
  LightTurquoise = 0xFFFFCC,
  /// <summary>
  /// White color.
  /// </summary>
  White = 0xFFFFFF,
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  Automatic = -16777216
}

