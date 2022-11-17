namespace DocumentModel.Wordprocessing;

public enum RestartNumber
{

  [XmlEnum("continuous")]
  Continuous,

  [XmlEnum("eachSect")]
  EachSection,

  [XmlEnum("eachPage")]
  EachPage,
}
