namespace DocumentModel.Drawings;

/// <summary>
/// Element Type
/// </summary>
public enum ElementKind
{
  /// <summary>
  /// All.
  /// </summary>
  [XmlEnum("all")]
  All,
  
  /// <summary>
  /// Document.
  /// </summary>
  [XmlEnum("doc")]
  Document,
  
  /// <summary>
  /// Node.
  /// </summary>
  [XmlEnum("node")]
  Node,
  
  /// <summary>
  /// Normal.
  /// </summary>
  [XmlEnum("norm")]
  Normal,
  
  /// <summary>
  /// Non Normal.
  /// </summary>
  [XmlEnum("nonNorm")]
  NonNormal,
  
  /// <summary>
  /// Assistant.
  /// </summary>
  [XmlEnum("asst")]
  Assistant,
  
  /// <summary>
  /// Non Assistant.
  /// </summary>
  [XmlEnum("nonAsst")]
  NonAssistant,
  
  /// <summary>
  /// Parent Transition.
  /// </summary>
  [XmlEnum("parTrans")]
  ParentTransition,
  
  /// <summary>
  /// Presentation.
  /// </summary>
  [XmlEnum("pres")]
  Presentation,
  
  /// <summary>
  /// Sibling Transition.
  /// </summary>
  [XmlEnum("sibTrans")]
  SiblingTransition,
  
}
