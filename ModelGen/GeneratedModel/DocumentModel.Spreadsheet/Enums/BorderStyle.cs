namespace DocumentModel.Spreadsheet;

/// <summary>
/// Border Line Styles
/// </summary>
public enum BorderStyle
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Thin Border.
  /// </summary>
  [XmlEnum("thin")]
  Thin,
  
  /// <summary>
  /// Medium Border.
  /// </summary>
  [XmlEnum("medium")]
  Medium,
  
  /// <summary>
  /// Dashed.
  /// </summary>
  [XmlEnum("dashed")]
  Dashed,
  
  /// <summary>
  /// Dotted.
  /// </summary>
  [XmlEnum("dotted")]
  Dotted,
  
  /// <summary>
  /// Thick Line Border.
  /// </summary>
  [XmlEnum("thick")]
  Thick,
  
  /// <summary>
  /// Double Line.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Hairline Border.
  /// </summary>
  [XmlEnum("hair")]
  Hair,
  
  /// <summary>
  /// Medium Dashed.
  /// </summary>
  [XmlEnum("mediumDashed")]
  MediumDashed,
  
  /// <summary>
  /// Dash Dot.
  /// </summary>
  [XmlEnum("dashDot")]
  DashDot,
  
  /// <summary>
  /// Medium Dash Dot.
  /// </summary>
  [XmlEnum("mediumDashDot")]
  MediumDashDot,
  
  /// <summary>
  /// Dash Dot Dot.
  /// </summary>
  [XmlEnum("dashDotDot")]
  DashDotDot,
  
  /// <summary>
  /// Medium Dash Dot Dot.
  /// </summary>
  [XmlEnum("mediumDashDotDot")]
  MediumDashDotDot,
  
  /// <summary>
  /// Slant Dash Dot.
  /// </summary>
  [XmlEnum("slantDashDot")]
  SlantDashDot,
  
}
