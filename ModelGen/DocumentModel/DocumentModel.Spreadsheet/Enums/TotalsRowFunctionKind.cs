namespace DocumentModel.Spreadsheet;

/// <summary>
/// Totals Row Function Types
/// </summary>
public enum TotalsRowFunctionKind
{
  /// <summary>
  /// None.
  /// </summary>
  None,
  
  /// <summary>
  /// Sum.
  /// </summary>
  Sum,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  Minimum,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  Maximum,
  
  /// <summary>
  /// Average.
  /// </summary>
  Average,
  
  /// <summary>
  /// Non Empty Cell Count.
  /// </summary>
  Count,
  
  /// <summary>
  /// Count Numbers.
  /// </summary>
  CountNumbers,
  
  /// <summary>
  /// StdDev.
  /// </summary>
  StandardDeviation,
  
  /// <summary>
  /// Var.
  /// </summary>
  Variance,
  
  /// <summary>
  /// Custom Formula.
  /// </summary>
  Custom,
  
}
