namespace DocumentModel.Wordprocessing;

public enum VerticalTextAlignment
{

  [XmlEnum("top")]
  Top,

  [XmlEnum("center")]
  Center,

  [XmlEnum("baseline")]
  Baseline,

  [XmlEnum("bottom")]
  Bottom,

  [XmlEnum("auto")]
  Auto,
}
