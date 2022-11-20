namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the UnderlineValues enumeration.
/// </summary>
public enum UnderlineValues
{
  /// <summary>
  /// Single Underline.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Underline Non-Space Characters Only.
  /// </summary>
  [XmlEnum("words")]
  Words,
  
  /// <summary>
  /// Double Underline.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Thick Underline.
  /// </summary>
  [XmlEnum("thick")]
  Thick,
  
  /// <summary>
  /// Dotted Underline.
  /// </summary>
  [XmlEnum("dotted")]
  Dotted,
  
  /// <summary>
  /// Thick Dotted Underline.
  /// </summary>
  [XmlEnum("dottedHeavy")]
  DottedHeavy,
  
  /// <summary>
  /// Dashed Underline.
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// Thick Dashed Underline.
  /// </summary>
  [XmlEnum("dashedHeavy")]
  DashedHeavy,
  
  /// <summary>
  /// Long Dashed Underline.
  /// </summary>
  [XmlEnum("dashLong")]
  DashLong,
  
  /// <summary>
  /// Thick Long Dashed Underline.
  /// </summary>
  [XmlEnum("dashLongHeavy")]
  DashLongHeavy,
  
  /// <summary>
  /// Dash-Dot Underline.
  /// </summary>
  [XmlEnum("dotDash")]
  DotDash,
  
  /// <summary>
  /// Thick Dash-Dot Underline.
  /// </summary>
  [XmlEnum("dashDotHeavy")]
  DashDotHeavy,
  
  /// <summary>
  /// Dash-Dot-Dot Underline.
  /// </summary>
  [XmlEnum("dotDotDash")]
  DotDotDash,
  
  /// <summary>
  /// Thick Dash-Dot-Dot Underline.
  /// </summary>
  [XmlEnum("dashDotDotHeavy")]
  DashDotDotHeavy,
  
  /// <summary>
  /// Wave Underline.
  /// </summary>
  [XmlEnum("wave")]
  Wave,
  
  /// <summary>
  /// Heavy Wave Underline.
  /// </summary>
  [XmlEnum("wavyHeavy")]
  WavyHeavy,
  
  /// <summary>
  /// Double Wave Underline.
  /// </summary>
  [XmlEnum("wavyDouble")]
  WavyDouble,
  
  /// <summary>
  /// No Underline.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
