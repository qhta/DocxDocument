namespace DocumentModel.Vml.Office;

/// <summary>
/// Rule Type
/// </summary>
public enum RuleValues
{
  /// <summary>
  /// Arc Rule.
  /// </summary>
  [XmlEnum("arc")]
  Arc,
  
  /// <summary>
  /// Callout Rule.
  /// </summary>
  [XmlEnum("callout")]
  Callout,
  
  /// <summary>
  /// Connector Rule.
  /// </summary>
  [XmlEnum("connector")]
  Connector,
  
}
