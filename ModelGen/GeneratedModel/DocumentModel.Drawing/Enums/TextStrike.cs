namespace DocumentModel.Drawing;

/// <summary>
/// Text Strike Type
/// </summary>
public enum TextStrike
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
