namespace DocumentModel.Drawing;

/// <summary>
/// Text Horizontal Overflow Types
/// </summary>
public enum TextHorizontalOverflow
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
