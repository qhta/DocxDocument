namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which predefined gradient to use to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetgradienttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetGradientType")]
public enum PresetGradientType
{
  /// <summary>
  /// Specifies which predefined gradient to use to fill a shape.
  /// </summary>
  [InteropEnumValue("msoPresetGradientMixed")]
  Mixed = -2,
  /// <summary>
  /// Early Sunset gradient.
  /// </summary>
  [InteropEnumValue("msoGradientEarlySunset")]
  EarlySunset = 1,
  /// <summary>
  /// Late Sunset gradient.
  /// </summary>
  [InteropEnumValue("msoGradientLateSunset")]
  LateSunset = 2,
  /// <summary>
  /// Nightfall gradient.
  /// </summary>
  [InteropEnumValue("msoGradientNightfall")]
  Nightfall = 3,
  /// <summary>
  /// Daybreak gradient.
  /// </summary>
  [InteropEnumValue("msoGradientDaybreak")]
  Daybreak = 4,
  /// <summary>
  /// Horizon gradient.
  /// </summary>
  [InteropEnumValue("msoGradientHorizon")]
  Horizon = 5,
  /// <summary>
  /// Desert gradient.
  /// </summary>
  [InteropEnumValue("msoGradientDesert")]
  Desert = 6,
  /// <summary>
  /// Ocean gradient.
  /// </summary>
  [InteropEnumValue("msoGradientOcean")]
  Ocean = 7,
  /// <summary>
  /// Calm Water gradient.
  /// </summary>
  [InteropEnumValue("msoGradientCalmWater")]
  CalmWater = 8,
  /// <summary>
  /// Fire gradient.
  /// </summary>
  [InteropEnumValue("msoGradientFire")]
  Fire = 9,
  /// <summary>
  /// Fog gradient.
  /// </summary>
  [InteropEnumValue("msoGradientFog")]
  Fog = 10,
  /// <summary>
  /// Moss gradient.
  /// </summary>
  [InteropEnumValue("msoGradientMoss")]
  Moss = 11,
  /// <summary>
  /// Peacock gradient.
  /// </summary>
  [InteropEnumValue("msoGradientPeacock")]
  Peacock = 12,
  /// <summary>
  /// Wheat gradient.
  /// </summary>
  [InteropEnumValue("msoGradientWheat")]
  Wheat = 13,
  /// <summary>
  /// Parchment gradient.
  /// </summary>
  [InteropEnumValue("msoGradientParchment")]
  Parchment = 14,
  /// <summary>
  /// Mahogany gradient.
  /// </summary>
  [InteropEnumValue("msoGradientMahogany")]
  Mahogany = 15,
  /// <summary>
  /// Rainbow gradient.
  /// </summary>
  [InteropEnumValue("msoGradientRainbow")]
  Rainbow = 16,
  /// <summary>
  /// Rainbow II gradient.
  /// </summary>
  [InteropEnumValue("msoGradientRainbowII")]
  RainbowII = 17,
  /// <summary>
  /// Gold gradient.
  /// </summary>
  [InteropEnumValue("msoGradientGold")]
  Gold = 18,
  /// <summary>
  /// Gold II gradient.
  /// </summary>
  [InteropEnumValue("msoGradientGoldII")]
  GoldII = 19,
  /// <summary>
  /// Brass gradient.
  /// </summary>
  [InteropEnumValue("msoGradientBrass")]
  Brass = 20,
  /// <summary>
  /// Chrome gradient.
  /// </summary>
  [InteropEnumValue("msoGradientChrome")]
  Chrome = 21,
  /// <summary>
  /// Chrome II gradient.
  /// </summary>
  [InteropEnumValue("msoGradientChromeII")]
  ChromeII = 22,
  /// <summary>
  /// Silver gradient.
  /// </summary>
  [InteropEnumValue("msoGradientSilver")]
  Silver = 23,
  /// <summary>
  /// Sapphire gradient.
  /// </summary>
  [InteropEnumValue("msoGradientSapphire")]
  Sapphire = 24
}
