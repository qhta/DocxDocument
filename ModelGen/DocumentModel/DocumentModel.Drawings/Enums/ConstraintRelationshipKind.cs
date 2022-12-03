namespace DocumentModel.Drawings;

/// <summary>
/// Constraint Relationship
/// </summary>
public enum ConstraintRelationshipKind
{
  /// <summary>
  /// Self.
  /// </summary>
  [XmlEnum("self")]
  Self,
  
  /// <summary>
  /// Child.
  /// </summary>
  [XmlEnum("ch")]
  Child,
  
  /// <summary>
  /// Descendant.
  /// </summary>
  [XmlEnum("des")]
  Descendant,
  
}
