namespace DocumentModel.Wordprocessing;

public enum VerticalAlignment
{

  [XmlEnum("inline")]
  Inline,

  [XmlEnum("top")]
  Top,

  [XmlEnum("center")]
  Center,

  [XmlEnum("bottom")]
  Bottom,

  [XmlEnum("inside")]
  Inside,

  [XmlEnum("outside")]
  Outside,
}
