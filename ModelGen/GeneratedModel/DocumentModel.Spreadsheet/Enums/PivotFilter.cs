namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pivot Filter Types
/// </summary>
public enum PivotFilter
{
  /// <summary>
  /// Unknown.
  /// </summary>
  [XmlEnum("unknown")]
  Unknown,
  
  /// <summary>
  /// Count.
  /// </summary>
  [XmlEnum("count")]
  Count,
  
  /// <summary>
  /// Percent.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// Sum.
  /// </summary>
  [XmlEnum("sum")]
  Sum,
  
  /// <summary>
  /// Caption Equals.
  /// </summary>
  [XmlEnum("captionEqual")]
  CaptionEqual,
  
  /// <summary>
  /// Caption Not Equal.
  /// </summary>
  [XmlEnum("captionNotEqual")]
  CaptionNotEqual,
  
  /// <summary>
  /// Caption Begins With.
  /// </summary>
  [XmlEnum("captionBeginsWith")]
  CaptionBeginsWith,
  
  /// <summary>
  /// Caption Does Not Begin With.
  /// </summary>
  [XmlEnum("captionNotBeginsWith")]
  CaptionNotBeginsWith,
  
  /// <summary>
  /// Caption Ends With.
  /// </summary>
  [XmlEnum("captionEndsWith")]
  CaptionEndsWith,
  
  /// <summary>
  /// Caption Does Not End With.
  /// </summary>
  [XmlEnum("captionNotEndsWith")]
  CaptionNotEndsWith,
  
  /// <summary>
  /// Caption Contains.
  /// </summary>
  [XmlEnum("captionContains")]
  CaptionContains,
  
  /// <summary>
  /// Caption Does Not Contain.
  /// </summary>
  [XmlEnum("captionNotContains")]
  CaptionNotContains,
  
  /// <summary>
  /// Caption Is Greater Than.
  /// </summary>
  [XmlEnum("captionGreaterThan")]
  CaptionGreaterThan,
  
  /// <summary>
  /// Caption Is Greater Than Or Equal To.
  /// </summary>
  [XmlEnum("captionGreaterThanOrEqual")]
  CaptionGreaterThanOrEqual,
  
  /// <summary>
  /// Caption Is Less Than.
  /// </summary>
  [XmlEnum("captionLessThan")]
  CaptionLessThan,
  
  /// <summary>
  /// Caption Is Less Than Or Equal To.
  /// </summary>
  [XmlEnum("captionLessThanOrEqual")]
  CaptionLessThanOrEqual,
  
  /// <summary>
  /// Caption Is Between.
  /// </summary>
  [XmlEnum("captionBetween")]
  CaptionBetween,
  
  /// <summary>
  /// Caption Is Not Between.
  /// </summary>
  [XmlEnum("captionNotBetween")]
  CaptionNotBetween,
  
  /// <summary>
  /// Value Equal.
  /// </summary>
  [XmlEnum("valueEqual")]
  ValueEqual,
  
  /// <summary>
  /// Value Not Equal.
  /// </summary>
  [XmlEnum("valueNotEqual")]
  ValueNotEqual,
  
  /// <summary>
  /// Value Greater Than.
  /// </summary>
  [XmlEnum("valueGreaterThan")]
  ValueGreaterThan,
  
  /// <summary>
  /// Value Greater Than Or Equal To.
  /// </summary>
  [XmlEnum("valueGreaterThanOrEqual")]
  ValueGreaterThanOrEqual,
  
  /// <summary>
  /// Value Less Than.
  /// </summary>
  [XmlEnum("valueLessThan")]
  ValueLessThan,
  
  /// <summary>
  /// Value Less Than Or Equal To.
  /// </summary>
  [XmlEnum("valueLessThanOrEqual")]
  ValueLessThanOrEqual,
  
  /// <summary>
  /// Value Between.
  /// </summary>
  [XmlEnum("valueBetween")]
  ValueBetween,
  
  /// <summary>
  /// Value Not Between.
  /// </summary>
  [XmlEnum("valueNotBetween")]
  ValueNotBetween,
  
  /// <summary>
  /// Date Equals.
  /// </summary>
  [XmlEnum("dateEqual")]
  DateEqual,
  
  /// <summary>
  /// Date Does Not Equal.
  /// </summary>
  [XmlEnum("dateNotEqual")]
  DateNotEqual,
  
  /// <summary>
  /// Date Older Than.
  /// </summary>
  [XmlEnum("dateOlderThan")]
  DateOlderThan,
  
  /// <summary>
  /// Date Older Than Or Equal.
  /// </summary>
  [XmlEnum("dateOlderThanOrEqual")]
  DateOlderThanOrEqual,
  
  /// <summary>
  /// Date Newer Than.
  /// </summary>
  [XmlEnum("dateNewerThan")]
  DateNewerThan,
  
  /// <summary>
  /// Date Newer Than or Equal To.
  /// </summary>
  [XmlEnum("dateNewerThanOrEqual")]
  DateNewerThanOrEqual,
  
  /// <summary>
  /// Date Between.
  /// </summary>
  [XmlEnum("dateBetween")]
  DateBetween,
  
  /// <summary>
  /// Date Not Between.
  /// </summary>
  [XmlEnum("dateNotBetween")]
  DateNotBetween,
  
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
  /// Year-To-Date.
  /// </summary>
  [XmlEnum("yearToDate")]
  YearToDate,
  
  /// <summary>
  /// First Quarter.
  /// </summary>
  [XmlEnum("Q1")]
  Quarter1,
  
  /// <summary>
  /// Second Quarter.
  /// </summary>
  [XmlEnum("Q2")]
  Quarter2,
  
  /// <summary>
  /// Third Quarter.
  /// </summary>
  [XmlEnum("Q3")]
  Quarter3,
  
  /// <summary>
  /// Fourth Quarter.
  /// </summary>
  [XmlEnum("Q4")]
  Quarter4,
  
  /// <summary>
  /// January.
  /// </summary>
  [XmlEnum("M1")]
  January,
  
  /// <summary>
  /// Dates in February.
  /// </summary>
  [XmlEnum("M2")]
  February,
  
  /// <summary>
  /// Dates in March.
  /// </summary>
  [XmlEnum("M3")]
  March,
  
  /// <summary>
  /// Dates in April.
  /// </summary>
  [XmlEnum("M4")]
  April,
  
  /// <summary>
  /// Dates in May.
  /// </summary>
  [XmlEnum("M5")]
  May,
  
  /// <summary>
  /// Dates in June.
  /// </summary>
  [XmlEnum("M6")]
  June,
  
  /// <summary>
  /// Dates in July.
  /// </summary>
  [XmlEnum("M7")]
  July,
  
  /// <summary>
  /// Dates in August.
  /// </summary>
  [XmlEnum("M8")]
  August,
  
  /// <summary>
  /// Dates in September.
  /// </summary>
  [XmlEnum("M9")]
  September,
  
  /// <summary>
  /// Dates in October.
  /// </summary>
  [XmlEnum("M10")]
  October,
  
  /// <summary>
  /// Dates in November.
  /// </summary>
  [XmlEnum("M11")]
  November,
  
  /// <summary>
  /// Dates in December.
  /// </summary>
  [XmlEnum("M12")]
  December,
  
}
