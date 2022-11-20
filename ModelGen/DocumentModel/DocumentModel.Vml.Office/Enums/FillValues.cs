namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Fill Type
/// </summary>
public enum FillValues
{
  /// <summary>
  /// Centered Radial Gradient.
  /// </summary>
  [XmlEnum("gradientCenter")]
  GradientCenter,
  
  /// <summary>
  /// Solid Fill.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// Image Pattern.
  /// </summary>
  [XmlEnum("pattern")]
  Pattern,
  
  /// <summary>
  /// Tiled Image.
  /// </summary>
  [XmlEnum("tile")]
  Tile,
  
  /// <summary>
  /// Stretch Image to Fit.
  /// </summary>
  [XmlEnum("frame")]
  Frame,
  
  /// <summary>
  /// Unscaled Gradient.
  /// </summary>
  [XmlEnum("gradientUnscaled")]
  GradientUnscaled,
  
  /// <summary>
  /// Radial Gradient.
  /// </summary>
  [XmlEnum("gradientRadial")]
  GradientRadial,
  
  /// <summary>
  /// Linear Gradient.
  /// </summary>
  [XmlEnum("gradient")]
  Gradient,
  
  /// <summary>
  /// Use Background Fill.
  /// </summary>
  [XmlEnum("background")]
  Background,
  
}
