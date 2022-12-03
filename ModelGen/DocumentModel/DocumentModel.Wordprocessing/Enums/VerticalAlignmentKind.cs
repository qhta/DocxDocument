namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalAlignmentValues enumeration.
/// </summary>
public enum VerticalAlignmentKind
{
  /// <summary>
  /// In line With Text.
  /// </summary>
  [XmlEnum("inline")]
  Inline,
  
  /// <summary>
  /// Top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// Centered Vertically.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
  /// <summary>
  /// Inside Anchor Extents.
  /// </summary>
  [XmlEnum("inside")]
  Inside,
  
  /// <summary>
  /// Outside Anchor Extents.
  /// </summary>
  [XmlEnum("outside")]
  Outside,
  
}
