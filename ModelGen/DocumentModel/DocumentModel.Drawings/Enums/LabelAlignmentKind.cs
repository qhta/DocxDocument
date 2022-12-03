namespace DocumentModel.Drawings;

/// <summary>
/// Label Alignment
/// </summary>
public enum LabelAlignmentKind
{
  /// <summary>
  /// Center.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
}
