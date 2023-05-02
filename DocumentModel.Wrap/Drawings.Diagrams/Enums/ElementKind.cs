namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Element Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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