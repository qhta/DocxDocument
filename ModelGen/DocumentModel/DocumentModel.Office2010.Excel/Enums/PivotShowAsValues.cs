namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotShowAsValues enumeration.
/// </summary>
public enum PivotShowAsValues
{
  /// <summary>
  /// percentOfParent.
  /// </summary>
  [XmlEnum("percentOfParent")]
  PercentOfParent,
  
  /// <summary>
  /// percentOfParentRow.
  /// </summary>
  [XmlEnum("percentOfParentRow")]
  PercentOfParentRow,
  
  /// <summary>
  /// percentOfParentCol.
  /// </summary>
  [XmlEnum("percentOfParentCol")]
  PercentOfParentColumn,
  
  /// <summary>
  /// percentOfRunningTotal.
  /// </summary>
  [XmlEnum("percentOfRunningTotal")]
  PercentOfRunningTotal,
  
  /// <summary>
  /// rankAscending.
  /// </summary>
  [XmlEnum("rankAscending")]
  RankAscending,
  
  /// <summary>
  /// rankDescending.
  /// </summary>
  [XmlEnum("rankDescending")]
  RankDescending,
  
}
