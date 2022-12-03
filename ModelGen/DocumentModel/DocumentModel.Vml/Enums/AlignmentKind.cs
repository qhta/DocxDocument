namespace DocumentModel.Vml;

/// <summary>
/// Alignment Type
/// </summary>
public enum AlignmentKind
{
  /// <summary>
  /// Top Alignment.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// Middle Alignment.
  /// </summary>
  [XmlEnum("middle")]
  Middle,
  
  /// <summary>
  /// Bottom Alignment.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
  /// <summary>
  /// Left Alignment.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Center Alignment.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Right Alignment.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
}
