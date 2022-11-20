namespace DocumentModel.Spreadsheet;

/// <summary>
/// Totals Row Function Types
/// </summary>
public enum TotalsRowFunctionValues
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Sum.
  /// </summary>
  [XmlEnum("sum")]
  Sum,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  [XmlEnum("min")]
  Minimum,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  [XmlEnum("max")]
  Maximum,
  
  /// <summary>
  /// Average.
  /// </summary>
  [XmlEnum("average")]
  Average,
  
  /// <summary>
  /// Non Empty Cell Count.
  /// </summary>
  [XmlEnum("count")]
  Count,
  
  /// <summary>
  /// Count Numbers.
  /// </summary>
  [XmlEnum("countNums")]
  CountNumbers,
  
  /// <summary>
  /// StdDev.
  /// </summary>
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  /// <summary>
  /// Var.
  /// </summary>
  [XmlEnum("var")]
  Variance,
  
  /// <summary>
  /// Custom Formula.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
