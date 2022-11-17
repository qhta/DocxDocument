namespace DocumentModel.Wordprocessing;

public enum TextBoxTightWrap
{

  [XmlEnum("none")]
  None,

  [XmlEnum("allLines")]
  AllLines,

  [XmlEnum("firstAndLastLine")]
  FirstAndLastLine,

  [XmlEnum("firstLineOnly")]
  FirstLineOnly,

  [XmlEnum("lastLineOnly")]
  LastLineOnly,
}
