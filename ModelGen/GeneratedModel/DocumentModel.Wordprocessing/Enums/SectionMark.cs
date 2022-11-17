namespace DocumentModel.Wordprocessing;

public enum SectionMark
{

  [XmlEnum("nextPage")]
  NextPage,

  [XmlEnum("nextColumn")]
  NextColumn,

  [XmlEnum("continuous")]
  Continuous,

  [XmlEnum("evenPage")]
  EvenPage,

  [XmlEnum("oddPage")]
  OddPage,
}
