namespace DocumentModel.Spreadsheet;

public enum PivotFilter
{
  
  [XmlEnum("unknown")]
  Unknown,
  
  [XmlEnum("count")]
  Count,
  
  [XmlEnum("percent")]
  Percent,
  
  [XmlEnum("sum")]
  Sum,
  
  [XmlEnum("captionEqual")]
  CaptionEqual,
  
  [XmlEnum("captionNotEqual")]
  CaptionNotEqual,
  
  [XmlEnum("captionBeginsWith")]
  CaptionBeginsWith,
  
  [XmlEnum("captionNotBeginsWith")]
  CaptionNotBeginsWith,
  
  [XmlEnum("captionEndsWith")]
  CaptionEndsWith,
  
  [XmlEnum("captionNotEndsWith")]
  CaptionNotEndsWith,
  
  [XmlEnum("captionContains")]
  CaptionContains,
  
  [XmlEnum("captionNotContains")]
  CaptionNotContains,
  
  [XmlEnum("captionGreaterThan")]
  CaptionGreaterThan,
  
  [XmlEnum("captionGreaterThanOrEqual")]
  CaptionGreaterThanOrEqual,
  
  [XmlEnum("captionLessThan")]
  CaptionLessThan,
  
  [XmlEnum("captionLessThanOrEqual")]
  CaptionLessThanOrEqual,
  
  [XmlEnum("captionBetween")]
  CaptionBetween,
  
  [XmlEnum("captionNotBetween")]
  CaptionNotBetween,
  
  [XmlEnum("valueEqual")]
  ValueEqual,
  
  [XmlEnum("valueNotEqual")]
  ValueNotEqual,
  
  [XmlEnum("valueGreaterThan")]
  ValueGreaterThan,
  
  [XmlEnum("valueGreaterThanOrEqual")]
  ValueGreaterThanOrEqual,
  
  [XmlEnum("valueLessThan")]
  ValueLessThan,
  
  [XmlEnum("valueLessThanOrEqual")]
  ValueLessThanOrEqual,
  
  [XmlEnum("valueBetween")]
  ValueBetween,
  
  [XmlEnum("valueNotBetween")]
  ValueNotBetween,
  
  [XmlEnum("dateEqual")]
  DateEqual,
  
  [XmlEnum("dateNotEqual")]
  DateNotEqual,
  
  [XmlEnum("dateOlderThan")]
  DateOlderThan,
  
  [XmlEnum("dateOlderThanOrEqual")]
  DateOlderThanOrEqual,
  
  [XmlEnum("dateNewerThan")]
  DateNewerThan,
  
  [XmlEnum("dateNewerThanOrEqual")]
  DateNewerThanOrEqual,
  
  [XmlEnum("dateBetween")]
  DateBetween,
  
  [XmlEnum("dateNotBetween")]
  DateNotBetween,
  
  [XmlEnum("tomorrow")]
  Tomorrow,
  
  [XmlEnum("today")]
  Today,
  
  [XmlEnum("yesterday")]
  Yesterday,
  
  [XmlEnum("nextWeek")]
  NextWeek,
  
  [XmlEnum("thisWeek")]
  ThisWeek,
  
  [XmlEnum("lastWeek")]
  LastWeek,
  
  [XmlEnum("nextMonth")]
  NextMonth,
  
  [XmlEnum("thisMonth")]
  ThisMonth,
  
  [XmlEnum("lastMonth")]
  LastMonth,
  
  [XmlEnum("nextQuarter")]
  NextQuarter,
  
  [XmlEnum("thisQuarter")]
  ThisQuarter,
  
  [XmlEnum("lastQuarter")]
  LastQuarter,
  
  [XmlEnum("nextYear")]
  NextYear,
  
  [XmlEnum("thisYear")]
  ThisYear,
  
  [XmlEnum("lastYear")]
  LastYear,
  
  [XmlEnum("yearToDate")]
  YearToDate,
  
  [XmlEnum("Q1")]
  Quarter1,
  
  [XmlEnum("Q2")]
  Quarter2,
  
  [XmlEnum("Q3")]
  Quarter3,
  
  [XmlEnum("Q4")]
  Quarter4,
  
  [XmlEnum("M1")]
  January,
  
  [XmlEnum("M2")]
  February,
  
  [XmlEnum("M3")]
  March,
  
  [XmlEnum("M4")]
  April,
  
  [XmlEnum("M5")]
  May,
  
  [XmlEnum("M6")]
  June,
  
  [XmlEnum("M7")]
  July,
  
  [XmlEnum("M8")]
  August,
  
  [XmlEnum("M9")]
  September,
  
  [XmlEnum("M10")]
  October,
  
  [XmlEnum("M11")]
  November,
  
  [XmlEnum("M12")]
  December,
}
