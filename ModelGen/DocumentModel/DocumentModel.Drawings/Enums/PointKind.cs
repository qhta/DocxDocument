namespace DocumentModel.Drawings;

/// <summary>
/// Point Type
/// </summary>
public enum PointKind
{
  /// <summary>
  /// Node.
  /// </summary>
  [XmlEnum("node")]
  Node,
  
  /// <summary>
  /// Assistant Element.
  /// </summary>
  [XmlEnum("asst")]
  Assistant,
  
  /// <summary>
  /// Document.
  /// </summary>
  [XmlEnum("doc")]
  Document,
  
  /// <summary>
  /// Presentation.
  /// </summary>
  [XmlEnum("pres")]
  Presentation,
  
  /// <summary>
  /// Parent Transition.
  /// </summary>
  [XmlEnum("parTrans")]
  ParentTransition,
  
  /// <summary>
  /// Sibling Transition.
  /// </summary>
  [XmlEnum("sibTrans")]
  SiblingTransition,
  
}
