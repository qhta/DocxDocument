namespace DocumentModel.Presentation;

public enum PrintColorMode
{

  [XmlEnum("bw")]
  BlackWhite,

  [XmlEnum("gray")]
  Gray,

  [XmlEnum("clr")]
  Color,
}
