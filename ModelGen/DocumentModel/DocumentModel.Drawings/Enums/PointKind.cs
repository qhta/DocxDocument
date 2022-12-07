namespace DocumentModel.Drawings;

/// <summary>
/// Point Type
/// </summary>
public enum PointKind
{
  /// <summary>
  /// Node.
  /// </summary>
  Node,
  
  /// <summary>
  /// Assistant Element.
  /// </summary>
  Assistant,
  
  /// <summary>
  /// Document.
  /// </summary>
  Document,
  
  /// <summary>
  /// Presentation.
  /// </summary>
  Presentation,
  
  /// <summary>
  /// Parent Transition.
  /// </summary>
  ParentTransition,
  
  /// <summary>
  /// Sibling Transition.
  /// </summary>
  SiblingTransition,
  
}
