namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineSpacingRuleValues enumeration.
/// </summary>
public enum LineSpacingRuleValues
{
  /// <summary>
  /// Automatically Determined Line Height.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Exact Line Height.
  /// </summary>
  [XmlEnum("exact")]
  Exact,
  
  /// <summary>
  /// Minimum Line Height.
  /// </summary>
  [XmlEnum("atLeast")]
  AtLeast,
  
}
