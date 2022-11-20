namespace DocumentModel.Drawing;

/// <summary>
/// Text Tab Alignment Types
/// </summary>
public enum TextTabAlignmentValues
{
  /// <summary>
  /// Text Tab Alignment Enum ( Left).
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Text Tab Alignment Enum ( Center ).
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Text Tab Alignment Enum ( Right ).
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Text Tab Alignment Enum ( Decimal ).
  /// </summary>
  [XmlEnum("dec")]
  Decimal,
  
}
