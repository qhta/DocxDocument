namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextDirectionValues enumeration.
/// </summary>
public enum TextDirection
{
  /// <summary>
  /// Left to Right, Top to Bottom.
  /// </summary>
  [XmlEnum("lrTb")]
  LefToRightTopToBottom,
  
  /// <summary>
  /// tb.
  /// </summary>
  [XmlEnum("tb")]
  LeftToRightTopToBottom2010,
  
  /// <summary>
  /// Top to Bottom, Right to Left.
  /// </summary>
  [XmlEnum("tbRl")]
  TopToBottomRightToLeft,
  
  /// <summary>
  /// rl.
  /// </summary>
  [XmlEnum("rl")]
  TopToBottomRightToLeft2010,
  
  /// <summary>
  /// Bottom to Top, Left to Right.
  /// </summary>
  [XmlEnum("btLr")]
  BottomToTopLeftToRight,
  
  /// <summary>
  /// lr.
  /// </summary>
  [XmlEnum("lr")]
  BottomToTopLeftToRight2010,
  
  /// <summary>
  /// Left to Right, Top to Bottom Rotated.
  /// </summary>
  [XmlEnum("lrTbV")]
  LefttoRightTopToBottomRotated,
  
  /// <summary>
  /// tbV.
  /// </summary>
  [XmlEnum("tbV")]
  LeftToRightTopToBottomRotated2010,
  
  /// <summary>
  /// Top to Bottom, Right to Left Rotated.
  /// </summary>
  [XmlEnum("tbRlV")]
  TopToBottomRightToLeftRotated,
  
  /// <summary>
  /// rlV.
  /// </summary>
  [XmlEnum("rlV")]
  TopToBottomRightToLeftRotated2010,
  
  /// <summary>
  /// Top to Bottom, Left to Right Rotated.
  /// </summary>
  [XmlEnum("tbLrV")]
  TopToBottomLeftToRightRotated,
  
  /// <summary>
  /// lrV.
  /// </summary>
  [XmlEnum("lrV")]
  TopToBottomLeftToRightRotated2010,
  
}
