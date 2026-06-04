namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects lighting for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolightrigtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLightRigType")]
public enum LightRigType
{
  /// <summary>
  /// Specifies the Mixed effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies the LegacyFlat1 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyFlat1")]
  LegacyFlat1 = 1,
  /// <summary>
  /// Specifies the LegacyFlat2 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyFlat2")]
  LegacyFlat2 = 2,
  /// <summary>
  /// Specifies the LegacyFlat3 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyFlat3")]
  LegacyFlat3 = 3,
  /// <summary>
  /// Specifies the LegacyFlat4 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyFlat4")]
  LegacyFlat4 = 4,
  /// <summary>
  /// Specifies the LegacyNormal1 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyNormal1")]
  LegacyNormal1 = 5,
  /// <summary>
  /// Specifies the LegacyNormal2 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyNormal2")]
  LegacyNormal2 = 6,
  /// <summary>
  /// Specifies the LegacyNormal3 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyNormal3")]
  LegacyNormal3 = 7,
  /// <summary>
  /// Specifies the LegacyNormal4 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyNormal4")]
  LegacyNormal4 = 8,
  /// <summary>
  /// Specifies the LegacyHarsh1 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyHarsh1")]
  LegacyHarsh1 = 9,
  /// <summary>
  /// Specifies the LegacyHarsh2 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyHarsh2")]
  LegacyHarsh2 = 10,
  /// <summary>
  /// Specifies the LegacyHarsh3 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyHarsh3")]
  LegacyHarsh3 = 11,
  /// <summary>
  /// Specifies the LegacyHarsh4 effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigLegacyHarsh4")]
  LegacyHarsh4 = 12,
  /// <summary>
  /// Specifies the ThreePoint effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigThreePoint")]
  ThreePoints = 13,
  /// <summary>
  /// Specifies the Balanced effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigBalanced")]
  Balanced = 14,
  /// <summary>
  /// Specifies the Soft effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigSoft")]
  Soft = 15,
  /// <summary>
  /// Specifies the Harsh effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigHarsh")]
  Harsh = 16,
  /// <summary>
  /// Specifies the Flood effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigFlood")]
  Flood = 17,
  /// <summary>
  /// Specifies the Contrasting effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigContrasting")]
  Contrasting = 18,
  /// <summary>
  /// Specifies the Morning effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigMorning")]
  Morning = 19,
  /// <summary>
  /// Specifies the Sunrise effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigSunrise")]
  Sunrise = 20,
  /// <summary>
  /// Specifies the Sunset effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigSunset")]
  Sunset = 21,
  /// <summary>
  /// Specifies the Chilly effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigChilly")]
  Chilly = 22,
  /// <summary>
  /// Specifies the Freezing effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigFreezing")]
  Freezing = 23,
  /// <summary>
  /// Specifies the Flat effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigFlat")]
  Flat = 24,
  /// <summary>
  /// Specifies the TwoPoint effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigTwoPoint")]
  TwoPoints = 25,
  /// <summary>
  /// Specifies the Glow effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigGlow")]
  Glow = 26,
  /// <summary>
  /// Specifies the BrightRoom effect.
  /// </summary>
  [OfficeInteropEnumValue("msoLightRigBrightRoom")]
  BrightRoom = 27
}
