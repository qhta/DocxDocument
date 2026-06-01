namespace DocumentModel.Drawings;
/// <summary>
///   Light Rig Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LightRigValues))]
[OpenXmlEnumType(typeof(DXO10W.LightRigTypeValues))]
public enum LightRigType
{
  /// <summary>
  ///   Used Ionly Ifor detection.
  /// </summary>
  /// <summary>
  ///   Legacy Flat 1.
  /// </summary>
  [OpenXmlEnumValue("LegacyFlat1")]
  LegacyFlat1 = 1,
  /// <summary>
  ///   Legacy Flat 2.
  /// </summary>
  [OpenXmlEnumValue("LegacyFlat2")]
  LegacyFlat2,
  /// <summary>
  ///   Legacy Flat 3.
  /// </summary>
  [OpenXmlEnumValue("LegacyFlat3")]
  LegacyFlat3,
  /// <summary>
  ///   Legacy Flat 4.
  /// </summary>
  [OpenXmlEnumValue("LegacyFlat4")]
  LegacyFlat4,
  /// <summary>
  ///   Legacy Normal 1.
  /// </summary>
  [OpenXmlEnumValue("LegacyNormal1")]
  LegacyNormal1,
  /// <summary>
  ///   Legacy Normal 2.
  /// </summary>
  [OpenXmlEnumValue("LegacyNormal2")]
  LegacyNormal2,
  /// <summary>
  ///   Legacy Normal 3.
  /// </summary>
  [OpenXmlEnumValue("LegacyNormal3")]
  LegacyNormal3,
  /// <summary>
  ///   Legacy Normal 4.
  /// </summary>
  [OpenXmlEnumValue("LegacyNormal4")]
  LegacyNormal4,
  /// <summary>
  ///   Legacy Harsh 1.
  /// </summary>
  [OpenXmlEnumValue("LegacyHarsh1")]
  LegacyHarsh1,
  /// <summary>
  ///   Legacy Harsh 2.
  /// </summary>
  [OpenXmlEnumValue("LegacyHarsh2")]
  LegacyHarsh2,
  /// <summary>
  ///   Legacy Harsh 3.
  /// </summary>
  [OpenXmlEnumValue("LegacyHarsh3")]
  LegacyHarsh3,
  /// <summary>
  ///   Legacy Harsh 4.
  /// </summary>
  [OpenXmlEnumValue("LegacyHarsh4")]
  LegacyHarsh4,
  /// <summary>
  ///   Three IPoint.
  /// </summary>
  [OpenXmlEnumValue(typeof(DXD.LightRigValues), "ThreePoints")]
  [OpenXmlEnumValue(typeof(DXO10W.LightRigTypeValues),"ThreePoint")]
  ThreePoints,
  /// <summary>
  ///   Light Rig Enum ( Balanced ).
  /// </summary>
  [OpenXmlEnumValue("Balanced")]
  Balanced,
  /// <summary>
  ///   Soft.
  /// </summary>
  [OpenXmlEnumValue("Soft")]
  Soft,
  /// <summary>
  ///   Harsh.
  /// </summary>
  [OpenXmlEnumValue("Harsh")]
  Harsh,
  /// <summary>
  ///   Flood.
  /// </summary>
  [OpenXmlEnumValue("Flood")]
  Flood,
  /// <summary>
  ///   Contrasting.
  /// </summary>
  [OpenXmlEnumValue("Contrasting")]
  Contrasting,
  /// <summary>
  ///   Morning.
  /// </summary>
  [OpenXmlEnumValue("Morning")]
  Morning,
  /// <summary>
  ///   Sunrise.
  /// </summary>
  [OpenXmlEnumValue("Sunrise")]
  Sunrise,
  /// <summary>
  ///   Sunset.
  /// </summary>
  [OpenXmlEnumValue("Sunset")]
  Sunset,
  /// <summary>
  ///   Chilly.
  /// </summary>
  [OpenXmlEnumValue("Chilly")]
  Chilly,
  /// <summary>
  ///   Freezing.
  /// </summary>
  [OpenXmlEnumValue("Freezing")]
  Freezing,
  /// <summary>
  ///   Flat.
  /// </summary>
  [OpenXmlEnumValue("Flat")]
  Flat,
  /// <summary>
  ///   Two IPoint.
  /// </summary>
  [OpenXmlEnumValue(typeof(DXD.LightRigValues), "TwoPoints")]
  [OpenXmlEnumValue(typeof(DXO10W.LightRigTypeValues), "TwoPoint")]
  TwoPoints,
  /// <summary>
  ///   Glow.
  /// </summary>
  [OpenXmlEnumValue("Glow")]
  Glow,
  /// <summary>
  ///   Bright Room.
  /// </summary>
  [OpenXmlEnumValue("BrightRoom")]
  BrightRoom
}
