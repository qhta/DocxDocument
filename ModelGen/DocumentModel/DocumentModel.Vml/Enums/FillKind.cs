namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Type
/// </summary>
public enum FillKind
{
  /// <summary>
  /// Centered Radial Gradient.
  /// </summary>
  GradientCenter,
  
  /// <summary>
  /// Solid Fill.
  /// </summary>
  Solid,
  
  /// <summary>
  /// Image Pattern.
  /// </summary>
  Pattern,
  
  /// <summary>
  /// Tiled Image.
  /// </summary>
  Tile,
  
  /// <summary>
  /// Stretch Image to Fit.
  /// </summary>
  Frame,
  
  /// <summary>
  /// Unscaled Gradient.
  /// </summary>
  GradientUnscaled,
  
  /// <summary>
  /// Radial Gradient.
  /// </summary>
  GradientRadial,
  
  /// <summary>
  /// Linear Gradient.
  /// </summary>
  Gradient,
  
  /// <summary>
  /// Use Background Fill.
  /// </summary>
  Background,
  
}
