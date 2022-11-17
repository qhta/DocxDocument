namespace DocumentModel.Spreadsheet;

public enum GroupBy
{

  [XmlEnum("range")]
  Range,

  [XmlEnum("seconds")]
  Seconds,

  [XmlEnum("minutes")]
  Minutes,

  [XmlEnum("hours")]
  Hours,

  [XmlEnum("days")]
  Days,

  [XmlEnum("months")]
  Months,

  [XmlEnum("quarters")]
  Quarters,

  [XmlEnum("years")]
  Years,
}
