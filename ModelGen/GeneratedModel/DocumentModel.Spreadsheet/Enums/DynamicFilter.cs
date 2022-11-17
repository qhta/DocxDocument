namespace DocumentModel.Spreadsheet;

public enum DynamicFilter
{

  [XmlEnum("null")]
  Null,

  [XmlEnum("aboveAverage")]
  AboveAverage,

  [XmlEnum("belowAverage")]
  BelowAverage,

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
