namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the PointType enumeration.
/// Used Iin types such as Constraint, DiagramChooseIf, ForEach.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PointType
{
  /// <summary>
  ///   Node.
  /// </summary>
  [OpenXmlEnumValue("Node")]
  Node,
  /// <summary>
  ///   Assistant Element.
  /// </summary>
  [OpenXmlEnumValue("Assistant")]
  Assistant,
  /// <summary>
  ///   IDocument.
  /// </summary>
  [OpenXmlEnumValue("IDocument")]
  IDocument,
  /// <summary>
  ///   Presentation.
  /// </summary>
  [OpenXmlEnumValue("Presentation")]
  Presentation,
  /// <summary>
  ///   Parent Transition.
  /// </summary>
  [OpenXmlEnumValue("ParentTransition")]
  ParentTransition,
  /// <summary>
  ///   Sibling Transition.
  /// </summary>
  [OpenXmlEnumValue("SiblingTransition")]
  SiblingTransition
}

