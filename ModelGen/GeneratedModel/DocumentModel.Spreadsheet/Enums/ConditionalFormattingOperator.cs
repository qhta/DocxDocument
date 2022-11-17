namespace DocumentModel.Spreadsheet;

public enum ConditionalFormattingOperator
{
  
  [XmlEnum("lessThan")]
  LessThan,
  
  [XmlEnum("lessThanOrEqual")]
  LessThanOrEqual,
  
  [XmlEnum("equal")]
  Equal,
  
  [XmlEnum("notEqual")]
  NotEqual,
  
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
  
  [XmlEnum("greaterThan")]
  GreaterThan,
  
  [XmlEnum("between")]
  Between,
  
  [XmlEnum("notBetween")]
  NotBetween,
  
  [XmlEnum("containsText")]
  ContainsText,
  
  [XmlEnum("notContains")]
  NotContains,
  
  [XmlEnum("beginsWith")]
  BeginsWith,
  
  [XmlEnum("endsWith")]
  EndsWith,
}
