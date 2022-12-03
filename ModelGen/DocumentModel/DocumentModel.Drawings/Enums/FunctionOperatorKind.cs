namespace DocumentModel.Drawings;

/// <summary>
/// Function Operator
/// </summary>
public enum FunctionOperatorKind
{
  /// <summary>
  /// Equal.
  /// </summary>
  [XmlEnum("equ")]
  Equal,
  
  /// <summary>
  /// Not Equal To.
  /// </summary>
  [XmlEnum("neq")]
  NotEqualTo,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  [XmlEnum("gt")]
  GreaterThan,
  
  /// <summary>
  /// Less Than.
  /// </summary>
  [XmlEnum("lt")]
  LessThan,
  
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
