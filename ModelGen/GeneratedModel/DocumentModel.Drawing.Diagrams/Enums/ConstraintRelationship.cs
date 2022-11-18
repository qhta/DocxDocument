namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint Relationship
/// </summary>
public enum ConstraintRelationship
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
