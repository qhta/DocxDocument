namespace DocumentModel;
/// <summary>
///   Preset Color Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetColorValues))]
public enum PresetColors
{
  /// <summary>
  ///   Alice Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.AliceBlue))]
  AliceBlue,
  /// <summary>
  ///   Antique White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.AntiqueWhite))]
  AntiqueWhite,
  /// <summary>
  ///   Aqua Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Aqua))]
  Aqua,
  /// <summary>
  ///   Aquamarine Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Aquamarine))]
  Aquamarine,
  /// <summary>
  ///   Azure Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Azure))]
  Azure,
  /// <summary>
  ///   Beige Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Beige))]
  Beige,
  /// <summary>
  ///   Bisque Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Bisque))]
  Bisque,
  /// <summary>
  ///   Black Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Black))]
  Black,
  /// <summary>
  ///   Blanched Almond Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.BlanchedAlmond))]
  BlanchedAlmond,
  /// <summary>
  ///   Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Blue))]
  Blue,
  /// <summary>
  ///   Blue Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.BlueViolet))]
  BlueViolet,
  /// <summary>
  ///   Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Brown))]
  Brown,
  /// <summary>
  ///   Burly Wood Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.BurlyWood))]
  BurlyWood,
  /// <summary>
  ///   Cadet Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.CadetBlue))]
  CadetBlue,
  /// <summary>
  ///   Chartreuse Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Chartreuse))]
  Chartreuse,
  /// <summary>
  ///   Chocolate Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Chocolate))]
  Chocolate,
  /// <summary>
  ///   Coral Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Coral))]
  Coral,
  /// <summary>
  ///   Cornflower Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.CornflowerBlue))]
  CornflowerBlue,
  /// <summary>
  ///   Cornsilk Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Cornsilk))]
  Cornsilk,
  /// <summary>
  ///   Crimson Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Crimson))]
  Crimson,
  /// <summary>
  ///   Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Cyan))]
  Cyan,
  /// <summary>
  ///   Dark Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkBlue))]
  DarkBlue,
  /// <summary>
  ///   Dark Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkCyan))]
  DarkCyan,
  /// <summary>
  ///   Dark Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGoldenrod))]
  DarkGoldenrod,
  /// <summary>
  ///   Dark Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGray))]
  DarkGray,
  /// <summary>
  ///   Dark Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGreen))]
  DarkGreen,
  /// <summary>
  ///   Dark Khaki Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkKhaki))]
  DarkKhaki,
  /// <summary>
  ///   Dark Magenta Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkMagenta))]
  DarkMagenta,
  /// <summary>
  ///   Dark Olive Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOliveGreen))]
  DarkOliveGreen,
  /// <summary>
  ///   Dark Orange Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOrange))]
  DarkOrange,
  /// <summary>
  ///   Dark Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOrchid))]
  DarkOrchid,
  /// <summary>
  ///   Dark Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkRed))]
  DarkRed,
  /// <summary>
  ///   Dark Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSalmon))]
  DarkSalmon,
  /// <summary>
  ///   Dark Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSeaGreen))]
  DarkSeaGreen,
  /// <summary>
  ///   Dark Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateBlue))]
  DarkSlateBlue,
  /// <summary>
  ///   Dark Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateGray))]
  DarkSlateGray,
  /// <summary>
  ///   Dark Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkTurquoise))]
  DarkTurquoise,
  /// <summary>
  ///   Dark Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkViolet))]
  DarkViolet,
  /// <summary>
  ///   Deep Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DeepPink))]
  DeepPink,
  /// <summary>
  ///   Deep Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DeepSkyBlue))]
  DeepSkyBlue,
  /// <summary>
  ///   Dim Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DimGray))]
  DimGray,
  /// <summary>
  ///   Dodger Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DodgerBlue))]
  DodgerBlue,
  /// <summary>
  ///   Firebrick Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Firebrick))]
  Firebrick,
  /// <summary>
  ///   Floral White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.FloralWhite))]
  FloralWhite,
  /// <summary>
  ///   Forest Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.ForestGreen))]
  ForestGreen,
  /// <summary>
  ///   Fuchsia Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Fuchsia))]
  Fuchsia,
  /// <summary>
  ///   Gainsboro Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Gainsboro))]
  Gainsboro,
  /// <summary>
  ///   Ghost White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.GhostWhite))]
  GhostWhite,
  /// <summary>
  ///   Gold Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Gold))]
  Gold,
  /// <summary>
  ///   Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Goldenrod))]
  Goldenrod,
  /// <summary>
  ///   Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Gray))]
  Gray,
  /// <summary>
  ///   Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Green))]
  Green,
  /// <summary>
  ///   Green Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.GreenYellow))]
  GreenYellow,
  /// <summary>
  ///   Honeydew Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Honeydew))]
  Honeydew,
  /// <summary>
  ///   Hot Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.HotPink))]
  HotPink,
  /// <summary>
  ///   Indian Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.IndianRed))]
  IndianRed,
  /// <summary>
  ///   Indigo Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Indigo))]
  Indigo,
  /// <summary>
  ///   Ivory Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Ivory))]
  Ivory,
  /// <summary>
  ///   Khaki Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Khaki))]
  Khaki,
  /// <summary>
  ///   Lavender Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Lavender))]
  Lavender,
  /// <summary>
  ///   Lavender Blush Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LavenderBlush))]
  LavenderBlush,
  /// <summary>
  ///   Lawn Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LawnGreen))]
  LawnGreen,
  /// <summary>
  ///   Lemon Chiffon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LemonChiffon))]
  LemonChiffon,
  /// <summary>
  ///   Light Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightBlue))]
  LightBlue,
  /// <summary>
  ///   Light Coral Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightCoral))]
  LightCoral,
  /// <summary>
  ///   Light Cyan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightCyan))]
  LightCyan,
  /// <summary>
  ///   Light Goldenrod Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGoldenrodYellow))]
  LightGoldenrodYellow,
  /// <summary>
  ///   Light Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGray))]
  LightGray,
  /// <summary>
  ///   Light Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGreen))]
  LightGreen,
  /// <summary>
  ///   Light Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightPink))]
  LightPink,
  /// <summary>
  ///   Light Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSalmon))]
  LightSalmon,
  /// <summary>
  ///   Light Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSeaGreen))]
  LightSeaGreen,
  /// <summary>
  ///   Light Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSkyBlue))]
  LightSkyBlue,
  /// <summary>
  ///   Light Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSlateGray))]
  LightSlateGray,
  /// <summary>
  ///   Light Steel Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSteelBlue))]
  LightSteelBlue,
  /// <summary>
  ///   Light Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightYellow))]
  LightYellow,
  /// <summary>
  ///   Lime Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Lime))]
  Lime,
  /// <summary>
  ///   Lime Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LimeGreen))]
  LimeGreen,
  /// <summary>
  ///   Linen Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Linen))]
  Linen,
  /// <summary>
  ///   Magenta Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Magenta))]
  Magenta,
  /// <summary>
  ///   Maroon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Maroon))]
  Maroon,
  /// <summary>
  ///   Medium Aquamarine Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MedAquamarine))]
  MedAquamarine,
  /// <summary>
  ///   Medium Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumBlue))]
  MediumBlue,
  /// <summary>
  ///   Medium Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumOrchid))]
  MediumOrchid,
  /// <summary>
  ///   Medium Purple Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumPurple))]
  MediumPurple,
  /// <summary>
  ///   Medium Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSeaGreen))]
  MediumSeaGreen,
  /// <summary>
  ///   Medium Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSlateBlue))]
  MediumSlateBlue,
  /// <summary>
  ///   Medium Spring Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSpringGreen))]
  MediumSpringGreen,
  /// <summary>
  ///   Medium Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumTurquoise))]
  MediumTurquoise,
  /// <summary>
  ///   Medium Violet Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumVioletRed))]
  MediumVioletRed,
  /// <summary>
  ///   Midnight Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MidnightBlue))]
  MidnightBlue,
  /// <summary>
  ///   Mint Cream Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MintCream))]
  MintCream,
  /// <summary>
  ///   Misty Rose Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MistyRose))]
  MistyRose,
  /// <summary>
  ///   Moccasin Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Moccasin))]
  Moccasin,
  /// <summary>
  ///   Navajo White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.NavajoWhite))]
  NavajoWhite,
  /// <summary>
  ///   Navy Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Navy))]
  Navy,
  /// <summary>
  ///   Old Lace Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.OldLace))]
  OldLace,
  /// <summary>
  ///   Olive Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Olive))]
  Olive,
  /// <summary>
  ///   Olive Drab Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.OliveDrab))]
  OliveDrab,
  /// <summary>
  ///   Orange Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Orange))]
  Orange,
  /// <summary>
  ///   Orange Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.OrangeRed))]
  OrangeRed,
  /// <summary>
  ///   Orchid Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Orchid))]
  Orchid,
  /// <summary>
  ///   Pale Goldenrod Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PaleGoldenrod))]
  PaleGoldenrod,
  /// <summary>
  ///   Pale Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PaleGreen))]
  PaleGreen,
  /// <summary>
  ///   Pale Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PaleTurquoise))]
  PaleTurquoise,
  /// <summary>
  ///   Pale Violet Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PaleVioletRed))]
  PaleVioletRed,
  /// <summary>
  ///   Papaya Whip Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PapayaWhip))]
  PapayaWhip,
  /// <summary>
  ///   Peach Puff Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PeachPuff))]
  PeachPuff,
  /// <summary>
  ///   Peru Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Peru))]
  Peru,
  /// <summary>
  ///   Pink Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Pink))]
  Pink,
  /// <summary>
  ///   Plum Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Plum))]
  Plum,
  /// <summary>
  ///   Powder Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.PowderBlue))]
  PowderBlue,
  /// <summary>
  ///   Purple Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Purple))]
  Purple,
  /// <summary>
  ///   Red Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Red))]
  Red,
  /// <summary>
  ///   Rosy Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.RosyBrown))]
  RosyBrown,
  /// <summary>
  ///   Royal Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.RoyalBlue))]
  RoyalBlue,
  /// <summary>
  ///   Saddle Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SaddleBrown))]
  SaddleBrown,
  /// <summary>
  ///   Salmon Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Salmon))]
  Salmon,
  /// <summary>
  ///   Sandy Brown Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SandyBrown))]
  SandyBrown,
  /// <summary>
  ///   Sea Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SeaGreen))]
  SeaGreen,
  /// <summary>
  ///   Sea Shell Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SeaShell))]
  SeaShell,
  /// <summary>
  ///   Sienna Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Sienna))]
  Sienna,
  /// <summary>
  ///   Silver Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Silver))]
  Silver,
  /// <summary>
  ///   Sky Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SkyBlue))]
  SkyBlue,
  /// <summary>
  ///   Slate Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SlateBlue))]
  SlateBlue,
  /// <summary>
  ///   Slate Gray Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SlateGray))]
  SlateGray,
  /// <summary>
  ///   Snow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Snow))]
  Snow,
  /// <summary>
  ///   Spring Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SpringGreen))]
  SpringGreen,
  /// <summary>
  ///   Steel Blue Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SteelBlue))]
  SteelBlue,
  /// <summary>
  ///   Tan Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Tan))]
  Tan,
  /// <summary>
  ///   Teal Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Teal))]
  Teal,
  /// <summary>
  ///   Thistle Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Thistle))]
  Thistle,
  /// <summary>
  ///   Tomato Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Tomato))]
  Tomato,
  /// <summary>
  ///   Turquoise Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Turquoise))]
  Turquoise,
  /// <summary>
  ///   Violet Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Violet))]
  Violet,
  /// <summary>
  ///   Wheat Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Wheat))]
  Wheat,
  /// <summary>
  ///   White Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.White))]
  White,
  /// <summary>
  ///   White Smoke Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.WhiteSmoke))]
  WhiteSmoke,
  /// <summary>
  ///   Yellow Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Yellow))]
  Yellow,
  /// <summary>
  ///   Yellow Green Preset Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.YellowGreen))]
  YellowGreen,
  /// <summary>
  ///   darkBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkBlue2010))]
  DarkBlue2010,
  /// <summary>
  ///   darkCyan.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkCyan2010))]
  DarkCyan2010,
  /// <summary>
  ///   darkGoldenrod.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGoldenrod2010))]
  DarkGoldenrod2010,
  /// <summary>
  ///   darkGray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGray2010))]
  DarkGray2010,
  /// <summary>
  ///   darkGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGrey2010))]
  DarkGrey2010,
  /// <summary>
  ///   darkGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGreen2010))]
  DarkGreen2010,
  /// <summary>
  ///   darkKhaki.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkKhaki2010))]
  DarkKhaki2010,
  /// <summary>
  ///   darkMagenta.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkMagenta2010))]
  DarkMagenta2010,
  /// <summary>
  ///   darkOliveGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOliveGreen2010))]
  DarkOliveGreen2010,
  /// <summary>
  ///   darkOrange.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOrange2010))]
  DarkOrange2010,
  /// <summary>
  ///   darkOrchid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkOrchid2010))]
  DarkOrchid2010,
  /// <summary>
  ///   darkRed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkRed2010))]
  DarkRed2010,
  /// <summary>
  ///   darkSalmon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSalmon2010))]
  DarkSalmon2010,
  /// <summary>
  ///   darkSeaGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSeaGreen2010))]
  DarkSeaGreen2010,
  /// <summary>
  ///   darkSlateBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateBlue2010))]
  DarkSlateBlue2010,
  /// <summary>
  ///   darkSlateGray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateGray2010))]
  DarkSlateGray2010,
  /// <summary>
  ///   darkSlateGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateGrey2010))]
  DarkSlateGrey2010,
  /// <summary>
  ///   darkTurquoise.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkTurquoise2010))]
  DarkTurquoise2010,
  /// <summary>
  ///   darkViolet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkViolet2010))]
  DarkViolet2010,
  /// <summary>
  ///   lightBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightBlue2010))]
  LightBlue2010,
  /// <summary>
  ///   lightCoral.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightCoral2010))]
  LightCoral2010,
  /// <summary>
  ///   lightCyan.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightCyan2010))]
  LightCyan2010,
  /// <summary>
  ///   lightGoldenrodYellow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGoldenrodYellow2010))]
  LightGoldenrodYellow2010,
  /// <summary>
  ///   lightGray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGray2010))]
  LightGray2010,
  /// <summary>
  ///   lightGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGrey2010))]
  LightGrey2010,
  /// <summary>
  ///   lightGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGreen2010))]
  LightGreen2010,
  /// <summary>
  ///   lightPink.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightPink2010))]
  LightPink2010,
  /// <summary>
  ///   lightSalmon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSalmon2010))]
  LightSalmon2010,
  /// <summary>
  ///   lightSeaGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSeaGreen2010))]
  LightSeaGreen2010,
  /// <summary>
  ///   lightSkyBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSkyBlue2010))]
  LightSkyBlue2010,
  /// <summary>
  ///   lightSlateGray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSlateGray2010))]
  LightSlateGray2010,
  /// <summary>
  ///   lightSlateGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSlateGrey2010))]
  LightSlateGrey2010,
  /// <summary>
  ///   lightSteelBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSteelBlue2010))]
  LightSteelBlue2010,
  /// <summary>
  ///   lightYellow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightYellow2010))]
  LightYellow2010,
  /// <summary>
  ///   mediumAquamarine.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumAquamarine2010))]
  MediumAquamarine2010,
  /// <summary>
  ///   mediumBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumBlue2010))]
  MediumBlue2010,
  /// <summary>
  ///   mediumOrchid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumOrchid2010))]
  MediumOrchid2010,
  /// <summary>
  ///   mediumPurple.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumPurple2010))]
  MediumPurple2010,
  /// <summary>
  ///   mediumSeaGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSeaGreen2010))]
  MediumSeaGreen2010,
  /// <summary>
  ///   mediumSlateBlue.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSlateBlue2010))]
  MediumSlateBlue2010,
  /// <summary>
  ///   mediumSpringGreen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumSpringGreen2010))]
  MediumSpringGreen2010,
  /// <summary>
  ///   mediumTurquoise.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumTurquoise2010))]
  MediumTurquoise2010,
  /// <summary>
  ///   mediumVioletRed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.MediumVioletRed2010))]
  MediumVioletRed2010,
  /// <summary>
  ///   dkGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkGrey))]
  DarkGrey,
  /// <summary>
  ///   dimGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DimGrey))]
  DimGrey,
  /// <summary>
  ///   dkSlateGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.DarkSlateGrey))]
  DarkSlateGrey,
  /// <summary>
  ///   grey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.Grey))]
  Grey,
  /// <summary>
  ///   ltGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightGrey))]
  LightGrey,
  /// <summary>
  ///   ltSlateGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.LightSlateGrey))]
  LightSlateGrey,
  /// <summary>
  ///   slateGrey.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetColorValues.SlateGrey))]
  SlateGrey
}