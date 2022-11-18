namespace DocumentModel.Drawing;

/// <summary>
/// Bevel Presets
/// </summary>
public enum BevelPreset
{
  /// <summary>
  /// Relaxed Inset.
  /// </summary>
  [XmlEnum("relaxedInset")]
  RelaxedInset,
  
  /// <summary>
  /// Circle.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// Slope.
  /// </summary>
  [XmlEnum("slope")]
  Slope,
  
  /// <summary>
  /// Cross.
  /// </summary>
  [XmlEnum("cross")]
  Cross,
  
  /// <summary>
  /// Angle.
  /// </summary>
  [XmlEnum("angle")]
  Angle,
  
  /// <summary>
  /// Soft Round.
  /// </summary>
  [XmlEnum("softRound")]
  SoftRound,
  
  /// <summary>
  /// Convex.
  /// </summary>
  [XmlEnum("convex")]
  Convex,
  
  /// <summary>
  /// Cool Slant.
  /// </summary>
  [XmlEnum("coolSlant")]
  CoolSlant,
  
  /// <summary>
  /// Divot.
  /// </summary>
  [XmlEnum("divot")]
  Divot,
  
  /// <summary>
  /// Riblet.
  /// </summary>
  [XmlEnum("riblet")]
  Riblet,
  
  /// <summary>
  /// Hard Edge.
  /// </summary>
  [XmlEnum("hardEdge")]
  HardEdge,
  
  /// <summary>
  /// Art Deco.
  /// </summary>
  [XmlEnum("artDeco")]
  ArtDeco,
  
}
