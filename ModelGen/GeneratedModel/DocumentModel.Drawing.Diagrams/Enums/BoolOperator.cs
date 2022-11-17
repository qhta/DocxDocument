namespace DocumentModel.Drawing.Diagrams;

public enum BoolOperator
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("equ")]
  Equal,
  
  [XmlEnum("gte")]
  GreaterThanOrEqualTo,
  
  [XmlEnum("lte")]
  LessThanOrEqualTo,
}
