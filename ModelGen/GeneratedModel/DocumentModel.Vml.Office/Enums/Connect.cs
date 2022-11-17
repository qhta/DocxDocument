namespace DocumentModel.Vml.Office;

public enum Connect
{

  [XmlEnum("none")]
  None,

  [XmlEnum("rect")]
  Rectangle,

  [XmlEnum("segments")]
  Segments,

  [XmlEnum("custom")]
  Custom,
}
