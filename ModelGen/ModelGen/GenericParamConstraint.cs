using System.Xml.Serialization;

namespace ModelGen;

public enum GenericParamConstraint
{
  Covariant,
  Contravariant,
  ReferenceType,
  NotNullableValueType,
  Newable,
}