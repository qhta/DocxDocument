namespace DocumentModel.Drawing.Diagrams;

public enum FunctionOperator
{
  
  [XmlEnum("equ")]
  Equal,
  
  [XmlEnum("neq")]
  NotEqualTo,
  
  [XmlEnum("gt")]
  GreaterThan,
  
  [XmlEnum("lt")]
  LessThan,
  
  [XmlEnum("gte")]
  GreaterThanOrEqualTo,
  
  [XmlEnum("lte")]
  LessThanOrEqualTo,
}
