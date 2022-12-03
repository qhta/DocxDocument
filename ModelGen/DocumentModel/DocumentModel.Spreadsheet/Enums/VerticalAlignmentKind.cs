namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Alignment Types
/// </summary>
public enum VerticalAlignmentKind
{
  /// <summary>
  /// Align Top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// Centered Vertical Alignment.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Aligned To Bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
  /// <summary>
  /// Justified Vertically.
  /// </summary>
  [XmlEnum("justify")]
  Justify,
  
  /// <summary>
  /// Distributed Vertical Alignment.
  /// </summary>
  [XmlEnum("distributed")]
  Distributed,
  
}
