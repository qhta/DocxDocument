namespace DocumentModel.Office2010.Excel;

public enum ConditionalFormattingValueObjectType
{

  [XmlEnum("num")]
  Numeric,

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

  [XmlEnum("autoMin")]
  AutoMin,

  [XmlEnum("autoMax")]
  AutoMax,
}
