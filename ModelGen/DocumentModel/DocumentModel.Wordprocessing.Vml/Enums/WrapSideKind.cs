namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping Side
/// </summary>
public enum WrapSideKind
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
