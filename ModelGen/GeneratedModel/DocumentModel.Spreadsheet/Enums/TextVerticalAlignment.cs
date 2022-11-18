namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TextVerticalAlignmentValues enumeration.
/// </summary>
public enum TextVerticalAlignment
{
  /// <summary>
  /// top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
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
