namespace DocumentModel.Drawings;

/// <summary>
/// Text Underline Types
/// </summary>
public enum TextUnderlineKind
{
  /// <summary>
  /// Text Underline Enum ( None ).
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Text Underline Enum ( Words ).
  /// </summary>
  [XmlEnum("words")]
  Words,
  
  /// <summary>
  /// Text Underline Enum ( Single ).
  /// </summary>
  [XmlEnum("sng")]
  Single,
  
  /// <summary>
  /// Text Underline Enum ( Double ).
  /// </summary>
  [XmlEnum("dbl")]
  Double,
  
  /// <summary>
  /// Text Underline Enum ( Heavy ).
  /// </summary>
  [XmlEnum("heavy")]
  Heavy,
  
  /// <summary>
  /// Text Underline Enum ( Dotted ).
  /// </summary>
  [XmlEnum("dotted")]
  Dotted,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Dotted  ).
  /// </summary>
  [XmlEnum("dottedHeavy")]
  HeavyDotted,
  
  /// <summary>
  /// Text Underline Enum ( Dashed ).
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Dashed ).
  /// </summary>
  [XmlEnum("dashHeavy")]
  DashHeavy,
  
  /// <summary>
  /// Text Underline Enum ( Long Dashed ).
  /// </summary>
  [XmlEnum("dashLong")]
  DashLong,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Long Dashed ).
  /// </summary>
  [XmlEnum("dashLongHeavy")]
  DashLongHeavy,
  
  /// <summary>
  /// Text Underline Enum ( Dot Dash ).
  /// </summary>
  [XmlEnum("dotDash")]
  DotDash,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Dot Dash ).
  /// </summary>
  [XmlEnum("dotDashHeavy")]
  DotDashHeavy,
  
  /// <summary>
  /// Text Underline Enum ( Dot Dot Dash ).
  /// </summary>
  [XmlEnum("dotDotDash")]
  DotDotDash,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Dot Dot Dash ).
  /// </summary>
  [XmlEnum("dotDotDashHeavy")]
  DotDotDashHeavy,
  
  /// <summary>
  /// Text Underline Enum ( Wavy ).
  /// </summary>
  [XmlEnum("wavy")]
  Wavy,
  
  /// <summary>
  /// Text Underline Enum ( Heavy Wavy ).
  /// </summary>
  [XmlEnum("wavyHeavy")]
  WavyHeavy,
  
  /// <summary>
  /// Text Underline Enum ( Double Wavy ).
  /// </summary>
  [XmlEnum("wavyDbl")]
  WavyDouble,
  
}
