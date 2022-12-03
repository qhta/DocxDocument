namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter Operator
/// </summary>
public enum FilterOperatorKind
{
  /// <summary>
  /// Equal.
  /// </summary>
  [XmlEnum("equal")]
  Equal,
  
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
  /// Not Equal.
  /// </summary>
  [XmlEnum("notEqual")]
  NotEqual,
  
  /// <summary>
  /// Greater Than Or Equal.
  /// </summary>
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  [XmlEnum("greaterThan")]
  GreaterThan,
  
}
