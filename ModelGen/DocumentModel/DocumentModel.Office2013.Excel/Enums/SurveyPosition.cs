namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the SurveyPosition enumeration.
/// </summary>
public enum SurveyPosition
{
  /// <summary>
  /// absolute.
  /// </summary>
  [XmlEnum("absolute")]
  Absolute,
  
  /// <summary>
  /// fixed.
  /// </summary>
  [XmlEnum("fixed")]
  Fixed,
  
  /// <summary>
  /// relative.
  /// </summary>
  [XmlEnum("relative")]
  Relative,
  
  /// <summary>
  /// static.
  /// </summary>
  [XmlEnum("static")]
  Static,
  
  /// <summary>
  /// inherit.
  /// </summary>
  [XmlEnum("inherit")]
  Inherit,
  
}
