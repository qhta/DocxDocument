namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotItem Type
/// </summary>
public enum ItemKind
{
  /// <summary>
  /// Data.
  /// </summary>
  Data,
  
  /// <summary>
  /// Default.
  /// </summary>
  Default,
  
  /// <summary>
  /// Sum.
  /// </summary>
  Sum,
  
  /// <summary>
  /// CountA.
  /// </summary>
  CountA,
  
  /// <summary>
  /// Average.
  /// </summary>
  Average,
  
  /// <summary>
  /// Max.
  /// </summary>
  Maximum,
  
  /// <summary>
  /// Min.
  /// </summary>
  Minimum,
  
  /// <summary>
  /// Product.
  /// </summary>
  Product,
  
  /// <summary>
  /// Count.
  /// </summary>
  Count,
  
  /// <summary>
  /// stdDev.
  /// </summary>
  StandardDeviation,
  
  /// <summary>
  /// StdDevP.
  /// </summary>
  StandardDeviationP,
  
  /// <summary>
  /// Var.
  /// </summary>
  Variance,
  
  /// <summary>
  /// VarP.
  /// </summary>
  VarianceP,
  
  /// <summary>
  /// Grand Total Item.
  /// </summary>
  Grand,
  
  /// <summary>
  /// Blank Pivot Item.
  /// </summary>
  Blank,
  
}
