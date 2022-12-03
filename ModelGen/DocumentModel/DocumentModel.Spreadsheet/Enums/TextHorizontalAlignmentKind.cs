namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TextHorizontalAlignmentValues enumeration.
/// </summary>
public enum TextHorizontalAlignmentKind
{
  /// <summary>
  /// left.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// justify.
  /// </summary>
  [XmlEnum("justify")]
  Justify,
  
  /// <summary>
  /// distributed.
  /// </summary>
  [XmlEnum("distributed")]
  Distributed,
  
}
