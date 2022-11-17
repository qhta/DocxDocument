namespace DocumentModel.Spreadsheet;

public enum ConditionalFormatValueObject
{

  [XmlEnum("num")]
  Number,

  [XmlEnum("percent")]
  Percent,

  [XmlEnum("max")]
  Max,

  [XmlEnum("min")]
  Min,

  [XmlEnum("formula")]
  Formula,

  [XmlEnum("percentile")]
  Percentile,
}
