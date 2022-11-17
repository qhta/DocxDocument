namespace DocumentModel.Spreadsheet;

public enum ExternalConnection
{

  [XmlEnum("general")]
  General,

  [XmlEnum("text")]
  Text,

  [XmlEnum("MDY")]
  MonthDayYear,

  [XmlEnum("DMY")]
  DayMonthYear,

  [XmlEnum("YMD")]
  YearMonthDay,

  [XmlEnum("MYD")]
  MonthYearDay,

  [XmlEnum("DYM")]
  DayYearMonth,

  [XmlEnum("YDM")]
  YearDayMonth,

  [XmlEnum("skip")]
  Skip,

  [XmlEnum("EMD")]
  EMD,
}
