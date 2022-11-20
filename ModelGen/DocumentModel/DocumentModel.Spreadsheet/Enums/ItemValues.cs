namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotItem Type
/// </summary>
public enum ItemValues
{
  /// <summary>
  /// Data.
  /// </summary>
  [XmlEnum("data")]
  Data,
  
  /// <summary>
  /// Default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// Sum.
  /// </summary>
  [XmlEnum("sum")]
  Sum,
  
  /// <summary>
  /// CountA.
  /// </summary>
  [XmlEnum("countA")]
  CountA,
  
  /// <summary>
  /// Average.
  /// </summary>
  [XmlEnum("avg")]
  Average,
  
  /// <summary>
  /// Max.
  /// </summary>
  [XmlEnum("max")]
  Maximum,
  
  /// <summary>
  /// Min.
  /// </summary>
  [XmlEnum("min")]
  Minimum,
  
  /// <summary>
  /// Product.
  /// </summary>
  [XmlEnum("product")]
  Product,
  
  /// <summary>
  /// Count.
  /// </summary>
  [XmlEnum("count")]
  Count,
  
  /// <summary>
  /// stdDev.
  /// </summary>
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  /// <summary>
  /// StdDevP.
  /// </summary>
  [XmlEnum("stdDevP")]
  StandardDeviationP,
  
  /// <summary>
  /// Var.
  /// </summary>
  [XmlEnum("var")]
  Variance,
  
  /// <summary>
  /// VarP.
  /// </summary>
  [XmlEnum("varP")]
  VarianceP,
  
  /// <summary>
  /// Grand Total Item.
  /// </summary>
  [XmlEnum("grand")]
  Grand,
  
  /// <summary>
  /// Blank Pivot Item.
  /// </summary>
  [XmlEnum("blank")]
  Blank,
  
}
