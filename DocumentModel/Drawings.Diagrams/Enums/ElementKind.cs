namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Element Type
/// </summary>
public enum ElementKind
{
  /// <summary>
  ///   All.
  /// </summary>
  All,

  /// <summary>
  ///   Document.
  /// </summary>
  Document,

  /// <summary>
  ///   Node.
  /// </summary>
  Node,

  /// <summary>
  ///   Normal.
  /// </summary>
  Normal,

  /// <summary>
  ///   Non Normal.
  /// </summary>
  NonNormal,

  /// <summary>
  ///   Assistant.
  /// </summary>
  Assistant,

  /// <summary>
  ///   Non Assistant.
  /// </summary>
  NonAssistant,

  /// <summary>
  ///   Parent Transition.
  /// </summary>
  ParentTransition,

  /// <summary>
  ///   Presentation.
  /// </summary>
  Presentation,

  /// <summary>
  ///   Sibling Transition.
  /// </summary>
  SiblingTransition
}