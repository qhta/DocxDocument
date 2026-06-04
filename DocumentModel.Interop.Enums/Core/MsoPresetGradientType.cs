namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which predefined gradient to use to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetgradienttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetGradientType")]
public enum PresetGradientType
{
  /// <summary>
  /// Specifies which predefined gradient to use to fill a shape.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetGradientMixed")]
  Mixed = -2,
  /// <summary>
  /// Early Sunset gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientEarlySunset")]
  EarlySunset = 1,
  /// <summary>
  /// Late Sunset gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientLateSunset")]
  LateSunset = 2,
  /// <summary>
  /// Nightfall gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientNightfall")]
  Nightfall = 3,
  /// <summary>
  /// Daybreak gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientDaybreak")]
  Daybreak = 4,
  /// <summary>
  /// Horizon gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientHorizon")]
  Horizon = 5,
  /// <summary>
  /// Desert gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientDesert")]
  Desert = 6,
  /// <summary>
  /// Ocean gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientOcean")]
  Ocean = 7,
  /// <summary>
  /// Calm Water gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientCalmWater")]
  CalmWater = 8,
  /// <summary>
  /// Fire gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientFire")]
  Fire = 9,
  /// <summary>
  /// Fog gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientFog")]
  Fog = 10,
  /// <summary>
  /// Moss gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientMoss")]
  Moss = 11,
  /// <summary>
  /// Peacock gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientPeacock")]
  Peacock = 12,
  /// <summary>
  /// Wheat gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientWheat")]
  Wheat = 13,
  /// <summary>
  /// Parchment gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientParchment")]
  Parchment = 14,
  /// <summary>
  /// Mahogany gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientMahogany")]
  Mahogany = 15,
  /// <summary>
  /// Rainbow gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientRainbow")]
  Rainbow = 16,
  /// <summary>
  /// Rainbow II gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientRainbowII")]
  RainbowII = 17,
  /// <summary>
  /// Gold gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientGold")]
  Gold = 18,
  /// <summary>
  /// Gold II gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientGoldII")]
  GoldII = 19,
  /// <summary>
  /// Brass gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientBrass")]
  Brass = 20,
  /// <summary>
  /// Chrome gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientChrome")]
  Chrome = 21,
  /// <summary>
  /// Chrome II gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientChromeII")]
  ChromeII = 22,
  /// <summary>
  /// Silver gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientSilver")]
  Silver = 23,
  /// <summary>
  /// Sapphire gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientSapphire")]
  Sapphire = 24
}
