namespace DocumentModel.Wordprocessing;

public enum TableStyleOverride
{
  
  [XmlEnum("wholeTable")]
  WholeTable,
  
  [XmlEnum("firstRow")]
  FirstRow,
  
  [XmlEnum("lastRow")]
  LastRow,
  
  [XmlEnum("firstCol")]
  FirstColumn,
  
  [XmlEnum("lastCol")]
  LastColumn,
  
  [XmlEnum("band1Vert")]
  Band1Vertical,
  
  [XmlEnum("band2Vert")]
  Band2Vertical,
  
  [XmlEnum("band1Horz")]
  Band1Horizontal,
  
  [XmlEnum("band2Horz")]
  Band2Horizontal,
  
  [XmlEnum("neCell")]
  NorthEastCell,
  
  [XmlEnum("nwCell")]
  NorthWestCell,
  
  [XmlEnum("seCell")]
  SouthEastCell,
  
  [XmlEnum("swCell")]
  SouthWestCell,
}
