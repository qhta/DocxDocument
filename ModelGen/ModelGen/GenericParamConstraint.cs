using System.Xml.Serialization;

namespace ModelGen;

public enum GenericParamConstraint
{
  [XmlAttribute("covariant")]
  Covariant,
  [XmlAttribute("contravariant")]
  Contravariant,
  [XmlAttribute("reference")]
  ReferenceType,
  [XmlAttribute("value")]
  ValueType,
  [XmlAttribute("notnullable")]
  NotNullable,
  [XmlAttribute("newable")]
  Newable,
}