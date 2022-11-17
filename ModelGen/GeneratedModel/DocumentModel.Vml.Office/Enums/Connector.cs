namespace DocumentModel.Vml.Office;

public enum Connector
{

  [XmlEnum("none")]
  None,

  [XmlEnum("straight")]
  Straight,

  [XmlEnum("elbow")]
  Elbow,

  [XmlEnum("curved")]
  Curved,
}
