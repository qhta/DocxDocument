namespace DocumentModel.Drawings;

/// <summary>
///   Light Rig Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LightRigKind
{
  /// <summary>
  ///   Legacy Flat 1.
  /// </summary>
  LegacyFlat1,
  /// <summary>
  ///   Legacy Flat 2.
  /// </summary>
  LegacyFlat2,
  /// <summary>
  ///   Legacy Flat 3.
  /// </summary>
  LegacyFlat3,
  /// <summary>
  ///   Legacy Flat 4.
  /// </summary>
  LegacyFlat4,
  /// <summary>
  ///   Legacy Normal 1.
  /// </summary>
  LegacyNormal1,
  /// <summary>
  ///   Legacy Normal 2.
  /// </summary>
  LegacyNormal2,
  /// <summary>
  ///   Legacy Normal 3.
  /// </summary>
  LegacyNormal3,
  /// <summary>
  ///   Legacy Normal 4.
  /// </summary>
  LegacyNormal4,
  /// <summary>
  ///   Legacy Harsh 1.
  /// </summary>
  LegacyHarsh1,
  /// <summary>
  ///   Legacy Harsh 2.
  /// </summary>
  LegacyHarsh2,
  /// <summary>
  ///   Legacy Harsh 3.
  /// </summary>
  LegacyHarsh3,
  /// <summary>
  ///   Legacy Harsh 4.
  /// </summary>
  LegacyHarsh4,
  /// <summary>
  ///   Three Point.
  /// </summary>
  ThreePoints,
  /// <summary>
  ///   Light Rig Enum ( Balanced ).
  /// </summary>
  Balanced,
  /// <summary>
  ///   Soft.
  /// </summary>
  Soft,
  /// <summary>
  ///   Harsh.
  /// </summary>
  Harsh,
  /// <summary>
  ///   Flood.
  /// </summary>
  Flood,
  /// <summary>
  ///   Contrasting.
  /// </summary>
  Contrasting,
  /// <summary>
  ///   Morning.
  /// </summary>
  Morning,
  /// <summary>
  ///   Sunrise.
  /// </summary>
  Sunrise,
  /// <summary>
  ///   Sunset.
  /// </summary>
  Sunset,
  /// <summary>
  ///   Chilly.
  /// </summary>
  Chilly,
  /// <summary>
  ///   Freezing.
  /// </summary>
  Freezing,
  /// <summary>
  ///   Flat.
  /// </summary>
  Flat,
  /// <summary>
  ///   Two Point.
  /// </summary>
  TwoPoints,
  /// <summary>
  ///   Glow.
  /// </summary>
  Glow,
  /// <summary>
  ///   Bright Room.
  /// </summary>
  BrightRoom
}