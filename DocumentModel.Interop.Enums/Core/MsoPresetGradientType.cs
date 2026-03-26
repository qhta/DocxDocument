namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which predefined gradient to use to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetgradienttype?view=office-pia` for Office interop details.
/// </remarks>
public enum PresetGradientType
{
  /// <summary>
  /// Specifies which predefined gradient to use to fill a shape.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Early Sunset gradient.
  /// </summary>
  EarlySunset = 1,
  /// <summary>
  /// Late Sunset gradient.
  /// </summary>
  LateSunset = 2,
  /// <summary>
  /// Nightfall gradient.
  /// </summary>
  Nightfall = 3,
  /// <summary>
  /// Daybreak gradient.
  /// </summary>
  Daybreak = 4,
  /// <summary>
  /// Horizon gradient.
  /// </summary>
  Horizon = 5,
  /// <summary>
  /// Desert gradient.
  /// </summary>
  Desert = 6,
  /// <summary>
  /// Ocean gradient.
  /// </summary>
  Ocean = 7,
  /// <summary>
  /// Calm Water gradient.
  /// </summary>
  CalmWater = 8,
  /// <summary>
  /// Fire gradient.
  /// </summary>
  Fire = 9,
  /// <summary>
  /// Fog gradient.
  /// </summary>
  Fog = 10,
  /// <summary>
  /// Moss gradient.
  /// </summary>
  Moss = 11,
  /// <summary>
  /// Peacock gradient.
  /// </summary>
  Peacock = 12,
  /// <summary>
  /// Wheat gradient.
  /// </summary>
  Wheat = 13,
  /// <summary>
  /// Parchment gradient.
  /// </summary>
  Parchment = 14,
  /// <summary>
  /// Mahogany gradient.
  /// </summary>
  Mahogany = 15,
  /// <summary>
  /// Rainbow gradient.
  /// </summary>
  Rainbow = 16,
  /// <summary>
  /// Rainbow II gradient.
  /// </summary>
  RainbowII = 17,
  /// <summary>
  /// Gold gradient.
  /// </summary>
  Gold = 18,
  /// <summary>
  /// Gold II gradient.
  /// </summary>
  GoldII = 19,
  /// <summary>
  /// Brass gradient.
  /// </summary>
  Brass = 20,
  /// <summary>
  /// Chrome gradient.
  /// </summary>
  Chrome = 21,
  /// <summary>
  /// Chrome II gradient.
  /// </summary>
  ChromeII = 22,
  /// <summary>
  /// Silver gradient.
  /// </summary>
  Silver = 23,
  /// <summary>
  /// Sapphire gradient.
  /// </summary>
  Sapphire = 24
}
