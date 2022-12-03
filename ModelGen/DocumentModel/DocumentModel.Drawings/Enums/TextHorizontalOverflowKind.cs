namespace DocumentModel.Drawings;

/// <summary>
/// Text Horizontal Overflow Types
/// </summary>
public enum TextHorizontalOverflowKind
{
  /// <summary>
  /// Text Horizontal Overflow Enum ( Overflow ).
  /// </summary>
  [XmlEnum("overflow")]
  Overflow,
  
  /// <summary>
  /// Text Horizontal Overflow Enum ( Clip ).
  /// </summary>
  [XmlEnum("clip")]
  Clip,
  
}
