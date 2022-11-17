namespace DocumentModel.Spreadsheet;

public enum WebSource
{
  
  [XmlEnum("sheet")]
  Sheet,
  
  [XmlEnum("printArea")]
  PrintArea,
  
  [XmlEnum("autoFilter")]
  AutoFilter,
  
  [XmlEnum("range")]
  Range,
  
  [XmlEnum("chart")]
  Chart,
  
  [XmlEnum("pivotTable")]
  PivotTable,
  
  [XmlEnum("query")]
  Query,
  
  [XmlEnum("label")]
  Label,
}
