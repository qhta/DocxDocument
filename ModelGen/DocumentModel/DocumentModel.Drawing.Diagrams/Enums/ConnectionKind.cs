namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Connection Type
/// </summary>
public enum ConnectionKind
{
  /// <summary>
  /// Parent Of.
  /// </summary>
  ParentOf,
  
  /// <summary>
  /// Presentation Of.
  /// </summary>
  PresentationOf,
  
  /// <summary>
  /// Presentation Parent Of.
  /// </summary>
  PresentationParentOf,
  
  /// <summary>
  /// Unknown Relationship.
  /// </summary>
  UnknownRelationship,
  
}
