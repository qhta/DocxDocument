namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects lighting for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolightrigtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLightRigType")]
public enum LightRigType
{
  /// <summary>
  /// Specifies the Mixed effect.
  /// </summary>
  [InteropEnumValue("msoLightRigMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies the LegacyFlat1 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyFlat1")]
  LegacyFlat1 = 1,
  /// <summary>
  /// Specifies the LegacyFlat2 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyFlat2")]
  LegacyFlat2 = 2,
  /// <summary>
  /// Specifies the LegacyFlat3 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyFlat3")]
  LegacyFlat3 = 3,
  /// <summary>
  /// Specifies the LegacyFlat4 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyFlat4")]
  LegacyFlat4 = 4,
  /// <summary>
  /// Specifies the LegacyNormal1 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyNormal1")]
  LegacyNormal1 = 5,
  /// <summary>
  /// Specifies the LegacyNormal2 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyNormal2")]
  LegacyNormal2 = 6,
  /// <summary>
  /// Specifies the LegacyNormal3 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyNormal3")]
  LegacyNormal3 = 7,
  /// <summary>
  /// Specifies the LegacyNormal4 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyNormal4")]
  LegacyNormal4 = 8,
  /// <summary>
  /// Specifies the LegacyHarsh1 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyHarsh1")]
  LegacyHarsh1 = 9,
  /// <summary>
  /// Specifies the LegacyHarsh2 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyHarsh2")]
  LegacyHarsh2 = 10,
  /// <summary>
  /// Specifies the LegacyHarsh3 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyHarsh3")]
  LegacyHarsh3 = 11,
  /// <summary>
  /// Specifies the LegacyHarsh4 effect.
  /// </summary>
  [InteropEnumValue("msoLightRigLegacyHarsh4")]
  LegacyHarsh4 = 12,
  /// <summary>
  /// Specifies the ThreePoint effect.
  /// </summary>
  [InteropEnumValue("msoLightRigThreePoint")]
  ThreePoints = 13,
  /// <summary>
  /// Specifies the Balanced effect.
  /// </summary>
  [InteropEnumValue("msoLightRigBalanced")]
  Balanced = 14,
  /// <summary>
  /// Specifies the Soft effect.
  /// </summary>
  [InteropEnumValue("msoLightRigSoft")]
  Soft = 15,
  /// <summary>
  /// Specifies the Harsh effect.
  /// </summary>
  [InteropEnumValue("msoLightRigHarsh")]
  Harsh = 16,
  /// <summary>
  /// Specifies the Flood effect.
  /// </summary>
  [InteropEnumValue("msoLightRigFlood")]
  Flood = 17,
  /// <summary>
  /// Specifies the Contrasting effect.
  /// </summary>
  [InteropEnumValue("msoLightRigContrasting")]
  Contrasting = 18,
  /// <summary>
  /// Specifies the Morning effect.
  /// </summary>
  [InteropEnumValue("msoLightRigMorning")]
  Morning = 19,
  /// <summary>
  /// Specifies the Sunrise effect.
  /// </summary>
  [InteropEnumValue("msoLightRigSunrise")]
  Sunrise = 20,
  /// <summary>
  /// Specifies the Sunset effect.
  /// </summary>
  [InteropEnumValue("msoLightRigSunset")]
  Sunset = 21,
  /// <summary>
  /// Specifies the Chilly effect.
  /// </summary>
  [InteropEnumValue("msoLightRigChilly")]
  Chilly = 22,
  /// <summary>
  /// Specifies the Freezing effect.
  /// </summary>
  [InteropEnumValue("msoLightRigFreezing")]
  Freezing = 23,
  /// <summary>
  /// Specifies the Flat effect.
  /// </summary>
  [InteropEnumValue("msoLightRigFlat")]
  Flat = 24,
  /// <summary>
  /// Specifies the TwoPoint effect.
  /// </summary>
  [InteropEnumValue("msoLightRigTwoPoint")]
  TwoPoints = 25,
  /// <summary>
  /// Specifies the Glow effect.
  /// </summary>
  [InteropEnumValue("msoLightRigGlow")]
  Glow = 26,
  /// <summary>
  /// Specifies the BrightRoom effect.
  /// </summary>
  [InteropEnumValue("msoLightRigBrightRoom")]
  BrightRoom = 27
}
