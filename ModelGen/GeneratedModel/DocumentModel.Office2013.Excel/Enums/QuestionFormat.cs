namespace DocumentModel.Office2013.Excel;

public enum QuestionFormat
{

  [XmlEnum("generalDate")]
  GeneralDate,

  [XmlEnum("longDate")]
  LongDate,

  [XmlEnum("shortDate")]
  ShortDate,

  [XmlEnum("longTime")]
  LongTime,

  [XmlEnum("shortTime")]
  ShortTime,

  [XmlEnum("generalNumber")]
  GeneralNumber,

  [XmlEnum("standard")]
  Standard,

  [XmlEnum("fixed")]
  Fixed,

  [XmlEnum("percent")]
  Percent,

  [XmlEnum("currency")]
  Currency,
}
