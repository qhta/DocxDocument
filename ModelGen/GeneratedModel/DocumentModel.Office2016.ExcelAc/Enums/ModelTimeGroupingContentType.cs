namespace DocumentModel.Office2016.ExcelAc;

public enum ModelTimeGroupingContentType
{

  [XmlEnum("years")]
  Years,

  [XmlEnum("quarters")]
  Quarters,

  [XmlEnum("monthsindex")]
  Monthsindex,

  [XmlEnum("months")]
  Months,

  [XmlEnum("daysindex")]
  Daysindex,

  [XmlEnum("days")]
  Days,

  [XmlEnum("hours")]
  Hours,

  [XmlEnum("minutes")]
  Minutes,

  [XmlEnum("seconds")]
  Seconds,
}
