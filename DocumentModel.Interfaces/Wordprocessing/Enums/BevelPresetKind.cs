namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the BevelPresetTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BevelPresetKind
{
  /// <summary>
  ///   relaxedInset.
  /// </summary>
  RelaxedInset,
  /// <summary>
  ///   circle.
  /// </summary>
  Circle,
  /// <summary>
  ///   slope.
  /// </summary>
  Slope,
  /// <summary>
  ///   cross.
  /// </summary>
  Cross,
  /// <summary>
  ///   angle.
  /// </summary>
  Angle,
  /// <summary>
  ///   softRound.
  /// </summary>
  SoftRound,
  /// <summary>
  ///   convex.
  /// </summary>
  Convex,
  /// <summary>
  ///   coolSlant.
  /// </summary>
  CoolSlant,
  /// <summary>
  ///   divot.
  /// </summary>
  Divot,
  /// <summary>
  ///   riblet.
  /// </summary>
  Riblet,
  /// <summary>
  ///   hardEdge.
  /// </summary>
  HardEdge,
  /// <summary>
  ///   artDeco.
  /// </summary>
  ArtDeco
}