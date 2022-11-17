namespace DocumentModel.Spreadsheet;

public enum FormulaExpression
{
  
  [XmlEnum("ref")]
  Reference,
  
  [XmlEnum("refError")]
  ReferenceError,
  
  [XmlEnum("area")]
  Area,
  
  [XmlEnum("areaError")]
  AreaError,
  
  [XmlEnum("computedArea")]
  ComputedArea,
}
