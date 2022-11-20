namespace DocumentModel.Spreadsheet;

/// <summary>
/// Show Data As
/// </summary>
public enum ShowDataAsValues
{
  /// <summary>
  /// Normal Data Type.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Difference.
  /// </summary>
  [XmlEnum("difference")]
  Difference,
  
  /// <summary>
  /// Percentage Of.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// Percentage Difference.
  /// </summary>
  [XmlEnum("percentDiff")]
  PercentageDifference,
  
  /// <summary>
  /// Running Total.
  /// </summary>
  [XmlEnum("runTotal")]
  RunTotal,
  
  /// <summary>
  /// Percentage of Row.
  /// </summary>
  [XmlEnum("percentOfRow")]
  PercentOfRaw,
  
  /// <summary>
  /// Percent of Column.
  /// </summary>
  [XmlEnum("percentOfCol")]
  PercentOfColumn,
  
  /// <summary>
  /// Percentage of Total.
  /// </summary>
  [XmlEnum("percentOfTotal")]
  PercentOfTotal,
  
  /// <summary>
  /// Index.
  /// </summary>
  [XmlEnum("index")]
  Index,
  
}
