namespace DocumentModel.Vml.Office;

/// <summary>
/// Black And White Modes
/// </summary>
public enum BlackAndWhiteMode
{
  /// <summary>
  /// Color.
  /// </summary>
  [XmlEnum("color")]
  Color,
  
  /// <summary>
  /// Automatic.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Grayscale.
  /// </summary>
  [XmlEnum("grayScale")]
  GrayScale,
  
  /// <summary>
  /// Light grayscale.
  /// </summary>
  [XmlEnum("lightGrayScale")]
  LightGrayScale,
  
  /// <summary>
  /// Inverse Grayscale.
  /// </summary>
  [XmlEnum("inverseGray")]
  InverseGray,
  
  /// <summary>
  /// Gray Outlines.
  /// </summary>
  [XmlEnum("grayOutline")]
  GrayOutline,
  
  /// <summary>
  /// Black And White.
  /// </summary>
  [XmlEnum("highContrast")]
  HighContrast,
  
  /// <summary>
  /// Black.
  /// </summary>
  [XmlEnum("black")]
  Black,
  
  /// <summary>
  /// White.
  /// </summary>
  [XmlEnum("white")]
  White,
  
  /// <summary>
  /// Do Not Show.
  /// </summary>
  [XmlEnum("undrawn")]
  Undrawn,
  
  /// <summary>
  /// Black Text And Lines.
  /// </summary>
  [XmlEnum("blackTextAndLines")]
  BlackTextAndLines,
  
}
