namespace DocumentModel.Spreadsheet;

public enum TextHorizontalAlignment
{

  [XmlEnum("left")]
  Left,

  [XmlEnum("center")]
  Center,

  [XmlEnum("right")]
  Right,

  [XmlEnum("justify")]
  Justify,

  [XmlEnum("distributed")]
  Distributed,
}
