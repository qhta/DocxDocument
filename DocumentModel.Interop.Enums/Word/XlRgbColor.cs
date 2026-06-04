namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the RGB color.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlrgbcolor?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlRgbColor")]
public enum XlRgbColor
{
  /// <summary>
  /// Black
  /// </summary>
  [InteropEnumValue("xlBlack")]
  Black = 0,
  /// <summary>
  /// Maroon
  /// </summary>
  [InteropEnumValue("xlMaroon")]
  Maroon = 128,
  /// <summary>
  /// Dark Red
  /// </summary>
  [InteropEnumValue("xlDarkRed")]
  DarkRed = 139,
  /// <summary>
  /// Red
  /// </summary>
  [InteropEnumValue("xlRed")]
  Red = 255,
  /// <summary>
  /// Orange Red
  /// </summary>
  [InteropEnumValue("xlOrangeRed")]
  OrangeRed = 17919,
  /// <summary>
  /// Dark Green
  /// </summary>
  [InteropEnumValue("xlDarkGreen")]
  DarkGreen = 25600,
  /// <summary>
  /// Green
  /// </summary>
  [InteropEnumValue("xlGreen")]
  Green = 32768,
  /// <summary>
  /// Olive
  /// </summary>
  [InteropEnumValue("xlOlive")]
  Olive = 32896,
  /// <summary>
  /// Dark Orange
  /// </summary>
  [InteropEnumValue("xlDarkOrange")]
  DarkOrange = 36095,
  /// <summary>
  /// Orange Red
  /// </summary>
  [InteropEnumValue("xlOrange")]
  Orange = 42495,
  /// <summary>
  /// Gold
  /// </summary>
  [InteropEnumValue("xlGold")]
  Gold = 55295,
  /// <summary>
  /// Lawn Green
  /// </summary>
  [InteropEnumValue("xlLawnGreen")]
  LawnGreen = 64636,
  /// <summary>
  /// Lime public enum XlRgbColor
  /// </summary>
  [InteropEnumValue("xlLime")]
  Lime = 65280,
  /// <summary>
  /// Chartreuse
  /// </summary>
  [InteropEnumValue("xlChartreuse")]
  Chartreuse = 65407,
  /// <summary>
  /// Yellow
  /// </summary>
  [InteropEnumValue("xlYellow")]
  Yellow = 65535,
  /// <summary>
  /// Dark Goldenrod
  /// </summary>
  [InteropEnumValue("xlDarkGoldenrod")]
  DarkGoldenrod = 755384,
  /// <summary>
  /// Goldenrod
  /// </summary>
  [InteropEnumValue("xlGoldenrod")]
  Goldenrod = 2139610,
  /// <summary>
  /// Fire Brick
  /// </summary>
  [InteropEnumValue("xlFireBrick")]
  FireBrick = 2237106,
  /// <summary>
  /// Forest Green
  /// </summary>
  [InteropEnumValue("xlForestGreen")]
  ForestGreen = 2263842,
  /// <summary>
  /// Olive Drab
  /// </summary>
  [InteropEnumValue("xlOliveDrab")]
  OliveDrab = 2330219,
  /// <summary>
  /// Brown
  /// </summary>
  [InteropEnumValue("xlBrown")]
  Brown = 2763429,
  /// <summary>
  /// Sienna
  /// </summary>
  [InteropEnumValue("xlSienna")]
  Sienna = 2970272,
  /// <summary>
  /// Dark Olive Green
  /// </summary>
  [InteropEnumValue("xlDarkOliveGreen")]
  DarkOliveGreen = 3107669,
  /// <summary>
  /// Green Yellow
  /// </summary>
  [InteropEnumValue("xlGreenYellow")]
  GreenYellow = 3145645,
  /// <summary>
  /// Lime Green
  /// </summary>
  [InteropEnumValue("xlLimeGreen")]
  LimeGreen = 3329330,
  /// <summary>
  /// Yellow Green
  /// </summary>
  [InteropEnumValue("xlYellowGreen")]
  YellowGreen = 3329434,
  /// <summary>
  /// Crimson
  /// </summary>
  [InteropEnumValue("xlCrimson")]
  Crimson = 3937500,
  /// <summary>
  /// Peru
  /// </summary>
  [InteropEnumValue("xlPeru")]
  Peru = 4163021,
  /// <summary>
  /// Tomato
  /// </summary>
  [InteropEnumValue("xlTomato")]
  Tomato = 4678655,
  /// <summary>
  /// Dark Slate Grey
  /// </summary>
  [InteropEnumValue("xlDarkSlateGrey")]
  DarkSlateGrey = 5197615,
  /// <summary>
  /// Dark Slate Gray
  /// </summary>
  [InteropEnumValue("xlDarkSlateGray")]
  DarkSlateGray = 5197615,
  /// <summary>
  /// Coral
  /// </summary>
  [InteropEnumValue("xlCoral")]
  Coral = 5275647,
  /// <summary>
  /// Sea Green
  /// </summary>
  [InteropEnumValue("xlSeaGreen")]
  SeaGreen = 5737262,
  /// <summary>
  /// Indian Red
  /// </summary>
  [InteropEnumValue("xlIndianRed")]
  IndianRed = 6053069,
  /// <summary>
  /// Sandy Brown
  /// </summary>
  [InteropEnumValue("xlSandyBrown")]
  SandyBrown = 6333684,
  /// <summary>
  /// Dim Grey
  /// </summary>
  [InteropEnumValue("xlDimGrey")]
  DimGrey = 6908265,
  /// <summary>
  /// Dim Gray
  /// </summary>
  [InteropEnumValue("xlDimGray")]
  DimGray = 6908265,
  /// <summary>
  /// Dark Khaki
  /// </summary>
  [InteropEnumValue("xlDarkKhaki")]
  DarkKhaki = 7059389,
  /// <summary>
  /// Pale Goldenrod
  /// </summary>
  [InteropEnumValue("xlPaleGoldenrod")]
  PaleGoldenrod = 7071982,
  /// <summary>
  /// Midnight Blue
  /// </summary>
  [InteropEnumValue("xlMidnightBlue")]
  MidnightBlue = 7346457,
  /// <summary>
  /// Medium Sea Green
  /// </summary>
  [InteropEnumValue("xlMediumSeaGreen")]
  MediumSeaGreen = 7451452,
  /// <summary>
  /// Salmon
  /// </summary>
  [InteropEnumValue("xlSalmon")]
  Salmon = 7504122,
  /// <summary>
  /// Dark Salmon
  /// </summary>
  [InteropEnumValue("xlDarkSalmon")]
  DarkSalmon = 8034025,
  /// <summary>
  /// Light Salmon
  /// </summary>
  [InteropEnumValue("xlLightSalmon")]
  LightSalmon = 8036607,
  /// <summary>
  /// Spring Green
  /// </summary>
  [InteropEnumValue("xlSpringGreen")]
  SpringGreen = 8388352,
  /// <summary>
  /// Navy Blue
  /// </summary>
  [InteropEnumValue("xlNavyBlue")]
  NavyBlue = 8388608,
  /// <summary>
  /// Navy
  /// </summary>
  [InteropEnumValue("xlNavy")]
  Navy = 8388608,
  /// <summary>
  /// Purple
  /// </summary>
  [InteropEnumValue("xlPurple")]
  Purple = 8388736,
  /// <summary>
  /// Teal
  /// </summary>
  [InteropEnumValue("xlTeal")]
  Teal = 8421376,
  /// <summary>
  /// Grey
  /// </summary>
  [InteropEnumValue("xlGrey")]
  Grey = 8421504,
  /// <summary>
  /// Gray
  /// </summary>
  [InteropEnumValue("xlGray")]
  Gray = 8421504,
  /// <summary>
  /// Light Coral
  /// </summary>
  [InteropEnumValue("xlLightCoral")]
  LightCoral = 8421616,
  /// <summary>
  /// Indigo
  /// </summary>
  [InteropEnumValue("xlIndigo")]
  Indigo = 8519755,
  /// <summary>
  /// Medium Violet Red
  /// </summary>
  [InteropEnumValue("xlMediumVioletRed")]
  MediumVioletRed = 8721863,
  /// <summary>
  /// Burly Wood
  /// </summary>
  [InteropEnumValue("xlBurlyWood")]
  BurlyWood = 8894686,
  /// <summary>
  /// Dark Blue
  /// </summary>
  [InteropEnumValue("xlDarkBlue")]
  DarkBlue = 9109504,
  /// <summary>
  /// Dark Magenta
  /// </summary>
  [InteropEnumValue("xlDarkMagenta")]
  DarkMagenta = 9109643,
  /// <summary>
  /// Dark Slate Blue
  /// </summary>
  [InteropEnumValue("xlDarkSlateBlue")]
  DarkSlateBlue = 9125192,
  /// <summary>
  /// Light Cyan
  /// </summary>
  [InteropEnumValue("xlLightCyan")]
  LightCyan = 9145088,
  /// <summary>
  /// Dark Cyan
  /// </summary>
  [InteropEnumValue("xlDarkCyan")]
  DarkCyan = 9145088,
  /// <summary>
  /// Tan
  /// </summary>
  [InteropEnumValue("xlTan")]
  Tan = 9221330,
  /// <summary>
  /// Khaki
  /// </summary>
  [InteropEnumValue("xlKhaki")]
  Khaki = 9234160,
  /// <summary>
  /// Rosy Brown
  /// </summary>
  [InteropEnumValue("xlRosyBrown")]
  RosyBrown = 9408444,
  /// <summary>
  /// Dark Sea Green
  /// </summary>
  [InteropEnumValue("xlDarkSeaGreen")]
  DarkSeaGreen = 9419919,
  /// <summary>
  /// Slate Gray
  /// </summary>
  [InteropEnumValue("xlSlateGray")]
  SlateGray = 9470064,
  /// <summary>
  /// Slate Grey
  /// </summary>
  [InteropEnumValue("xlSlateGrey")]
  SlateGrey = 9470064,
  /// <summary>
  /// Light Green
  /// </summary>
  [InteropEnumValue("xlLightGreen")]
  LightGreen = 9498256,
  /// <summary>
  /// Deep Pink
  /// </summary>
  [InteropEnumValue("xlDeepPink")]
  DeepPink = 9639167,
  /// <summary>
  /// Pale Violet Red
  /// </summary>
  [InteropEnumValue("xlPaleVioletRed")]
  PaleVioletRed = 9662683,
  /// <summary>
  /// Pale Green
  /// </summary>
  [InteropEnumValue("xlPaleGreen")]
  PaleGreen = 10025880,
  /// <summary>
  /// Light Slate Grey
  /// </summary>
  [InteropEnumValue("xlLightSlateGrey")]
  LightSlateGrey = 10061943,
  /// <summary>
  /// Light Slate Gray
  /// </summary>
  [InteropEnumValue("xlLightSlateGray")]
  LightSlateGray = 10061943,
  /// <summary>
  /// Medium Spring Green
  /// </summary>
  [InteropEnumValue("xlMediumSpringGreen")]
  MediumSpringGreen = 10156544,
  /// <summary>
  /// Cadet Blue
  /// </summary>
  [InteropEnumValue("xlCadetBlue")]
  CadetBlue = 10526303,
  /// <summary>
  /// Dark Grey
  /// </summary>
  [InteropEnumValue("xlDarkGrey")]
  DarkGrey = 11119017,
  /// <summary>
  /// Dark Gray
  /// </summary>
  [InteropEnumValue("xlDarkGray")]
  DarkGray = 11119017,
  /// <summary>
  /// Light Sea Green
  /// </summary>
  [InteropEnumValue("xlLightSeaGreen")]
  LightSeaGreen = 11186720,
  /// <summary>
  /// Medium Aquamarine
  /// </summary>
  [InteropEnumValue("xlMediumAquamarine")]
  MediumAquamarine = 11206502,
  /// <summary>
  /// Navajo White
  /// </summary>
  [InteropEnumValue("xlNavajoWhite")]
  NavajoWhite = 11394815,
  /// <summary>
  /// Wheat
  /// </summary>
  [InteropEnumValue("xlWheat")]
  Wheat = 11788021,
  /// <summary>
  /// Hot Pink
  /// </summary>
  [InteropEnumValue("xlHotPink")]
  HotPink = 11823615,
  /// <summary>
  /// Steel Blue
  /// </summary>
  [InteropEnumValue("xlSteelBlue")]
  SteelBlue = 11829830,
  /// <summary>
  /// Moccasin
  /// </summary>
  [InteropEnumValue("xlMoccasin")]
  Moccasin = 11920639,
  /// <summary>
  /// Peach Puff
  /// </summary>
  [InteropEnumValue("xlPeachPuff")]
  PeachPuff = 12180223,
  /// <summary>
  /// Silver
  /// </summary>
  [InteropEnumValue("xlSilver")]
  Silver = 12632256,
  /// <summary>
  /// Light Pink
  /// </summary>
  [InteropEnumValue("xlLightPink")]
  LightPink = 12695295,
  /// <summary>
  /// Bisque
  /// </summary>
  [InteropEnumValue("xlBisque")]
  Bisque = 12903679,
  /// <summary>
  /// Pink
  /// </summary>
  [InteropEnumValue("xlPink")]
  Pink = 13353215,
  /// <summary>
  /// Dark Orchid
  /// </summary>
  [InteropEnumValue("xlDarkOrchid")]
  DarkOrchid = 13382297,
  /// <summary>
  /// Medium Turquoise
  /// </summary>
  [InteropEnumValue("xlMediumTurquoise")]
  MediumTurquoise = 13422920,
  /// <summary>
  /// Medium Blue
  /// </summary>
  [InteropEnumValue("xlMediumBlue")]
  MediumBlue = 13434880,
  /// <summary>
  /// Slate Blue
  /// </summary>
  [InteropEnumValue("xlSlateBlue")]
  SlateBlue = 13458026,
  /// <summary>
  /// Blanched Almond
  /// </summary>
  [InteropEnumValue("xlBlanchedAlmond")]
  BlanchedAlmond = 13495295,
  /// <summary>
  /// Lemon Chiffon
  /// </summary>
  [InteropEnumValue("xlLemonChiffon")]
  LemonChiffon = 13499135,
  /// <summary>
  /// Turquoise
  /// </summary>
  [InteropEnumValue("xlTurquoise")]
  Turquoise = 13688896,
  /// <summary>
  /// Dark Turquoise
  /// </summary>
  [InteropEnumValue("xlDarkTurquoise")]
  DarkTurquoise = 13749760,
  /// <summary>
  /// LightGoldenrodYellow
  /// </summary>
  [InteropEnumValue("xlLightGoldenrodYellow")]
  LightGoldenrodYellow = 13826810,
  /// <summary>
  /// Dark Violet
  /// </summary>
  [InteropEnumValue("xlDarkViolet")]
  DarkViolet = 13828244,
  /// <summary>
  /// Medium Orchid
  /// </summary>
  [InteropEnumValue("xlMediumOrchid")]
  MediumOrchid = 13850042,
  /// <summary>
  /// Light Grey
  /// </summary>
  [InteropEnumValue("xlLightGrey")]
  LightGrey = 13882323,
  /// <summary>
  /// Light Gray
  /// </summary>
  [InteropEnumValue("xlLightGray")]
  LightGray = 13882323,
  /// <summary>
  /// Aquamarine
  /// </summary>
  [InteropEnumValue("xlAquamarine")]
  Aquamarine = 13959039,
  /// <summary>
  /// Papaya Whip
  /// </summary>
  [InteropEnumValue("xlPapayaWhip")]
  PapayaWhip = 14020607,
  /// <summary>
  /// Orchid
  /// </summary>
  [InteropEnumValue("xlOrchid")]
  Orchid = 14053594,
  /// <summary>
  /// Antique White
  /// </summary>
  [InteropEnumValue("xlAntiqueWhite")]
  AntiqueWhite = 14150650,
  /// <summary>
  /// Thistle
  /// </summary>
  [InteropEnumValue("xlThistle")]
  Thistle = 14204888,
  /// <summary>
  /// Medium Purple
  /// </summary>
  [InteropEnumValue("xlMediumPurple")]
  MediumPurple = 14381203,
  /// <summary>
  /// Gainsboro
  /// </summary>
  [InteropEnumValue("xlGainsboro")]
  Gainsboro = 14474460,
  /// <summary>
  /// Beige
  /// </summary>
  [InteropEnumValue("xlBeige")]
  Beige = 14480885,
  /// <summary>
  /// Cornsilk
  /// </summary>
  [InteropEnumValue("xlCornsilk")]
  Cornsilk = 14481663,
  /// <summary>
  /// Plum
  /// </summary>
  [InteropEnumValue("xlPlum")]
  Plum = 14524637,
  /// <summary>
  /// Light Steel Blue
  /// </summary>
  [InteropEnumValue("xlLightSteelBlue")]
  LightSteelBlue = 14599344,
  /// <summary>
  /// Light Yellow
  /// </summary>
  [InteropEnumValue("xlLightYellow")]
  LightYellow = 14745599,
  /// <summary>
  /// Royal Blue
  /// </summary>
  [InteropEnumValue("xlRoyalBlue")]
  RoyalBlue = 14772545,
  /// <summary>
  /// Misty Rose
  /// </summary>
  [InteropEnumValue("xlMistyRose")]
  MistyRose = 14804223,
  /// <summary>
  /// Blue Violet
  /// </summary>
  [InteropEnumValue("xlBlueViolet")]
  BlueViolet = 14822282,
  /// <summary>
  /// Light Blue
  /// </summary>
  [InteropEnumValue("xlLightBlue")]
  LightBlue = 15128749,
  /// <summary>
  /// Powder Blue
  /// </summary>
  [InteropEnumValue("xlPowderBlue")]
  PowderBlue = 15130800,
  /// <summary>
  /// Linen
  /// </summary>
  [InteropEnumValue("xlLinen")]
  Linen = 15134970,
  /// <summary>
  /// Old Lace
  /// </summary>
  [InteropEnumValue("xlOldLace")]
  OldLace = 15136253,
  /// <summary>
  /// Sky Blue
  /// </summary>
  [InteropEnumValue("xlSkyBlue")]
  SkyBlue = 15453831,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlCornflowerBlue")]
  CornflowerBlue = 15570276,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlMediumSlateBlue")]
  MediumSlateBlue = 15624315,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlViolet")]
  Violet = 15631086,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlPaleTurquoise")]
  PaleTurquoise = 15658671,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlSeashell")]
  Seashell = 15660543,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlFloralWhite")]
  FloralWhite = 15792895,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlHoneydew")]
  Honeydew = 15794160,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlIvory")]
  Ivory = 15794175,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlLavenderBlush")]
  LavenderBlush = 16118015,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlWhiteSmoke")]
  WhiteSmoke = 16119285,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlLightSkyBlue")]
  LightSkyBlue = 16436871,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlLavender")]
  Lavender = 16443110,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlSnow")]
  Snow = 16448255,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlMintCream")]
  MintCream = 16449525,
  /// <summary>
  /// Blue Violet
  /// </summary>
  [InteropEnumValue("xlBlue")]
  Blue = 16711680,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlFuchsia")]
  Fuchsia = 16711935,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlDodgerBlue")]
  DodgerBlue = 16748574,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlDeepSkyBlue")]
  DeepSkyBlue = 16760576,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlAliceBlue")]
  AliceBlue = 16775408,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlGhostWhite")]
  GhostWhite = 16775416,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlAqua")]
  Aqua = 16776960,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlAzure")]
  Azure = 16777200,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [InteropEnumValue("xlWhite")]
  White = 16777215
}
