namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Type
/// </summary>
public enum FillType
{
  /// <summary>
  /// Solid Fill.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// Linear Gradient.
  /// </summary>
  [XmlEnum("gradient")]
  Gradient,
  
  /// <summary>
  /// Radial Gradient.
  /// </summary>
  [XmlEnum("gradientRadial")]
  GradientRadial,
  
  /// <summary>
  /// Tiled Image.
  /// </summary>
  [XmlEnum("tile")]
  Tile,
  
  /// <summary>
  /// Image Pattern.
  /// </summary>
  [XmlEnum("pattern")]
  Pattern,
  
  /// <summary>
  /// Stretch Image to Fit.
  /// </summary>
  [XmlEnum("frame")]
  Frame,
  
}
