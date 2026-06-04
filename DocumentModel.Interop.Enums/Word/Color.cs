namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the 24-bit color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdColor")]
public enum PresetColors
{
  /// <summary>
  /// Black color.
  /// </summary>
  [WordInteropEnumValue("wdColorBlack")]
  Black = 0,
  /// <summary>
  /// Dark red color.
  /// </summary>
  [WordInteropEnumValue("wdColorDarkRed")]
  DarkRed = 128,
  /// <summary>
  /// Red color.
  /// </summary>
  [WordInteropEnumValue("wdColorRed")]
  Red = 255,
  /// <summary>
  /// Dark green color.
  /// </summary>
  [WordInteropEnumValue("wdColorDarkGreen")]
  DarkGreen = 13056,
  /// <summary>
  /// Olive green color.
  /// </summary>
  [WordInteropEnumValue("wdColorOliveGreen")]
  OliveGreen = 13107,
  /// <summary>
  /// Brown color.
  /// </summary>
  [WordInteropEnumValue("wdColorBrown")]
  Brown = 13209,
  /// <summary>
  /// Orange color.
  /// </summary>
  [WordInteropEnumValue("wdColorOrange")]
  Orange = 26367,
  /// <summary>
  /// Green color.
  /// </summary>
  [WordInteropEnumValue("wdColorGreen")]
  Green = 32768,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  [WordInteropEnumValue("wdColorDarkYellow")]
  DarkYellow = 32896,
  /// <summary>
  /// Light orange color.
  /// </summary>
  [WordInteropEnumValue("wdColorLightOrange")]
  LightOrange = 39423,
  /// <summary>
  /// Lime color.
  /// </summary>
  [WordInteropEnumValue("wdColorLime")]
  Lime = 52377,
  /// <summary>
  /// Gold color.
  /// </summary>
  [WordInteropEnumValue("wdColorGold")]
  Gold = 52479,
  /// <summary>
  /// Bright green color.
  /// </summary>
  [WordInteropEnumValue("wdColorBrightGreen")]
  BrightGreen = 65280,
  /// <summary>
  /// Yellow color.
  /// </summary>
  [WordInteropEnumValue("wdColorYellow")]
  Yellow = 65535,
  /// <summary>
  /// Shade 95 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray95")]
  Gray95 = 789516,
  /// <summary>
  /// Shade 90 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray90")]
  Gray90 = 1644825,
  /// <summary>
  /// Shade 875 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray875")]
  Gray875 = 2105376,
  /// <summary>
  /// Shade 85 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray85")]
  Gray85 = 2500134,
  /// <summary>
  /// Shade 80 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray80")]
  Gray80 = 3355443,
  /// <summary>
  /// Shade 75 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray75")]
  Gray75 = 4210752,
  /// <summary>
  /// Shade 70 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray70")]
  Gray70 = 5000268,
  /// <summary>
  /// Shade 65 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray65")]
  Gray65 = 5855577,
  /// <summary>
  /// Shade 625 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray625")]
  Gray625 = 6316128,
  /// <summary>
  /// Dark teal color.
  /// </summary>
  [WordInteropEnumValue("wdColorDarkTeal")]
  DarkTeal = 6697728,
  /// <summary>
  /// Plum color.
  /// </summary>
  [WordInteropEnumValue("wdColorPlum")]
  Plum = 6697881,
  /// <summary>
  /// Shade 60 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray60")]
  Gray60 = 6710886,
  /// <summary>
  /// Sea green color.
  /// </summary>
  [WordInteropEnumValue("wdColorSeaGreen")]
  SeaGreen = 6723891,
  /// <summary>
  /// Shade 55 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray55")]
  Gray55 = 7566195,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  [WordInteropEnumValue("wdColorDarkBlue")]
  DarkBlue = 8388608,
  /// <summary>
  /// Violet color.
  /// </summary>
  [WordInteropEnumValue("wdColorViolet")]
  Violet = 8388736,
  /// <summary>
  /// Teal color.
  /// </summary>
  [WordInteropEnumValue("wdColorTeal")]
  Teal = 8421376,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray50")]
  Gray50 = 8421504,
  /// <summary>
  /// Shade 45 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray45")]
  Gray45 = 9211020,
  /// <summary>
  /// Indigo color.
  /// </summary>
  [WordInteropEnumValue("wdColorIndigo")]
  Indigo = 10040115,
  /// <summary>
  /// Blue-gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorBlueGray")]
  BlueGray = 10053222,
  /// <summary>
  /// Shade 40 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray40")]
  Gray40 = 10066329,
  /// <summary>
  /// Tan color.
  /// </summary>
  [WordInteropEnumValue("wdColorTan")]
  Tan = 10079487,
  /// <summary>
  /// Light yellow color.
  /// </summary>
  [WordInteropEnumValue("wdColorLightYellow")]
  LightYellow = 10092543,
  /// <summary>
  /// Shade 375 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray375")]
  Gray375 = 10526880,
  /// <summary>
  /// Shade 35 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray35")]
  Gray35 = 10921638,
  /// <summary>
  /// Shade 30 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray30")]
  Gray30 = 11776947,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray25")]
  Gray25 = 12632256,
  /// <summary>
  /// Rose color.
  /// </summary>
  [WordInteropEnumValue("wdColorRose")]
  Rose = 13408767,
  /// <summary>
  /// Aqua color.
  /// </summary>
  [WordInteropEnumValue("wdColorAqua")]
  Aqua = 13421619,
  /// <summary>
  /// Shade 20 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray20")]
  Gray20 = 13421772,
  /// <summary>
  /// Light green color.
  /// </summary>
  [WordInteropEnumValue("wdColorLightGreen")]
  LightGreen = 13434828,
  /// <summary>
  /// Shade 15 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray15")]
  Gray15 = 14277081,
  /// <summary>
  /// Shade 125 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray125")]
  Gray125 = 14737632,
  /// <summary>
  /// Shade 10 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray10")]
  Gray10 = 15132390,
  /// <summary>
  /// Shade 05 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdColorGray05")]
  Gray05 = 15987699,
  /// <summary>
  /// Blue color.
  /// </summary>
  [WordInteropEnumValue("wdColorBlue")]
  Blue = 16711680,
  /// <summary>
  /// Pink color.
  /// </summary>
  [WordInteropEnumValue("wdColorPink")]
  Pink = 16711935,
  /// <summary>
  /// Light blue color.
  /// </summary>
  [WordInteropEnumValue("wdColorLightBlue")]
  LightBlue = 16737843,
  /// <summary>
  /// Lavender color.
  /// </summary>
  [WordInteropEnumValue("wdColorLavender")]
  Lavender = 16751052,
  /// <summary>
  /// Sky blue color.
  /// </summary>
  [WordInteropEnumValue("wdColorSkyBlue")]
  SkyBlue = 16763904,
  /// <summary>
  /// Pale blue color.
  /// </summary>
  [WordInteropEnumValue("wdColorPaleBlue")]
  PaleBlue = 16764057,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  [WordInteropEnumValue("wdColorTurquoise")]
  Turquoise = 16776960,
  /// <summary>
  /// Light turquoise color.
  /// </summary>
  [WordInteropEnumValue("wdColorLightTurquoise")]
  LightTurquoise = 16777164,
  /// <summary>
  /// White color.
  /// </summary>
  [WordInteropEnumValue("wdColorWhite")]
  White = 16777215,
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  [WordInteropEnumValue("wdColorAutomatic")]
  Automatic = -16777216
}
