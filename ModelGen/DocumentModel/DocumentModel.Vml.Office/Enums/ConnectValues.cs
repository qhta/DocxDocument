namespace DocumentModel.Vml.Office;

/// <summary>
/// Connection Locations Type
/// </summary>
public enum ConnectValues
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
