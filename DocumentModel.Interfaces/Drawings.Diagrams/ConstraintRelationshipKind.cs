namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint Relationship
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConstraintRelationshipKind
{
  /// <summary>
  ///   Self.
  /// </summary>
  Self,
  /// <summary>
  ///   Child.
  /// </summary>
  Child,
  /// <summary>
  ///   Descendant.
  /// </summary>
  Descendant
}