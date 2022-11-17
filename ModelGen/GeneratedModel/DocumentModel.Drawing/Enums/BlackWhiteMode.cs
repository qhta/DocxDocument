namespace DocumentModel.Drawing;

public enum BlackWhiteMode
{

  [XmlEnum("clr")]
  Color,

  [XmlEnum("auto")]
  Auto,

  [XmlEnum("gray")]
  Gray,

  [XmlEnum("ltGray")]
  LightGray,

  [XmlEnum("invGray")]
  InvGray,

  [XmlEnum("grayWhite")]
  GrayWhite,

  [XmlEnum("blackGray")]
  BlackGray,

  [XmlEnum("blackWhite")]
  BlackWhite,

  [XmlEnum("black")]
  Black,

  [XmlEnum("white")]
  White,

  [XmlEnum("hidden")]
  Hidden,
}
