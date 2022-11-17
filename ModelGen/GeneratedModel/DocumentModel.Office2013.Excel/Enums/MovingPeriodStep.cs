namespace DocumentModel.Office2013.Excel;

public enum MovingPeriodStep
{

  [XmlEnum("year")]
  Year,

  [XmlEnum("quarter")]
  Quarter,

  [XmlEnum("month")]
  Month,

  [XmlEnum("week")]
  Week,

  [XmlEnum("day")]
  Day,
}
