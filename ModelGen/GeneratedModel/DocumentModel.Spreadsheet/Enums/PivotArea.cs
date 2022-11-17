namespace DocumentModel.Spreadsheet;

public enum PivotArea
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("normal")]
  Normal,
  
  [XmlEnum("data")]
  Data,
  
  [XmlEnum("all")]
  All,
  
  [XmlEnum("origin")]
  Origin,
  
  [XmlEnum("button")]
  Button,
  
  [XmlEnum("topRight")]
  TopRight,
  
  [XmlEnum("topEnd")]
  TopEnd,
}
