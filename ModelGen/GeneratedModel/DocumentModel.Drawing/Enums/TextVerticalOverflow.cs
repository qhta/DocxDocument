namespace DocumentModel.Drawing;

/// <summary>
/// Text Vertical Overflow
/// </summary>
public enum TextVerticalOverflow
{
  /// <summary>
  /// Text Overflow Enum ( Overflow ).
  /// </summary>
  [XmlEnum("overflow")]
  Overflow,
  
  /// <summary>
  /// Text Overflow Enum ( Ellipsis ).
  /// </summary>
  [XmlEnum("ellipsis")]
  Ellipsis,
  
  /// <summary>
  /// Text Overflow Enum ( Clip ).
  /// </summary>
  [XmlEnum("clip")]
  Clip,
  
}
