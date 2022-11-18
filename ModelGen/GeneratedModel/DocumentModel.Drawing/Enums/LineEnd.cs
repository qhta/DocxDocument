namespace DocumentModel.Drawing;

/// <summary>
/// Line End Type
/// </summary>
public enum LineEnd
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Triangle Arrow Head.
  /// </summary>
  [XmlEnum("triangle")]
  Triangle,
  
  /// <summary>
  /// Stealth Arrow.
  /// </summary>
  [XmlEnum("stealth")]
  Stealth,
  
  /// <summary>
  /// Diamond.
  /// </summary>
  [XmlEnum("diamond")]
  Diamond,
  
  /// <summary>
  /// Oval.
  /// </summary>
  [XmlEnum("oval")]
  Oval,
  
  /// <summary>
  /// Arrow Head.
  /// </summary>
  [XmlEnum("arrow")]
  Arrow,
  
}
