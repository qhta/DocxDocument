namespace DocumentModel.Spreadsheet;

public enum MdxSetOrder
{
  
  [XmlEnum("u")]
  Unsorted,
  
  [XmlEnum("a")]
  Ascending,
  
  [XmlEnum("d")]
  Descending,
  
  [XmlEnum("aa")]
  AlphaAscendingSortOrder,
  
  [XmlEnum("ad")]
  AlphaDescendingSortOrder,
  
  [XmlEnum("na")]
  NaturalAscending,
  
  [XmlEnum("nd")]
  NaturalDescending,
}
