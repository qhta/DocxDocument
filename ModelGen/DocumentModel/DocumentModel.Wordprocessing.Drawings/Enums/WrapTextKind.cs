namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Text Wrapping Location
/// </summary>
public enum WrapTextKind
{
  /// <summary>
  /// Both Sides.
  /// </summary>
  [XmlEnum("bothSides")]
  BothSides,
  
  /// <summary>
  /// Left Side Only.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Right Side Only.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Largest Side Only.
  /// </summary>
  [XmlEnum("largest")]
  Largest,
  
}
