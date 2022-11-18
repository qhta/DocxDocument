namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Text Wrapping Side
/// </summary>
public enum WrapSide
{
  /// <summary>
  /// Both sides.
  /// </summary>
  [XmlEnum("both")]
  Both,
  
  /// <summary>
  /// Left side.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Right side.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Largest side.
  /// </summary>
  [XmlEnum("largest")]
  Largest,
  
}
