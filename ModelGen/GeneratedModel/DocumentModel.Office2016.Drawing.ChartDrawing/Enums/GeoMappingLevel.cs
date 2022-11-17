namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public enum GeoMappingLevel
{
  
  [XmlEnum("dataOnly")]
  DataOnly,
  
  [XmlEnum("postalCode")]
  PostalCode,
  
  [XmlEnum("county")]
  County,
  
  [XmlEnum("state")]
  State,
  
  [XmlEnum("countryRegion")]
  CountryRegion,
  
  [XmlEnum("countryRegionList")]
  CountryRegionList,
  
  [XmlEnum("world")]
  World,
}
