namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation Operator
/// </summary>
public enum DataValidationOperator
{
  /// <summary>
  /// Between.
  /// </summary>
  [XmlEnum("between")]
  Between,
  
  /// <summary>
  /// Not Between.
  /// </summary>
  [XmlEnum("notBetween")]
  NotBetween,
  
  /// <summary>
  /// Equal.
  /// </summary>
  [XmlEnum("equal")]
  Equal,
  
  /// <summary>
  /// Not Equal.
  /// </summary>
  [XmlEnum("notEqual")]
  NotEqual,
  
  /// <summary>
  /// Less Than.
  /// </summary>
  [XmlEnum("lessThan")]
  LessThan,
  
  /// <summary>
  /// Less Than Or Equal.
  /// </summary>
  [XmlEnum("lessThanOrEqual")]
  LessThanOrEqual,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  [XmlEnum("greaterThan")]
  GreaterThan,
  
  /// <summary>
  /// Greater Than Or Equal.
  /// </summary>
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
  
}
