namespace DocumentModel.Spreadsheet;

public enum FilterOperator
{
  
  [XmlEnum("equal")]
  Equal,
  
  [XmlEnum("lessThan")]
  LessThan,
  
  [XmlEnum("lessThanOrEqual")]
  LessThanOrEqual,
  
  [XmlEnum("notEqual")]
  NotEqual,
  
  [XmlEnum("greaterThanOrEqual")]
  GreaterThanOrEqual,
  
  [XmlEnum("greaterThan")]
  GreaterThan,
}
