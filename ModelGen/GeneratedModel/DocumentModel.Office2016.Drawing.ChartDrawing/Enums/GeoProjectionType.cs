namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public enum GeoProjectionType
{
  
  [XmlEnum("mercator")]
  Mercator,
  
  [XmlEnum("miller")]
  Miller,
  
  [XmlEnum("robinson")]
  Robinson,
  
  [XmlEnum("albers")]
  Albers,
}
