namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation Functions
/// </summary>
public enum DataConsolidateFunction
{
  /// <summary>
  /// Average.
  /// </summary>
  [XmlEnum("average")]
  Average,
  
  /// <summary>
  /// Count.
  /// </summary>
  [XmlEnum("count")]
  Count,
  
  /// <summary>
  /// CountNums.
  /// </summary>
  [XmlEnum("countNums")]
  CountNumbers,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  [XmlEnum("max")]
  Maximum,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  [XmlEnum("min")]
  Minimum,
  
  /// <summary>
  /// Product.
  /// </summary>
  [XmlEnum("product")]
  Product,
  
  /// <summary>
  /// StdDev.
  /// </summary>
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  /// <summary>
  /// StdDevP.
  /// </summary>
  [XmlEnum("stdDevp")]
  StandardDeviationP,
  
  /// <summary>
  /// Sum.
  /// </summary>
  [XmlEnum("sum")]
  Sum,
  
  /// <summary>
  /// Variance.
  /// </summary>
  [XmlEnum("var")]
  Variance,
  
  /// <summary>
  /// VarP.
  /// </summary>
  [XmlEnum("varp")]
  VarianceP,
  
}
