namespace DocumentModel.Wordprocessing;

public enum LineNumberRestart
{

  [XmlEnum("newPage")]
  NewPage,

  [XmlEnum("newSection")]
  NewSection,

  [XmlEnum("continuous")]
  Continuous,
}
