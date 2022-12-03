namespace DocumentModel.Drawings;

/// <summary>
/// Text Strike Type
/// </summary>
public enum TextStrikeKind
{
  /// <summary>
  /// Text Strike Enum ( No Strike ).
  /// </summary>
  [XmlEnum("noStrike")]
  NoStrike,
  
  /// <summary>
  /// Text Strike Enum ( Single Strike ).
  /// </summary>
  [XmlEnum("sngStrike")]
  SingleStrike,
  
  /// <summary>
  /// Text Strike Enum ( Double Strike ).
  /// </summary>
  [XmlEnum("dblStrike")]
  DoubleStrike,
  
}
