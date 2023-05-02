namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bevel Presets
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BevelPresetKind
{
  /// <summary>
  ///   Relaxed Inset.
  /// </summary>
  RelaxedInset,

  /// <summary>
  ///   Circle.
  /// </summary>
  Circle,

  /// <summary>
  ///   Slope.
  /// </summary>
  Slope,

  /// <summary>
  ///   Cross.
  /// </summary>
  Cross,

  /// <summary>
  ///   Angle.
  /// </summary>
  Angle,

  /// <summary>
  ///   Soft Round.
  /// </summary>
  SoftRound,

  /// <summary>
  ///   Convex.
  /// </summary>
  Convex,

  /// <summary>
  ///   Cool Slant.
  /// </summary>
  CoolSlant,

  /// <summary>
  ///   Divot.
  /// </summary>
  Divot,

  /// <summary>
  ///   Riblet.
  /// </summary>
  Riblet,

  /// <summary>
  ///   Hard Edge.
  /// </summary>
  HardEdge,

  /// <summary>
  ///   Art Deco.
  /// </summary>
  ArtDeco
}