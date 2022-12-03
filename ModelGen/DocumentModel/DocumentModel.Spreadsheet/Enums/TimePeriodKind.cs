namespace DocumentModel.Spreadsheet;

/// <summary>
/// Time Period Types
/// </summary>
public enum TimePeriodKind
{
  /// <summary>
  /// Today.
  /// </summary>
  [XmlEnum("today")]
  Today,
  
  /// <summary>
  /// Yesterday.
  /// </summary>
  [XmlEnum("yesterday")]
  Yesterday,
  
  /// <summary>
  /// Tomorrow.
  /// </summary>
  [XmlEnum("tomorrow")]
  Tomorrow,
  
  /// <summary>
  /// Last 7 Days.
  /// </summary>
  [XmlEnum("last7Days")]
  Last7Days,
  
  /// <summary>
  /// This Month.
  /// </summary>
  [XmlEnum("thisMonth")]
  ThisMonth,
  
  /// <summary>
  /// Last Month.
  /// </summary>
  [XmlEnum("lastMonth")]
  LastMonth,
  
  /// <summary>
  /// Next Month.
  /// </summary>
  [XmlEnum("nextMonth")]
  NextMonth,
  
  /// <summary>
  /// This Week.
  /// </summary>
  [XmlEnum("thisWeek")]
  ThisWeek,
  
  /// <summary>
  /// Last Week.
  /// </summary>
  [XmlEnum("lastWeek")]
  LastWeek,
  
  /// <summary>
  /// Next Week.
  /// </summary>
  [XmlEnum("nextWeek")]
  NextWeek,
  
}
