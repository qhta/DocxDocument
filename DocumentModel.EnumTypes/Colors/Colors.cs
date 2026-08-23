namespace DocumentModel;

/// <summary>
/// Defines the WdColors enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetColorValues))]
public enum WdColors : uint
{
  /// <summary>
  /// Alice Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.AliceBlue))]
  AliceBlue = 0x00F0F8FF,

  /// <summary>
  /// Antique White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.AntiqueWhite))]
  AntiqueWhite = 0x00FAEBD7,

  /// <summary>
  /// Aqua Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Aqua))]
  Aqua = 0x0000FFFF,

  /// <summary>
  /// Aquamarine Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Aquamarine))]
  Aquamarine = 0x007FFFD4,

  /// <summary>
  /// Azure Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Azure))]
  Azure = 0x00F0FFFF,

  /// <summary>
  /// Beige Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Beige))]
  Beige = 0x00F5F5DC,

  /// <summary>
  /// Bisque Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Bisque))]
  Bisque = 0x00FFE4C4,

  /// <summary>
  /// Black Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Black))]
  Black = 0x00000000,

  /// <summary>
  /// Blanched Almond Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.BlanchedAlmond))]
  BlanchedAlmond = 0x00FFEBCD,

  /// <summary>
  /// Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Blue))]
  Blue = 0x000000FF,

  /// <summary>
  /// Blue Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.BlueViolet))]
  BlueViolet = 0x008A2BE2,

  /// <summary>
  /// Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Brown))]
  Brown = 0x00A52A2A,

  /// <summary>
  /// Burly Wood Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.BurlyWood))]
  BurlyWood = 0x00DEB887,

  /// <summary>
  /// Cadet Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.CadetBlue))]
  CadetBlue = 0x005F9EA0,

  /// <summary>
  /// Chartreuse Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Chartreuse))]
  Chartreuse = 0x007FFF00,

  /// <summary>
  /// Chocolate Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Chocolate))]
  Chocolate = 0x00D2691E,

  /// <summary>
  /// Coral Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Coral))]
  Coral = 0x00FF7F50,

  /// <summary>
  /// Cornflower Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.CornflowerBlue))]
  CornflowerBlue = 0x006495ED,

  /// <summary>
  /// Cornsilk Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Cornsilk))]
  Cornsilk = 0x00FFF8DC,

  /// <summary>
  /// Crimson Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Crimson))]
  Crimson = 0x00DC143C,

  /// <summary>
  /// Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Cyan))]
  Cyan = 0x0000FFFF,

  /// <summary>
  /// Dark Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkBlue))]
  DarkBlue = 0x0000008B,

  /// <summary>
  /// Dark Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkCyan))]
  DarkCyan = 0x00008B8B,

  /// <summary>
  /// Dark Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkGoldenrod))]
  DarkGoldenrod = 0x00B8860B,

  /// <summary>
  /// Dark Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkGray))]
  DarkGray = 0x00A9A9A9,

  /// <summary>
  /// Dark Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkGreen))]
  DarkGreen = 0x00006400,

  /// <summary>
  /// Dark Khaki Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkKhaki))]
  DarkKhaki = 0x00BDB76B,

  /// <summary>
  /// Dark Magenta Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkMagenta))]
  DarkMagenta = 0x008B008B,

  /// <summary>
  /// Dark Olive Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkOliveGreen))]
  DarkOliveGreen = 0x00556B2F,

  /// <summary>
  /// Dark Orange Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkOrange))]
  DarkOrange = 0x00FF8C00,

  /// <summary>
  /// Dark Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkOrchid))]
  DarkOrchid = 0x009932CC,

  /// <summary>
  /// Dark Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkRed))]
  DarkRed = 0x008B0000,

  /// <summary>
  /// Dark Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkSalmon))]
  DarkSalmon = 0x00E9967A,

  /// <summary>
  /// Dark Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkSeaGreen))]
  DarkSeaGreen = 0x008FBC8F,

  /// <summary>
  /// Dark Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkSlateBlue))]
  DarkSlateBlue = 0x00483D8B,

  /// <summary>
  /// Dark Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkSlateGray))]
  DarkSlateGray = 0x002F4F4F,

  /// <summary>
  /// Dark Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkTurquoise))]
  DarkTurquoise = 0x0000CED1,

  /// <summary>
  /// Dark Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DarkViolet))]
  DarkViolet = 0x009400D3,

  /// <summary>
  /// Deep Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DeepPink))]
  DeepPink = 0x00FF1493,

  /// <summary>
  /// Deep Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DeepSkyBlue))]
  DeepSkyBlue = 0x0000BFFF,

  /// <summary>
  /// Dim Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DimGray))]
  DimGray = 0x00696969,

  /// <summary>
  /// Dodger Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.DodgerBlue))]
  DodgerBlue = 0x001E90FF,

  /// <summary>
  /// Firebrick Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Firebrick))]
  Firebrick = 0x00B22222,

  /// <summary>
  /// Floral White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.FloralWhite))]
  FloralWhite = 0x00FFFAF0,

  /// <summary>
  /// Forest Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.ForestGreen))]
  ForestGreen = 0x00228B22,

  /// <summary>
  /// Fuchsia Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Fuchsia))]
  Fuchsia = 0x00FF00FF,

  /// <summary>
  /// Gainsboro Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Gainsboro))]
  Gainsboro = 0x00DCDCDC,

  /// <summary>
  /// Ghost White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.GhostWhite))]
  GhostWhite = 0x00F8F8FF,

  /// <summary>
  /// Gold Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Gold))]
  Gold = 0x00FFD700,

  /// <summary>
  /// Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Goldenrod))]
  Goldenrod = 0x00DAA520,

  /// <summary>
  /// Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Gray))]
  Gray = 0x00808080,

  /// <summary>
  /// Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Green))]
  Green = 0x00008000,

  /// <summary>
  /// Green Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.GreenYellow))]
  GreenYellow = 0x00ADFF2F,

  /// <summary>
  /// Honeydew Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Honeydew))]
  Honeydew = 0x00F0FFF0,

  /// <summary>
  /// Hot Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.HotPink))]
  HotPink = 0x00FF69B4,

  /// <summary>
  /// Indian Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.IndianRed))]
  IndianRed = 0x00CD5C5C,

  /// <summary>
  /// Indigo Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Indigo))]
  Indigo = 0x004B0082,

  /// <summary>
  /// Ivory Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Ivory))]
  Ivory = 0x00FFFFF0,

  /// <summary>
  /// Khaki Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Khaki))]
  Khaki = 0x00F0E68C,

  /// <summary>
  /// Lavender Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Lavender))]
  Lavender = 0x00E6E6FA,

  /// <summary>
  /// Lavender Blush Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LavenderBlush))]
  LavenderBlush = 0x00FFF0F5,

  /// <summary>
  /// Lawn Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LawnGreen))]
  LawnGreen = 0x007CFC00,

  /// <summary>
  /// Lemon Chiffon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LemonChiffon))]
  LemonChiffon = 0x00FFFACD,

  /// <summary>
  /// Light Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightBlue))]
  LightBlue = 0x00ADD8E6,

  /// <summary>
  /// Light Coral Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightCoral))]
  LightCoral = 0x00F08080,

  /// <summary>
  /// Light Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightCyan))]
  LightCyan = 0x00E0FFFF,

  /// <summary>
  /// Light Goldenrod Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightGoldenrodYellow))]
  LightGoldenrodYellow = 0x00FAFAD2,

  /// <summary>
  /// Light Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightGray))]
  LightGray = 0x00D3D3D3,

  /// <summary>
  /// Light Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightGreen))]
  LightGreen = 0x0090EE90,

  /// <summary>
  /// Light Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightPink))]
  LightPink = 0x00FFB6C1,

  /// <summary>
  /// Light Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightSalmon))]
  LightSalmon = 0x00FFA07A,

  /// <summary>
  /// Light Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightSeaGreen))]
  LightSeaGreen = 0x0020B2AA,

  /// <summary>
  /// Light Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightSkyBlue))]
  LightSkyBlue = 0x0087CEFA,

  /// <summary>
  /// Light Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightSlateGray))]
  LightSlateGray = 0x00778899,

  /// <summary>
  /// Light Steel Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightSteelBlue))]
  LightSteelBlue = 0x00B0C4DE,

  /// <summary>
  /// Light Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LightYellow))]
  LightYellow = 0x00FFFFE0,

  /// <summary>
  /// Lime Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Lime))]
  Lime = 0x0000FF00,

  /// <summary>
  /// Lime Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.LimeGreen))]
  LimeGreen = 0x0032CD32,

  /// <summary>
  /// Linen Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Linen))]
  Linen = 0x00FAF0E6,

  /// <summary>
  /// Magenta Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Magenta))]
  Magenta = 0x00FF00FF,

  /// <summary>
  /// Maroon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Maroon))]
  Maroon = 0x00800000,

  /// <summary>
  /// Medium Aquamarine Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MedAquamarine))]
  MediumAquamarine = 0x0066CDAA,

  /// <summary>
  /// Medium Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumBlue))]
  MediumBlue = 0x000000CD,

  /// <summary>
  /// Medium Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumOrchid))]
  MediumOrchid = 0x00BA55D3,

  /// <summary>
  /// Medium Purple Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumPurple))]
  MediumPurple = 0x009370DB,

  /// <summary>
  /// Medium Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumSeaGreen))]
  MediumSeaGreen = 0x003CB371,

  /// <summary>
  /// Medium Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumSlateBlue))]
  MediumSlateBlue = 0x007B68EE,

  /// <summary>
  /// Medium Spring Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumSpringGreen))]
  MediumSpringGreen = 0x0000FA9A,

  /// <summary>
  /// Medium Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumTurquoise))]
  MediumTurquoise = 0x0048D1CC,

  /// <summary>
  /// Medium Violet Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MediumVioletRed))]
  MediumVioletRed = 0x00C71585,

  /// <summary>
  /// Midnight Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MidnightBlue))]
  MidnightBlue = 0x00191970,

  /// <summary>
  /// Mint Cream Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MintCream))]
  MintCream = 0x00F5FFFA,

  /// <summary>
  /// Misty Rose Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.MistyRose))]
  MistyRose = 0x00FFE4E1,

  /// <summary>
  /// Moccasin Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Moccasin))]
  Moccasin = 0x00FFE4B5,

  /// <summary>
  /// Navajo White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.NavajoWhite))]
  NavajoWhite = 0x00FFDEAD,

  /// <summary>
  /// Navy Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Navy))]
  Navy = 0x00000080,

  /// <summary>
  /// Old Lace Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.OldLace))]
  OldLace = 0x00FDF5E6,

  /// <summary>
  /// Olive Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Olive))]
  Olive = 0x00808000,

  /// <summary>
  /// Olive Drab Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.OliveDrab))]
  OliveDrab = 0x006B8E23,

  /// <summary>
  /// Orange Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Orange))]
  Orange = 0x00FFA500,

  /// <summary>
  /// Orange Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.OrangeRed))]
  OrangeRed = 0x00FF4500,

  /// <summary>
  /// Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Orchid))]
  Orchid = 0x00DA70D6,

  /// <summary>
  /// Pale Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PaleGoldenrod))]
  PaleGoldenrod = 0x00EEE8AA,

  /// <summary>
  /// Pale Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PaleGreen))]
  PaleGreen = 0x0098FB98,

  /// <summary>
  /// Pale Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PaleTurquoise))]
  PaleTurquoise = 0x00AFEEEE,

  /// <summary>
  /// Pale Violet Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PaleVioletRed))]
  PaleVioletRed = 0x00DB7093,

  /// <summary>
  /// Papaya Whip Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PapayaWhip))]
  PapayaWhip = 0x00FFEFD5,

  /// <summary>
  /// Peach Puff Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PeachPuff))]
  PeachPuff = 0x00FFDAB9,

  /// <summary>
  /// Peru Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Peru))]
  Peru = 0x00CD853F,

  /// <summary>
  /// Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Pink))]
  Pink = 0x00FFC0CB,

  /// <summary>
  /// Plum Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Plum))]
  Plum = 0x00DDA0DD,

  /// <summary>
  /// Powder Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.PowderBlue))]
  PowderBlue = 0x00B0E0E6,

  /// <summary>
  /// Purple Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Purple))]
  Purple = 0x00800080,

  /// <summary>
  /// Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Red))]
  Red = 0x00FF0000,

  /// <summary>
  /// Rosy Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.RosyBrown))]
  RosyBrown = 0x00BC8F8F,

  /// <summary>
  /// Royal Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.RoyalBlue))]
  RoyalBlue = 0x004169E1,

  /// <summary>
  /// Saddle Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SaddleBrown))]
  SaddleBrown = 0x008B4513,

  /// <summary>
  /// Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Salmon))]
  Salmon = 0x00FA8072,

  /// <summary>
  /// Sandy Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SandyBrown))]
  SandyBrown = 0x00F4A460,

  /// <summary>
  /// Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SeaGreen))]
  SeaGreen = 0x002E8B57,

  /// <summary>
  /// Sea Shell Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SeaShell))]
  SeaShell = 0x00FFF5EE,

  /// <summary>
  /// Sienna Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Sienna))]
  Sienna = 0x00A0522D,

  /// <summary>
  /// Silver Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Silver))]
  Silver = 0x00C0C0C0,

  /// <summary>
  /// Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SkyBlue))]
  SkyBlue = 0x0087CEEB,

  /// <summary>
  /// Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SlateBlue))]
  SlateBlue = 0x006A5ACD,

  /// <summary>
  /// Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SlateGray))]
  SlateGray = 0x00708090,

  /// <summary>
  /// Snow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Snow))]
  Snow = 0x00FFFAFA,

  /// <summary>
  /// Spring Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SpringGreen))]
  SpringGreen = 0x0000FF7F,

  /// <summary>
  /// Steel Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.SteelBlue))]
  SteelBlue = 0x004682B4,

  /// <summary>
  /// Tan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Tan))]
  Tan = 0x00D2B48C,

  /// <summary>
  /// Teal Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Teal))]
  Teal = 0x00008080,

  /// <summary>
  /// Thistle Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Thistle))]
  Thistle = 0x00D8BFD8,

  /// <summary>
  /// Tomato Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Tomato))]
  Tomato = 0x00FF6347,

  /// <summary>
  /// Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Turquoise))]
  Turquoise = 0x0040E0D0,

  /// <summary>
  /// Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Violet))]
  Violet = 0x00EE82EE,

  /// <summary>
  /// Wheat Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Wheat))]
  Wheat = 0x00F5DEB3,

  /// <summary>
  /// White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.White))]
  White = 0x00FFFFFF,

  /// <summary>
  /// White Smoke Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.WhiteSmoke))]
  WhiteSmoke = 0x00F5F5F5,

  /// <summary>
  /// Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.Yellow))]
  Yellow = 0x00FFFF00,

  /// <summary>
  /// Yellow Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetColorValues.YellowGreen))]
  YellowGreen = 0x009ACD32,

  /// <summary>
  /// Transparent color, not defined in Open XML standard, but used in Word to represent "no color". It is not a real color and should not be used for any other purpose.
  /// </summary>
  [OpenXmlEnumValue("Transparent")]
  Transparent = 0xFFFFFFFF,

  /// <summary>
  /// Automatic color, not defined in Open XML standard, but used in Word to represent "automatic color". It is not a real color and should not be used for any other purpose.
  /// </summary>
  [OpenXmlEnumValue("Auto")]
  Auto = 0xFF000000,
}

