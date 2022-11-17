namespace DocumentModel.Vml.Office;

public enum BlackAndWhiteMode
{

  [XmlEnum("color")]
  Color,

  [XmlEnum("auto")]
  Auto,

  [XmlEnum("grayScale")]
  GrayScale,

  [XmlEnum("lightGrayScale")]
  LightGrayScale,

  [XmlEnum("inverseGray")]
  InverseGray,

  [XmlEnum("grayOutline")]
  GrayOutline,

  [XmlEnum("highContrast")]
  HighContrast,

  [XmlEnum("black")]
  Black,

  [XmlEnum("white")]
  White,

  [XmlEnum("undrawn")]
  Undrawn,

  [XmlEnum("blackTextAndLines")]
  BlackTextAndLines,
}
