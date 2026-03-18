namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ConstraintRelationship enumeration.
/// Used in types such as Constraint, Rule.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ConstraintRelationshipValues))]
public enum ConstraintRelationship
{
  /// <summary>
  ///   Self.
  /// </summary>
  [OpenXmlEnumValue("Self")]
  Self,
  /// <summary>
  ///   Child.
  /// </summary>
  [OpenXmlEnumValue("Child")]
  Child,
  /// <summary>
  ///   Descendant.
  /// </summary>
  [OpenXmlEnumValue("Descendant")]
  Descendant
}
