namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HorizontalAlignmentValues enumeration.
/// </summary>
public enum HorizontalAlignmentValues
{
  /// <summary>
  /// Left Aligned Horizontally.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Centered Horizontally.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Right Aligned Horizontally.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Inside.
  /// </summary>
  [XmlEnum("inside")]
  Inside,
  
  /// <summary>
  /// Outside.
  /// </summary>
  [XmlEnum("outside")]
  Outside,
  
}
