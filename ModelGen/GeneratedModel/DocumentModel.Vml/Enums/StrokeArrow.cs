namespace DocumentModel.Vml;

/// <summary>
/// Stroke Arrowhead Type
/// </summary>
public enum StrokeArrow
{
  /// <summary>
  /// No Arrowhead.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Block Arrowhead.
  /// </summary>
  [XmlEnum("block")]
  Block,
  
  /// <summary>
  /// Classic Arrowhead.
  /// </summary>
  [XmlEnum("classic")]
  Classic,
  
  /// <summary>
  /// Oval Arrowhead.
  /// </summary>
  [XmlEnum("oval")]
  Oval,
  
  /// <summary>
  /// Diamond Arrowhead.
  /// </summary>
  [XmlEnum("diamond")]
  Diamond,
  
  /// <summary>
  /// Open Arrowhead.
  /// </summary>
  [XmlEnum("open")]
  Open,
  
}
