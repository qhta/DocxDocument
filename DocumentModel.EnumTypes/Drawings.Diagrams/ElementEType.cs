namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ElementType enumeration.
/// Used in types such as AddOpenXmlElementAttribute, AddOpenXmlTypeAttribute, ChildElementInfoAttribute.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ElementType
{
  /// <summary>
  ///   All.
  /// </summary>
  [OpenXmlEnumValue("All")]
  All,
  /// <summary>
  ///   Document.
  /// </summary>
  [OpenXmlEnumValue("Document")]
  Document,
  /// <summary>
  ///   Node.
  /// </summary>
  [OpenXmlEnumValue("Node")]
  Node,
  /// <summary>
  ///   Normal.
  /// </summary>
  [OpenXmlEnumValue("Normal")]
  Normal,
  /// <summary>
  ///   Non Normal.
  /// </summary>
  [OpenXmlEnumValue("NonNormal")]
  NonNormal,
  /// <summary>
  ///   Assistant.
  /// </summary>
  [OpenXmlEnumValue("Assistant")]
  Assistant,
  /// <summary>
  ///   Non Assistant.
  /// </summary>
  [OpenXmlEnumValue("NonAssistant")]
  NonAssistant,
  /// <summary>
  ///   Parent Transition.
  /// </summary>
  [OpenXmlEnumValue("ParentTransition")]
  ParentTransition,
  /// <summary>
  ///   Presentation.
  /// </summary>
  [OpenXmlEnumValue("Presentation")]
  Presentation,
  /// <summary>
  ///   Sibling Transition.
  /// </summary>
  [OpenXmlEnumValue("SiblingTransition")]
  SiblingTransition
}
