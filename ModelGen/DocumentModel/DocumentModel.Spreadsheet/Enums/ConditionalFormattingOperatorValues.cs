namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Operators
/// </summary>
public enum ConditionalFormattingOperatorValues
{
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
  /// Greater Than Or Equal.
  /// </summary>
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  [XmlEnum("greaterThan")]
  GreaterThan,
  
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
  /// Contains.
  /// </summary>
  [XmlEnum("containsText")]
  ContainsText,
  
  /// <summary>
  /// Does Not Contain.
  /// </summary>
  [XmlEnum("notContains")]
  NotContains,
  
  /// <summary>
  /// Begins With.
  /// </summary>
  [XmlEnum("beginsWith")]
  BeginsWith,
  
  /// <summary>
  /// Ends With.
  /// </summary>
  [XmlEnum("endsWith")]
  EndsWith,
  
}
