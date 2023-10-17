namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint Relationship
/// </summary>
public enum ConstraintRelationshipKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;self&quot;.
  /// </summary>
  Self,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ch&quot;.
  /// </summary>
  Child,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;des&quot;.
  /// </summary>
  Descendant,
  
}
