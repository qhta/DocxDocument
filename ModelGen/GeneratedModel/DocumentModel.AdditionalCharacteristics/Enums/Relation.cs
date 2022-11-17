namespace DocumentModel.AdditionalCharacteristics;

public enum Relation
{

  [XmlEnum("ge")]
  GreaterThanOrEqualTo,

  [XmlEnum("le")]
  LessThanOrEqualTo,

  [XmlEnum("gt")]
  GreaterThan,

  [XmlEnum("lt")]
  LessThan,

  [XmlEnum("eq")]
  EqualTo,
}
