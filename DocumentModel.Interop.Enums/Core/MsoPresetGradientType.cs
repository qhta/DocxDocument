namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which predefined gradient to use to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetgradienttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetGradientType))]
public enum PresetGradientType
{
  /// <summary>
  /// Specifies which predefined gradient to use to fill a shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoPresetGradientMixed))]
  Mixed = -2,
  /// <summary>
  /// Early Sunset gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientEarlySunset))]
  EarlySunset = 1,
  /// <summary>
  /// Late Sunset gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientLateSunset))]
  LateSunset = 2,
  /// <summary>
  /// Nightfall gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientNightfall))]
  Nightfall = 3,
  /// <summary>
  /// Daybreak gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientDaybreak))]
  Daybreak = 4,
  /// <summary>
  /// Horizon gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientHorizon))]
  Horizon = 5,
  /// <summary>
  /// Desert gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientDesert))]
  Desert = 6,
  /// <summary>
  /// Ocean gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientOcean))]
  Ocean = 7,
  /// <summary>
  /// Calm Water gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientCalmWater))]
  CalmWater = 8,
  /// <summary>
  /// Fire gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientFire))]
  Fire = 9,
  /// <summary>
  /// Fog gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientFog))]
  Fog = 10,
  /// <summary>
  /// Moss gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientMoss))]
  Moss = 11,
  /// <summary>
  /// Peacock gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientPeacock))]
  Peacock = 12,
  /// <summary>
  /// Wheat gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientWheat))]
  Wheat = 13,
  /// <summary>
  /// Parchment gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientParchment))]
  Parchment = 14,
  /// <summary>
  /// Mahogany gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientMahogany))]
  Mahogany = 15,
  /// <summary>
  /// Rainbow gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientRainbow))]
  Rainbow = 16,
  /// <summary>
  /// Rainbow II gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientRainbowII))]
  RainbowII = 17,
  /// <summary>
  /// Gold gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientGold))]
  Gold = 18,
  /// <summary>
  /// Gold II gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientGoldII))]
  GoldII = 19,
  /// <summary>
  /// Brass gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientBrass))]
  Brass = 20,
  /// <summary>
  /// Chrome gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientChrome))]
  Chrome = 21,
  /// <summary>
  /// Chrome II gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientChromeII))]
  ChromeII = 22,
  /// <summary>
  /// Silver gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientSilver))]
  Silver = 23,
  /// <summary>
  /// Sapphire gradient.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetGradientType.msoGradientSapphire))]
  Sapphire = 24
}
