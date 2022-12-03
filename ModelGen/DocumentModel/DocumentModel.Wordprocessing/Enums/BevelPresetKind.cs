namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelPresetTypeValues enumeration.
/// </summary>
public enum BevelPresetKind
{
  /// <summary>
  /// relaxedInset.
  /// </summary>
  [XmlEnum("relaxedInset")]
  RelaxedInset,
  
  /// <summary>
  /// circle.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// slope.
  /// </summary>
  [XmlEnum("slope")]
  Slope,
  
  /// <summary>
  /// cross.
  /// </summary>
  [XmlEnum("cross")]
  Cross,
  
  /// <summary>
  /// angle.
  /// </summary>
  [XmlEnum("angle")]
  Angle,
  
  /// <summary>
  /// softRound.
  /// </summary>
  [XmlEnum("softRound")]
  SoftRound,
  
  /// <summary>
  /// convex.
  /// </summary>
  [XmlEnum("convex")]
  Convex,
  
  /// <summary>
  /// coolSlant.
  /// </summary>
  [XmlEnum("coolSlant")]
  CoolSlant,
  
  /// <summary>
  /// divot.
  /// </summary>
  [XmlEnum("divot")]
  Divot,
  
  /// <summary>
  /// riblet.
  /// </summary>
  [XmlEnum("riblet")]
  Riblet,
  
  /// <summary>
  /// hardEdge.
  /// </summary>
  [XmlEnum("hardEdge")]
  HardEdge,
  
  /// <summary>
  /// artDeco.
  /// </summary>
  [XmlEnum("artDeco")]
  ArtDeco,
  
}
