namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pivot Filter Types
/// </summary>
public enum PivotFilterKind
{
  /// <summary>
  /// Unknown.
  /// </summary>
  Unknown,
  
  /// <summary>
  /// Count.
  /// </summary>
  Count,
  
  /// <summary>
  /// Percent.
  /// </summary>
  Percent,
  
  /// <summary>
  /// Sum.
  /// </summary>
  Sum,
  
  /// <summary>
  /// Caption Equals.
  /// </summary>
  CaptionEqual,
  
  /// <summary>
  /// Caption Not Equal.
  /// </summary>
  CaptionNotEqual,
  
  /// <summary>
  /// Caption Begins With.
  /// </summary>
  CaptionBeginsWith,
  
  /// <summary>
  /// Caption Does Not Begin With.
  /// </summary>
  CaptionNotBeginsWith,
  
  /// <summary>
  /// Caption Ends With.
  /// </summary>
  CaptionEndsWith,
  
  /// <summary>
  /// Caption Does Not End With.
  /// </summary>
  CaptionNotEndsWith,
  
  /// <summary>
  /// Caption Contains.
  /// </summary>
  CaptionContains,
  
  /// <summary>
  /// Caption Does Not Contain.
  /// </summary>
  CaptionNotContains,
  
  /// <summary>
  /// Caption Is Greater Than.
  /// </summary>
  CaptionGreaterThan,
  
  /// <summary>
  /// Caption Is Greater Than Or Equal To.
  /// </summary>
  CaptionGreaterThanOrEqual,
  
  /// <summary>
  /// Caption Is Less Than.
  /// </summary>
  CaptionLessThan,
  
  /// <summary>
  /// Caption Is Less Than Or Equal To.
  /// </summary>
  CaptionLessThanOrEqual,
  
  /// <summary>
  /// Caption Is Between.
  /// </summary>
  CaptionBetween,
  
  /// <summary>
  /// Caption Is Not Between.
  /// </summary>
  CaptionNotBetween,
  
  /// <summary>
  /// Value Equal.
  /// </summary>
  ValueEqual,
  
  /// <summary>
  /// Value Not Equal.
  /// </summary>
  ValueNotEqual,
  
  /// <summary>
  /// Value Greater Than.
  /// </summary>
  ValueGreaterThan,
  
  /// <summary>
  /// Value Greater Than Or Equal To.
  /// </summary>
  ValueGreaterThanOrEqual,
  
  /// <summary>
  /// Value Less Than.
  /// </summary>
  ValueLessThan,
  
  /// <summary>
  /// Value Less Than Or Equal To.
  /// </summary>
  ValueLessThanOrEqual,
  
  /// <summary>
  /// Value Between.
  /// </summary>
  ValueBetween,
  
  /// <summary>
  /// Value Not Between.
  /// </summary>
  ValueNotBetween,
  
  /// <summary>
  /// Date Equals.
  /// </summary>
  DateEqual,
  
  /// <summary>
  /// Date Does Not Equal.
  /// </summary>
  DateNotEqual,
  
  /// <summary>
  /// Date Older Than.
  /// </summary>
  DateOlderThan,
  
  /// <summary>
  /// Date Older Than Or Equal.
  /// </summary>
  DateOlderThanOrEqual,
  
  /// <summary>
  /// Date Newer Than.
  /// </summary>
  DateNewerThan,
  
  /// <summary>
  /// Date Newer Than or Equal To.
  /// </summary>
  DateNewerThanOrEqual,
  
  /// <summary>
  /// Date Between.
  /// </summary>
  DateBetween,
  
  /// <summary>
  /// Date Not Between.
  /// </summary>
  DateNotBetween,
  
  /// <summary>
  /// Tomorrow.
  /// </summary>
  Tomorrow,
  
  /// <summary>
  /// Today.
  /// </summary>
  Today,
  
  /// <summary>
  /// Yesterday.
  /// </summary>
  Yesterday,
  
  /// <summary>
  /// Next Week.
  /// </summary>
  NextWeek,
  
  /// <summary>
  /// This Week.
  /// </summary>
  ThisWeek,
  
  /// <summary>
  /// Last Week.
  /// </summary>
  LastWeek,
  
  /// <summary>
  /// Next Month.
  /// </summary>
  NextMonth,
  
  /// <summary>
  /// This Month.
  /// </summary>
  ThisMonth,
  
  /// <summary>
  /// Last Month.
  /// </summary>
  LastMonth,
  
  /// <summary>
  /// Next Quarter.
  /// </summary>
  NextQuarter,
  
  /// <summary>
  /// This Quarter.
  /// </summary>
  ThisQuarter,
  
  /// <summary>
  /// Last Quarter.
  /// </summary>
  LastQuarter,
  
  /// <summary>
  /// Next Year.
  /// </summary>
  NextYear,
  
  /// <summary>
  /// This Year.
  /// </summary>
  ThisYear,
  
  /// <summary>
  /// Last Year.
  /// </summary>
  LastYear,
  
  /// <summary>
  /// Year-To-Date.
  /// </summary>
  YearToDate,
  
  /// <summary>
  /// First Quarter.
  /// </summary>
  Quarter1,
  
  /// <summary>
  /// Second Quarter.
  /// </summary>
  Quarter2,
  
  /// <summary>
  /// Third Quarter.
  /// </summary>
  Quarter3,
  
  /// <summary>
  /// Fourth Quarter.
  /// </summary>
  Quarter4,
  
  /// <summary>
  /// January.
  /// </summary>
  January,
  
  /// <summary>
  /// Dates in February.
  /// </summary>
  February,
  
  /// <summary>
  /// Dates in March.
  /// </summary>
  March,
  
  /// <summary>
  /// Dates in April.
  /// </summary>
  April,
  
  /// <summary>
  /// Dates in May.
  /// </summary>
  May,
  
  /// <summary>
  /// Dates in June.
  /// </summary>
  June,
  
  /// <summary>
  /// Dates in July.
  /// </summary>
  July,
  
  /// <summary>
  /// Dates in August.
  /// </summary>
  August,
  
  /// <summary>
  /// Dates in September.
  /// </summary>
  September,
  
  /// <summary>
  /// Dates in October.
  /// </summary>
  October,
  
  /// <summary>
  /// Dates in November.
  /// </summary>
  November,
  
  /// <summary>
  /// Dates in December.
  /// </summary>
  December,
  
}
