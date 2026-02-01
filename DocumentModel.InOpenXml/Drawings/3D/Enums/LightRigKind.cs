namespace DocumentModel.Drawings;
/// <summary>
///   Light Rig Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LightRigValues))]
public enum LightRigKind
{
  /// <summary>
  ///   Legacy Flat 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat1))]
  LegacyFlat1,
  /// <summary>
  ///   Legacy Flat 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat2))]
  LegacyFlat2,
  /// <summary>
  ///   Legacy Flat 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat3))]
  LegacyFlat3,
  /// <summary>
  ///   Legacy Flat 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyFlat4))]
  LegacyFlat4,
  /// <summary>
  ///   Legacy Normal 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal1))]
  LegacyNormal1,
  /// <summary>
  ///   Legacy Normal 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal2))]
  LegacyNormal2,
  /// <summary>
  ///   Legacy Normal 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal3))]
  LegacyNormal3,
  /// <summary>
  ///   Legacy Normal 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyNormal4))]
  LegacyNormal4,
  /// <summary>
  ///   Legacy Harsh 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh1))]
  LegacyHarsh1,
  /// <summary>
  ///   Legacy Harsh 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh2))]
  LegacyHarsh2,
  /// <summary>
  ///   Legacy Harsh 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh3))]
  LegacyHarsh3,
  /// <summary>
  ///   Legacy Harsh 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.LegacyHarsh4))]
  LegacyHarsh4,
  /// <summary>
  ///   Three Point.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.ThreePoints))]
  ThreePoints,
  /// <summary>
  ///   Light Rig Enum ( Balanced ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Balanced))]
  Balanced,
  /// <summary>
  ///   Soft.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Soft))]
  Soft,
  /// <summary>
  ///   Harsh.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Harsh))]
  Harsh,
  /// <summary>
  ///   Flood.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Flood))]
  Flood,
  /// <summary>
  ///   Contrasting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Contrasting))]
  Contrasting,
  /// <summary>
  ///   Morning.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Morning))]
  Morning,
  /// <summary>
  ///   Sunrise.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Sunrise))]
  Sunrise,
  /// <summary>
  ///   Sunset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Sunset))]
  Sunset,
  /// <summary>
  ///   Chilly.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Chilly))]
  Chilly,
  /// <summary>
  ///   Freezing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Freezing))]
  Freezing,
  /// <summary>
  ///   Flat.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Flat))]
  Flat,
  /// <summary>
  ///   Two Point.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.TwoPoints))]
  TwoPoints,
  /// <summary>
  ///   Glow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.Glow))]
  Glow,
  /// <summary>
  ///   Bright Room.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigValues.BrightRoom))]
  BrightRoom
}