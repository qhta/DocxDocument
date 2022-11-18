namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeightRuleValues enumeration.
/// </summary>
public enum HeightRule
{
  /// <summary>
  /// Determine Height Based On Contents.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Exact Height.
  /// </summary>
  [XmlEnum("exact")]
  Exact,
  
  /// <summary>
  /// Minimum Height.
  /// </summary>
  [XmlEnum("atLeast")]
  AtLeast,
  
}
