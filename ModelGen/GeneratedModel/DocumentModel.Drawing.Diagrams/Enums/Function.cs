namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Function Type
/// </summary>
public enum Function
{
  /// <summary>
  /// Count.
  /// </summary>
  [XmlEnum("cnt")]
  Count,
  
  /// <summary>
  /// Position.
  /// </summary>
  [XmlEnum("pos")]
  Position,
  
  /// <summary>
  /// Reverse Position.
  /// </summary>
  [XmlEnum("revPos")]
  ReversePosition,
  
  /// <summary>
  /// Position Even.
  /// </summary>
  [XmlEnum("posEven")]
  PositionEven,
  
  /// <summary>
  /// Position Odd.
  /// </summary>
  [XmlEnum("posOdd")]
  PositionOdd,
  
  /// <summary>
  /// Variable.
  /// </summary>
  [XmlEnum("var")]
  Variable,
  
  /// <summary>
  /// Depth.
  /// </summary>
  [XmlEnum("depth")]
  Depth,
  
  /// <summary>
  /// Max Depth.
  /// </summary>
  [XmlEnum("maxDepth")]
  MaxDepth,
  
}
