namespace DocumentModel.Spreadsheet;

public enum Sort
{

  [XmlEnum("none")]
  None,

  [XmlEnum("ascending")]
  Ascending,

  [XmlEnum("descending")]
  Descending,

  [XmlEnum("ascendingAlpha")]
  AscendingAlpha,

  [XmlEnum("descendingAlpha")]
  DescendingAlpha,

  [XmlEnum("ascendingNatural")]
  AscendingNatural,

  [XmlEnum("descendingNatural")]
  DescendingNatural,
}
