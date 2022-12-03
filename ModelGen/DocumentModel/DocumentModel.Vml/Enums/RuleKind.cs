namespace DocumentModel.Vml;

/// <summary>
/// Rule Type
/// </summary>
public enum RuleKind
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
