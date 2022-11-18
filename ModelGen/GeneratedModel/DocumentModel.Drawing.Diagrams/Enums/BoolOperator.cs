namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Boolean Constraint
/// </summary>
public enum BoolOperator
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Equal.
  /// </summary>
  [XmlEnum("equ")]
  Equal,
  
  /// <summary>
  /// Greater Than or Equal to.
  /// </summary>
  [XmlEnum("gte")]
  GreaterThanOrEqualTo,
  
  /// <summary>
  /// Less Than or Equal to.
  /// </summary>
  [XmlEnum("lte")]
  LessThanOrEqualTo,
  
}
