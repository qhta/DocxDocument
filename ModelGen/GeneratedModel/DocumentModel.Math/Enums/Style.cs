namespace DocumentModel.Math;

public enum Style
{

  [XmlEnum("p")]
  Plain,

  [XmlEnum("b")]
  Bold,

  [XmlEnum("i")]
  Italic,

  [XmlEnum("bi")]
  BoldItalic,
}
