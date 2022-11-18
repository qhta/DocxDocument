namespace DocumentModel.Drawing;

/// <summary>
/// Text Alignment Types
/// </summary>
public enum TextAlignmentType
{
  /// <summary>
  /// Text Alignment Enum ( Left ).
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Text Alignment Enum ( Center ).
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Text Alignment Enum ( Right ).
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Text Alignment Enum ( Justified ).
  /// </summary>
  [XmlEnum("just")]
  Justified,
  
  /// <summary>
  /// Text Alignment Enum ( Justified Low ).
  /// </summary>
  [XmlEnum("justLow")]
  JustifiedLow,
  
  /// <summary>
  /// Text Alignment Enum ( Distributed ).
  /// </summary>
  [XmlEnum("dist")]
  Distributed,
  
  /// <summary>
  /// Text Alignment Enum ( Thai Distributed ).
  /// </summary>
  [XmlEnum("thaiDist")]
  ThaiDistributed,
  
}
