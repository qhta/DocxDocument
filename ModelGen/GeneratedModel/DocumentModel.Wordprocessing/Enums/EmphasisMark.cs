namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EmphasisMarkValues enumeration.
/// </summary>
public enum EmphasisMark
{
  /// <summary>
  /// No Emphasis Mark.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Dot Emphasis Mark Above Characters.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// Comma Emphasis Mark Above Characters.
  /// </summary>
  [XmlEnum("comma")]
  Comma,
  
  /// <summary>
  /// Circle Emphasis Mark Above Characters.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// Dot Emphasis Mark Below Characters.
  /// </summary>
  [XmlEnum("underDot")]
  UnderDot,
  
}
