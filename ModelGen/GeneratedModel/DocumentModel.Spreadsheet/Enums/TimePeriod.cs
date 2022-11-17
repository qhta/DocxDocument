namespace DocumentModel.Spreadsheet;

public enum TimePeriod
{
  
  [XmlEnum("today")]
  Today,
  
  [XmlEnum("yesterday")]
  Yesterday,
  
  [XmlEnum("tomorrow")]
  Tomorrow,
  
  [XmlEnum("last7Days")]
  Last7Days,
  
  [XmlEnum("thisMonth")]
  ThisMonth,
  
  [XmlEnum("lastMonth")]
  LastMonth,
  
  [XmlEnum("nextMonth")]
  NextMonth,
  
  [XmlEnum("thisWeek")]
  ThisWeek,
  
  [XmlEnum("lastWeek")]
  LastWeek,
  
  [XmlEnum("nextWeek")]
  NextWeek,
}
