namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dynamic Filter
/// </summary>
public enum DynamicFilter
{
  /// <summary>
  /// Null.
  /// </summary>
  [XmlEnum("null")]
  Null,
  
  /// <summary>
  /// Above Average.
  /// </summary>
  [XmlEnum("aboveAverage")]
  AboveAverage,
  
  /// <summary>
  /// Below Average.
  /// </summary>
  [XmlEnum("belowAverage")]
  BelowAverage,
  
  /// <summary>
  /// Tomorrow.
  /// </summary>
  [XmlEnum("tomorrow")]
  Tomorrow,
  
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
  /// Next Week.
  /// </summary>
  [XmlEnum("nextWeek")]
  NextWeek,
  
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
  /// Next Month.
  /// </summary>
  [XmlEnum("nextMonth")]
  NextMonth,
  
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
  /// Next Quarter.
  /// </summary>
  [XmlEnum("nextQuarter")]
  NextQuarter,
  
  /// <summary>
  /// This Quarter.
  /// </summary>
  [XmlEnum("thisQuarter")]
  ThisQuarter,
  
  /// <summary>
  /// Last Quarter.
  /// </summary>
  [XmlEnum("lastQuarter")]
  LastQuarter,
  
  /// <summary>
  /// Next Year.
  /// </summary>
  [XmlEnum("nextYear")]
  NextYear,
  
  /// <summary>
  /// This Year.
  /// </summary>
  [XmlEnum("thisYear")]
  ThisYear,
  
  /// <summary>
  /// Last Year.
  /// </summary>
  [XmlEnum("lastYear")]
  LastYear,
  
  /// <summary>
  /// Year To Date.
  /// </summary>
  [XmlEnum("yearToDate")]
  YearToDate,
  
  /// <summary>
  /// 1st Quarter.
  /// </summary>
  [XmlEnum("Q1")]
  Quarter1,
  
  /// <summary>
  /// 2nd Quarter.
  /// </summary>
  [XmlEnum("Q2")]
  Quarter2,
  
  /// <summary>
  /// 3rd Quarter.
  /// </summary>
  [XmlEnum("Q3")]
  Quarter3,
  
  /// <summary>
  /// 4th Quarter.
  /// </summary>
  [XmlEnum("Q4")]
  Quarter4,
  
  /// <summary>
  /// 1st Month.
  /// </summary>
  [XmlEnum("M1")]
  January,
  
  /// <summary>
  /// 2nd Month.
  /// </summary>
  [XmlEnum("M2")]
  February,
  
  /// <summary>
  /// 3rd Month.
  /// </summary>
  [XmlEnum("M3")]
  March,
  
  /// <summary>
  /// 4th Month.
  /// </summary>
  [XmlEnum("M4")]
  April,
  
  /// <summary>
  /// 5th Month.
  /// </summary>
  [XmlEnum("M5")]
  May,
  
  /// <summary>
  /// 6th Month.
  /// </summary>
  [XmlEnum("M6")]
  June,
  
  /// <summary>
  /// 7th Month.
  /// </summary>
  [XmlEnum("M7")]
  July,
  
  /// <summary>
  /// 8th Month.
  /// </summary>
  [XmlEnum("M8")]
  August,
  
  /// <summary>
  /// 9th Month.
  /// </summary>
  [XmlEnum("M9")]
  September,
  
  /// <summary>
  /// 10th Month.
  /// </summary>
  [XmlEnum("M10")]
  October,
  
  /// <summary>
  /// 11th Month.
  /// </summary>
  [XmlEnum("M11")]
  November,
  
  /// <summary>
  /// 12th Month.
  /// </summary>
  [XmlEnum("M12")]
  December,
  
}
