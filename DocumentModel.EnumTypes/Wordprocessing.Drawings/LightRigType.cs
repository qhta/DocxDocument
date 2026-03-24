namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the type of light rig used for 3D rendering and shading effects in WordprocessingML drawings.
/// This enumeration provides values for various lighting configurations, supporting advanced visual effects and realistic lighting for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LightRigValues))]
public enum LightRigType
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Legacy flat light rig 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat1))]
  LegacyFlat1,
  /// <summary>
  /// Legacy flat light rig 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat2))]
  LegacyFlat2,
  /// <summary>
  /// Legacy flat light rig 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat3))]
  LegacyFlat3,
  /// <summary>
  /// Legacy flat light rig 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat4))]
  LegacyFlat4,
  /// <summary>
  /// Legacy normal light rig 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal1))]
  LegacyNormal1,
  /// <summary>
  /// Legacy normal light rig 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal2))]
  LegacyNormal2,
  /// <summary>
  /// Legacy normal light rig 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal3))]
  LegacyNormal3,
  /// <summary>
  /// Legacy normal light rig 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal4))]
  LegacyNormal4,
  /// <summary>
  /// Legacy harsh light rig 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh1))]
  LegacyHarsh1,
  /// <summary>
  /// Legacy harsh light rig 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh2))]
  LegacyHarsh2,
  /// <summary>
  /// Legacy harsh light rig 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh3))]
  LegacyHarsh3,
  /// <summary>
  /// Legacy harsh light rig 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh4))]
  LegacyHarsh4,
  /// <summary>
  /// Three-point light rig.
  /// </summary>
  ThreePoint,
  /// <summary>
  /// Balanced light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Balanced))]
  Balanced,
  /// <summary>
  /// Soft light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Soft))]
  Soft,
  /// <summary>
  /// Harsh light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Harsh))]
  Harsh,
  /// <summary>
  /// Flood light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Flood))]
  Flood,
  /// <summary>
  /// Contrasting light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Contrasting))]
  Contrasting,
  /// <summary>
  /// Morning light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Morning))]
  Morning,
  /// <summary>
  /// Sunrise light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Sunrise))]
  Sunrise,
  /// <summary>
  /// Sunset light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Sunset))]
  Sunset,
  /// <summary>
  /// Chilly light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Chilly))]
  Chilly,
  /// <summary>
  /// Freezing light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Freezing))]
  Freezing,
  /// <summary>
  /// Flat light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Flat))]
  Flat,
  /// <summary>
  /// Two-point light rig.
  /// </summary>
  TwoPoint,
  /// <summary>
  /// Glow light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Glow))]
  Glow,
  /// <summary>
  /// Bright room light rig.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.BrightRoom))]
  BrightRoom
}