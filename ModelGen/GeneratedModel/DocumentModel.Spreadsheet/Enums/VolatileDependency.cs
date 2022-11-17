namespace DocumentModel.Spreadsheet;

public enum VolatileDependency
{
  
  [XmlEnum("realTimeData")]
  RealTimeData,
  
  [XmlEnum("olapFunctions")]
  OlapFunctions,
}
