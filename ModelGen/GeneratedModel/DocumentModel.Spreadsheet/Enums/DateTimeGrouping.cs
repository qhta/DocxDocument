namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Time Grouping
/// </summary>
public enum DateTimeGrouping
{
  /// <summary>
  /// Group by Year.
  /// </summary>
  [XmlEnum("year")]
  Year,
  
  /// <summary>
  /// Month.
  /// </summary>
  [XmlEnum("month")]
  Month,
  
  /// <summary>
  /// Day.
  /// </summary>
  [XmlEnum("day")]
  Day,
  
  /// <summary>
  /// Group by Hour.
  /// </summary>
  [XmlEnum("hour")]
  Hour,
  
  /// <summary>
  /// Group by Minute.
  /// </summary>
  [XmlEnum("minute")]
  Minute,
  
  /// <summary>
  /// Second.
  /// </summary>
  [XmlEnum("second")]
  Second,
  
}
