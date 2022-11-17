namespace DocumentModel.Drawing;

public enum BlipCompression
{

  [XmlEnum("email")]
  Email,

  [XmlEnum("screen")]
  Screen,

  [XmlEnum("print")]
  Print,

  [XmlEnum("hqprint")]
  HighQualityPrint,

  [XmlEnum("none")]
  None,
}
