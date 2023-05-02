namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Point Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PointKind
{
  /// <summary>
  ///   Node.
  /// </summary>
  Node,

  /// <summary>
  ///   Assistant Element.
  /// </summary>
  Assistant,

  /// <summary>
  ///   Document.
  /// </summary>
  Document,

  /// <summary>
  ///   Presentation.
  /// </summary>
  Presentation,

  /// <summary>
  ///   Parent Transition.
  /// </summary>
  ParentTransition,

  /// <summary>
  ///   Sibling Transition.
  /// </summary>
  SiblingTransition
}