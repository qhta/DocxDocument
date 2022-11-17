namespace DocumentModel.Wordprocessing;

public enum TextWrapping
{

  [XmlEnum("auto")]
  Auto,

  [XmlEnum("notBeside")]
  NotBeside,

  [XmlEnum("around")]
  Around,

  [XmlEnum("tight")]
  Tight,

  [XmlEnum("through")]
  Through,

  [XmlEnum("none")]
  None,
}
