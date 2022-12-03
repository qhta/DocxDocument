namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Alignment Type
/// </summary>
public enum HorizontalAlignmentKind
{
  /// <summary>
  /// General Horizontal Alignment.
  /// </summary>
  [XmlEnum("general")]
  General,
  
  /// <summary>
  /// Left Horizontal Alignment.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Centered Horizontal Alignment.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Right Horizontal Alignment.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Fill.
  /// </summary>
  [XmlEnum("fill")]
  Fill,
  
  /// <summary>
  /// Justify.
  /// </summary>
  [XmlEnum("justify")]
  Justify,
  
  /// <summary>
  /// Center Continuous Horizontal Alignment.
  /// </summary>
  [XmlEnum("centerContinuous")]
  CenterContinuous,
  
  /// <summary>
  /// Distributed Horizontal Alignment.
  /// </summary>
  [XmlEnum("distributed")]
  Distributed,
  
}
