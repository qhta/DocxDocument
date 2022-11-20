namespace DocumentModel.Vml.Office;

/// <summary>
/// Connector Type
/// </summary>
public enum ConnectorValues
{
  /// <summary>
  /// No Connector.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Straight Connector.
  /// </summary>
  [XmlEnum("straight")]
  Straight,
  
  /// <summary>
  /// Elbow Connector.
  /// </summary>
  [XmlEnum("elbow")]
  Elbow,
  
  /// <summary>
  /// Curved Connector.
  /// </summary>
  [XmlEnum("curved")]
  Curved,
  
}
