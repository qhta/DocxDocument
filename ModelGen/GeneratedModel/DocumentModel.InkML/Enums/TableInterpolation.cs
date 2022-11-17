namespace DocumentModel.InkML;

public enum TableInterpolation
{

  [XmlEnum("floor")]
  Floor,

  [XmlEnum("middle")]
  Middle,

  [XmlEnum("ceiling")]
  Ceiling,

  [XmlEnum("linear")]
  Linear,

  [XmlEnum("cubic")]
  Cubic,
}
