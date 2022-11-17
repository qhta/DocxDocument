namespace DocumentModel.Spreadsheet;

public enum DataValidationOperator
{
  
  [XmlEnum("between")]
  Between,
  
  [XmlEnum("notBetween")]
  NotBetween,
  
  [XmlEnum("equal")]
  Equal,
  
  [XmlEnum("notEqual")]
  NotEqual,
  
  [XmlEnum("lessThan")]
  LessThan,
  
  [XmlEnum("lessThanOrEqual")]
  LessThanOrEqual,
  
  [XmlEnum("greaterThan")]
  GreaterThan,
  
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
}
