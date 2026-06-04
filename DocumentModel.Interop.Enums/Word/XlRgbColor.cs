namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the RGB color.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlrgbcolor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlRgbColor))]
public enum XlRgbColor
{
  /// <summary>
  /// Black
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBlack))]
  Black = 0,
  /// <summary>
  /// Maroon
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMaroon))]
  Maroon = 128,
  /// <summary>
  /// Dark Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkRed))]
  DarkRed = 139,
  /// <summary>
  /// Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlRed))]
  Red = 255,
  /// <summary>
  /// Orange Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOrangeRed))]
  OrangeRed = 17919,
  /// <summary>
  /// Dark Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkGreen))]
  DarkGreen = 25600,
  /// <summary>
  /// Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGreen))]
  Green = 32768,
  /// <summary>
  /// Olive
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOlive))]
  Olive = 32896,
  /// <summary>
  /// Dark Orange
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkOrange))]
  DarkOrange = 36095,
  /// <summary>
  /// Orange Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOrange))]
  Orange = 42495,
  /// <summary>
  /// Gold
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGold))]
  Gold = 55295,
  /// <summary>
  /// Lawn Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLawnGreen))]
  LawnGreen = 64636,
  /// <summary>
  /// Lime public enum XlRgbColor
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLime))]
  Lime = 65280,
  /// <summary>
  /// Chartreuse
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlChartreuse))]
  Chartreuse = 65407,
  /// <summary>
  /// Yellow
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlYellow))]
  Yellow = 65535,
  /// <summary>
  /// Dark Goldenrod
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkGoldenrod))]
  DarkGoldenrod = 755384,
  /// <summary>
  /// Goldenrod
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGoldenrod))]
  Goldenrod = 2139610,
  /// <summary>
  /// Fire Brick
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlFireBrick))]
  FireBrick = 2237106,
  /// <summary>
  /// Forest Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlForestGreen))]
  ForestGreen = 2263842,
  /// <summary>
  /// Olive Drab
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOliveDrab))]
  OliveDrab = 2330219,
  /// <summary>
  /// Brown
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBrown))]
  Brown = 2763429,
  /// <summary>
  /// Sienna
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSienna))]
  Sienna = 2970272,
  /// <summary>
  /// Dark Olive Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkOliveGreen))]
  DarkOliveGreen = 3107669,
  /// <summary>
  /// Green Yellow
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGreenYellow))]
  GreenYellow = 3145645,
  /// <summary>
  /// Lime Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLimeGreen))]
  LimeGreen = 3329330,
  /// <summary>
  /// Yellow Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlYellowGreen))]
  YellowGreen = 3329434,
  /// <summary>
  /// Crimson
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlCrimson))]
  Crimson = 3937500,
  /// <summary>
  /// Peru
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPeru))]
  Peru = 4163021,
  /// <summary>
  /// Tomato
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlTomato))]
  Tomato = 4678655,
  /// <summary>
  /// Dark Slate Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkSlateGrey))]
  DarkSlateGrey = 5197615,
  /// <summary>
  /// Dark Slate Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkSlateGray))]
  DarkSlateGray = 5197615,
  /// <summary>
  /// Coral
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlCoral))]
  Coral = 5275647,
  /// <summary>
  /// Sea Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSeaGreen))]
  SeaGreen = 5737262,
  /// <summary>
  /// Indian Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlIndianRed))]
  IndianRed = 6053069,
  /// <summary>
  /// Sandy Brown
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSandyBrown))]
  SandyBrown = 6333684,
  /// <summary>
  /// Dim Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDimGrey))]
  DimGrey = 6908265,
  /// <summary>
  /// Dim Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDimGray))]
  DimGray = 6908265,
  /// <summary>
  /// Dark Khaki
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkKhaki))]
  DarkKhaki = 7059389,
  /// <summary>
  /// Pale Goldenrod
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPaleGoldenrod))]
  PaleGoldenrod = 7071982,
  /// <summary>
  /// Midnight Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMidnightBlue))]
  MidnightBlue = 7346457,
  /// <summary>
  /// Medium Sea Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumSeaGreen))]
  MediumSeaGreen = 7451452,
  /// <summary>
  /// Salmon
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSalmon))]
  Salmon = 7504122,
  /// <summary>
  /// Dark Salmon
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkSalmon))]
  DarkSalmon = 8034025,
  /// <summary>
  /// Light Salmon
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSalmon))]
  LightSalmon = 8036607,
  /// <summary>
  /// Spring Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSpringGreen))]
  SpringGreen = 8388352,
  /// <summary>
  /// Navy Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlNavyBlue))]
  NavyBlue = 8388608,
  /// <summary>
  /// Navy
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlNavy))]
  Navy = 8388608,
  /// <summary>
  /// Purple
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPurple))]
  Purple = 8388736,
  /// <summary>
  /// Teal
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlTeal))]
  Teal = 8421376,
  /// <summary>
  /// Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGrey))]
  Grey = 8421504,
  /// <summary>
  /// Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGray))]
  Gray = 8421504,
  /// <summary>
  /// Light Coral
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightCoral))]
  LightCoral = 8421616,
  /// <summary>
  /// Indigo
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlIndigo))]
  Indigo = 8519755,
  /// <summary>
  /// Medium Violet Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumVioletRed))]
  MediumVioletRed = 8721863,
  /// <summary>
  /// Burly Wood
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBurlyWood))]
  BurlyWood = 8894686,
  /// <summary>
  /// Dark Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkBlue))]
  DarkBlue = 9109504,
  /// <summary>
  /// Dark Magenta
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkMagenta))]
  DarkMagenta = 9109643,
  /// <summary>
  /// Dark Slate Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkSlateBlue))]
  DarkSlateBlue = 9125192,
  /// <summary>
  /// Light Cyan
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightCyan))]
  LightCyan = 9145088,
  /// <summary>
  /// Dark Cyan
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkCyan))]
  DarkCyan = 9145088,
  /// <summary>
  /// Tan
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlTan))]
  Tan = 9221330,
  /// <summary>
  /// Khaki
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlKhaki))]
  Khaki = 9234160,
  /// <summary>
  /// Rosy Brown
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlRosyBrown))]
  RosyBrown = 9408444,
  /// <summary>
  /// Dark Sea Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkSeaGreen))]
  DarkSeaGreen = 9419919,
  /// <summary>
  /// Slate Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSlateGray))]
  SlateGray = 9470064,
  /// <summary>
  /// Slate Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSlateGrey))]
  SlateGrey = 9470064,
  /// <summary>
  /// Light Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightGreen))]
  LightGreen = 9498256,
  /// <summary>
  /// Deep Pink
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDeepPink))]
  DeepPink = 9639167,
  /// <summary>
  /// Pale Violet Red
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPaleVioletRed))]
  PaleVioletRed = 9662683,
  /// <summary>
  /// Pale Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPaleGreen))]
  PaleGreen = 10025880,
  /// <summary>
  /// Light Slate Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSlateGrey))]
  LightSlateGrey = 10061943,
  /// <summary>
  /// Light Slate Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSlateGray))]
  LightSlateGray = 10061943,
  /// <summary>
  /// Medium Spring Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumSpringGreen))]
  MediumSpringGreen = 10156544,
  /// <summary>
  /// Cadet Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlCadetBlue))]
  CadetBlue = 10526303,
  /// <summary>
  /// Dark Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkGrey))]
  DarkGrey = 11119017,
  /// <summary>
  /// Dark Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkGray))]
  DarkGray = 11119017,
  /// <summary>
  /// Light Sea Green
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSeaGreen))]
  LightSeaGreen = 11186720,
  /// <summary>
  /// Medium Aquamarine
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumAquamarine))]
  MediumAquamarine = 11206502,
  /// <summary>
  /// Navajo White
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlNavajoWhite))]
  NavajoWhite = 11394815,
  /// <summary>
  /// Wheat
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlWheat))]
  Wheat = 11788021,
  /// <summary>
  /// Hot Pink
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlHotPink))]
  HotPink = 11823615,
  /// <summary>
  /// Steel Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSteelBlue))]
  SteelBlue = 11829830,
  /// <summary>
  /// Moccasin
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMoccasin))]
  Moccasin = 11920639,
  /// <summary>
  /// Peach Puff
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPeachPuff))]
  PeachPuff = 12180223,
  /// <summary>
  /// Silver
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSilver))]
  Silver = 12632256,
  /// <summary>
  /// Light Pink
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightPink))]
  LightPink = 12695295,
  /// <summary>
  /// Bisque
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBisque))]
  Bisque = 12903679,
  /// <summary>
  /// Pink
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPink))]
  Pink = 13353215,
  /// <summary>
  /// Dark Orchid
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkOrchid))]
  DarkOrchid = 13382297,
  /// <summary>
  /// Medium Turquoise
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumTurquoise))]
  MediumTurquoise = 13422920,
  /// <summary>
  /// Medium Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumBlue))]
  MediumBlue = 13434880,
  /// <summary>
  /// Slate Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSlateBlue))]
  SlateBlue = 13458026,
  /// <summary>
  /// Blanched Almond
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBlanchedAlmond))]
  BlanchedAlmond = 13495295,
  /// <summary>
  /// Lemon Chiffon
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLemonChiffon))]
  LemonChiffon = 13499135,
  /// <summary>
  /// Turquoise
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlTurquoise))]
  Turquoise = 13688896,
  /// <summary>
  /// Dark Turquoise
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkTurquoise))]
  DarkTurquoise = 13749760,
  /// <summary>
  /// LightGoldenrodYellow
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightGoldenrodYellow))]
  LightGoldenrodYellow = 13826810,
  /// <summary>
  /// Dark Violet
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDarkViolet))]
  DarkViolet = 13828244,
  /// <summary>
  /// Medium Orchid
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumOrchid))]
  MediumOrchid = 13850042,
  /// <summary>
  /// Light Grey
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightGrey))]
  LightGrey = 13882323,
  /// <summary>
  /// Light Gray
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightGray))]
  LightGray = 13882323,
  /// <summary>
  /// Aquamarine
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlAquamarine))]
  Aquamarine = 13959039,
  /// <summary>
  /// Papaya Whip
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPapayaWhip))]
  PapayaWhip = 14020607,
  /// <summary>
  /// Orchid
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOrchid))]
  Orchid = 14053594,
  /// <summary>
  /// Antique White
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlAntiqueWhite))]
  AntiqueWhite = 14150650,
  /// <summary>
  /// Thistle
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlThistle))]
  Thistle = 14204888,
  /// <summary>
  /// Medium Purple
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumPurple))]
  MediumPurple = 14381203,
  /// <summary>
  /// Gainsboro
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGainsboro))]
  Gainsboro = 14474460,
  /// <summary>
  /// Beige
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBeige))]
  Beige = 14480885,
  /// <summary>
  /// Cornsilk
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlCornsilk))]
  Cornsilk = 14481663,
  /// <summary>
  /// Plum
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPlum))]
  Plum = 14524637,
  /// <summary>
  /// Light Steel Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSteelBlue))]
  LightSteelBlue = 14599344,
  /// <summary>
  /// Light Yellow
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightYellow))]
  LightYellow = 14745599,
  /// <summary>
  /// Royal Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlRoyalBlue))]
  RoyalBlue = 14772545,
  /// <summary>
  /// Misty Rose
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMistyRose))]
  MistyRose = 14804223,
  /// <summary>
  /// Blue Violet
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBlueViolet))]
  BlueViolet = 14822282,
  /// <summary>
  /// Light Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightBlue))]
  LightBlue = 15128749,
  /// <summary>
  /// Powder Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPowderBlue))]
  PowderBlue = 15130800,
  /// <summary>
  /// Linen
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLinen))]
  Linen = 15134970,
  /// <summary>
  /// Old Lace
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlOldLace))]
  OldLace = 15136253,
  /// <summary>
  /// Sky Blue
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSkyBlue))]
  SkyBlue = 15453831,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlCornflowerBlue))]
  CornflowerBlue = 15570276,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMediumSlateBlue))]
  MediumSlateBlue = 15624315,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlViolet))]
  Violet = 15631086,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlPaleTurquoise))]
  PaleTurquoise = 15658671,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSeashell))]
  Seashell = 15660543,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlFloralWhite))]
  FloralWhite = 15792895,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlHoneydew))]
  Honeydew = 15794160,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlIvory))]
  Ivory = 15794175,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLavenderBlush))]
  LavenderBlush = 16118015,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlWhiteSmoke))]
  WhiteSmoke = 16119285,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLightSkyBlue))]
  LightSkyBlue = 16436871,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlLavender))]
  Lavender = 16443110,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlSnow))]
  Snow = 16448255,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlMintCream))]
  MintCream = 16449525,
  /// <summary>
  /// Blue Violet
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlBlue))]
  Blue = 16711680,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlFuchsia))]
  Fuchsia = 16711935,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDodgerBlue))]
  DodgerBlue = 16748574,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlDeepSkyBlue))]
  DeepSkyBlue = 16760576,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlAliceBlue))]
  AliceBlue = 16775408,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlGhostWhite))]
  GhostWhite = 16775416,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlAqua))]
  Aqua = 16776960,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlAzure))]
  Azure = 16777200,
  /// <summary>
  /// Specifies the RGB color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlRgbColor.xlWhite))]
  White = 16777215
}
