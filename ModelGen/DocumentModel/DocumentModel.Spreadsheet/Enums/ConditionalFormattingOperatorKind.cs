namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Operators
/// </summary>
public enum ConditionalFormattingOperatorKind
{
  /// <summary>
  /// Less Than.
  /// </summary>
  LessThan,
  
  /// <summary>
  /// Less Than Or Equal.
  /// </summary>
  LessThanOrEqual,
  
  /// <summary>
  /// Equal.
  /// </summary>
  Equal,
  
  /// <summary>
  /// Not Equal.
  /// </summary>
  NotEqual,
  
  /// <summary>
  /// Greater Than Or Equal.
  /// </summary>
  GreaterThanOrEqual,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  GreaterThan,
  
  /// <summary>
  /// Between.
  /// </summary>
  Between,
  
  /// <summary>
  /// Not Between.
  /// </summary>
  NotBetween,
  
  /// <summary>
  /// Contains.
  /// </summary>
  ContainsText,
  
  /// <summary>
  /// Does Not Contain.
  /// </summary>
  NotContains,
  
  /// <summary>
  /// Begins With.
  /// </summary>
  BeginsWith,
  
  /// <summary>
  /// Ends With.
  /// </summary>
  EndsWith,
  
}
