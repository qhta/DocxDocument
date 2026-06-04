namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ConstraintRelationship enumeration.
/// Used in types such as Constraint, Rule.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues))]
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

