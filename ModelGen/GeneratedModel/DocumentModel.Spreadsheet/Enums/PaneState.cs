namespace DocumentModel.Spreadsheet;

public enum PaneState
{
  
  [XmlEnum("split")]
  Split,
  
  [XmlEnum("frozen")]
  Frozen,
  
  [XmlEnum("frozenSplit")]
  FrozenSplit,
}
