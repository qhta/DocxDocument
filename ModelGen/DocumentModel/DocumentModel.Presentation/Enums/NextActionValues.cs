namespace DocumentModel.Presentation;

/// <summary>
/// Next Action Type
/// </summary>
public enum NextActionValues
{
  /// <summary>
  /// Next Action Type Enum ( None ).
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Next Action Type Enum ( Seek ).
  /// </summary>
  [XmlEnum("seek")]
  Seek,
  
}
