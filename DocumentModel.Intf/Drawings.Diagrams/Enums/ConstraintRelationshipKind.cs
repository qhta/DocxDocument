namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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