namespace DocumentModel.Vml;

/// <summary>
/// Connection Locations Type
/// </summary>
public enum ConnectKind
{
  /// <summary>
  /// No.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Four Connections.
  /// </summary>
  [XmlEnum("rect")]
  Rectangle,
  
  /// <summary>
  /// Edit Point Connections.
  /// </summary>
  [XmlEnum("segments")]
  Segments,
  
  /// <summary>
  /// Custom Connections.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
